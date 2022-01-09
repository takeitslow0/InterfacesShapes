using InterfacesShapes.Models;
using InterfacesShapes.Models.Bases;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace InterfacesShapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbDaire_CheckedChanged(object sender, EventArgs e)
        {
            pDiger.Visible = false;
            pDaire.Visible = true;
        }

        private void rbDortgen_CheckedChanged(object sender, EventArgs e)
        {
            pDiger.Visible = true;
            pDaire.Visible = false;
        }

        private void rbUcgen_CheckedChanged(object sender, EventArgs e)
        {
            pDiger.Visible = true;
            pDaire.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pDiger.Location = new Point(12, 35);
            ddlIslem.Items.Add("Alan"); // 0
            ddlIslem.Items.Add("Çevre"); // 1
            ddlIslem.SelectedIndex = 0;




        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {


            lSonuc.Text = "Sonuç: ";
            double sonuc = 0;
            IRoundedShape roundedShape;
            IShapeWithAngles shapeWithAngles;
            if (rbDaire.Checked)
            {
                if (string.IsNullOrWhiteSpace(tbYaricap.Text))
                {
                    MessageBox.Show("Yarıçap boş girilemez!");
                    return;
                }
                roundedShape = new Circle()
                {
                    Radius = Convert.ToDouble(tbYaricap.Text, new CultureInfo("tr")),
                    IsPiThree = cbPi.Checked
                };
                sonuc = ddlIslem.SelectedIndex == 0 ? roundedShape.CalculateArea() : roundedShape.CalculateCircumference();
            }
            else if (rbDortgen.Checked)
            {
                if (string.IsNullOrWhiteSpace(tbGenislik.Text) || string.IsNullOrWhiteSpace(tbYukseklik.Text))
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz!");
                    return;
                }
                shapeWithAngles = new Models.Rectangle()
                {
                    Height = Convert.ToDouble(tbYukseklik.Text, new CultureInfo("tr")),
                    Width = Convert.ToDouble(tbGenislik.Text, new CultureInfo("tr"))
                };
                sonuc = ddlIslem.SelectedIndex == 0 ? shapeWithAngles.CalculateArea() : shapeWithAngles.CalculateCircumference();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tbGenislik.Text))
                {
                    MessageBox.Show("Genişlik boş bırakılamaz!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbYukseklik.Text))
                {
                    MessageBox.Show("Yükseklik Boş Girilemez!");
                    return;
                }
                shapeWithAngles = new Models.RightTriangle()
                {
                    Height = Convert.ToDouble(tbYukseklik.Text, new CultureInfo("tr")),
                    Width = Convert.ToDouble(tbGenislik.Text, new CultureInfo("tr"))
                };
                sonuc = ddlIslem.SelectedIndex == 0 ? shapeWithAngles.CalculateArea() : shapeWithAngles.CalculateCircumference();
            }
            lSonuc.Text += sonuc.ToString(new CultureInfo("tr"));
        }

        private void tbYaricap_KeyPress(object sender, KeyPressEventArgs e)
        {

            // özel karakterler girilmesini engeller!
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Kesirli sayılara izin verir
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

        }

        private void tbGenislik_KeyPress(object sender, KeyPressEventArgs e)
        {
            // özel karakterler girilmesini engeller!
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Kesirli sayılara izin verir
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbYukseklik_KeyPress(object sender, KeyPressEventArgs e)
        {
            // özel karakterler girilmesini engeller!
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Kesirli sayılara izin verir
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        #region Yöntem2
        //bool GirisKontrolEt1(string giris)
        //{
        //    string[] izinVerilenler = new string[]
        //    {
        //        "0", "1", "2", "3", "4", "5", "6" , "7","8","9","0",","
        //    };
        //    bool bulundu = true; // flag
        //    foreach (var karakter in giris) // 1a
        //    {
        //        bulundu = false;
        //        foreach (var izinVerilen in izinVerilenler)
        //        {
        //            if (karakter.ToString() == izinVerilen)
        //            {
        //                bulundu = true;
        //                break;
        //            }


        //        }
        //    }
        //    return bulundu;
        //}
        #endregion Yöntem2

        #region Hocanın Yöntemi
        //bool GirisKontorlEt(string giris)
        //{
        //    double sayi;
        //    bool sonuc = double.TryParse(giris, NumberStyles.Any, new CultureInfo("tr"), out sayi);
        //    return sonuc;
        //}
        #endregion
    }

}
