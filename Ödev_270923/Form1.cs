namespace Ödev_270923
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string passwordIntensity = string.Empty;
        bool buyukHarfCheck, kucukHarfCheck, sayiCheck, ozelCheck;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            foreach (char c in txtSifre.Text)
            {
                if (c <= 90 && c >= 65)
                {
                    buyukHarfCheck = true;
                }

                if (c <= 122 && c >= 97)
                {
                    kucukHarfCheck = true;
                }

                if (c <= 57 && c >= 48)
                {
                    sayiCheck = true;
                }

                if ((c >= 33 && c <= 47) || (c >= 58 && c <= 64) || (c >= 91 && c <= 96) || (c >= 123 && c <= 126))
                {
                    ozelCheck = true;
                }
            }

            if (txtSifre.Text.Length > 6)
            {
                if (buyukHarfCheck || kucukHarfCheck || sayiCheck || ozelCheck)
                {
                    passwordIntensity = "Orta";
                    if ((buyukHarfCheck && kucukHarfCheck) || (buyukHarfCheck && sayiCheck) || (buyukHarfCheck && ozelCheck) || (kucukHarfCheck && sayiCheck) || (kucukHarfCheck && ozelCheck) || (sayiCheck && ozelCheck))
                    {
                        passwordIntensity = "Yüksek";
                        if ((buyukHarfCheck && kucukHarfCheck && sayiCheck) || (buyukHarfCheck && kucukHarfCheck && ozelCheck))
                        {
                            passwordIntensity = "Çok Yüksek";
                            if (buyukHarfCheck && kucukHarfCheck && sayiCheck && ozelCheck)
                            {
                                passwordIntensity = "Ultra Yüksek";
                            }
                        }
                    }

                }

            }
            else
            {
                passwordIntensity = "Düşük";
            }

            lblSifreZorlugu.Text = passwordIntensity;

            if (lblSifreZorlugu.Text == "Düşük")
            {
                lblSifreZorlugu.ForeColor = Color.Red;
            }
            else if (lblSifreZorlugu.Text == "Orta")
            {
                lblSifreZorlugu.ForeColor = Color.Orange;
            }
            else if (lblSifreZorlugu.Text == "Yüksek")
            {
                lblSifreZorlugu.ForeColor = Color.Green;
            }
            else if (lblSifreZorlugu.Text == "Çok Yüksek")
            {
                lblSifreZorlugu.ForeColor = Color.Aquamarine;
            }
            else if (lblSifreZorlugu.Text == "Ultra Yüksek")
            {
                lblSifreZorlugu.ForeColor = Color.Aqua;
            }



        }
    }
}