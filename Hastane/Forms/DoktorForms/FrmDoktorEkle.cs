using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.Forms.DoktorForms
{
    public partial class FrmDoktorEkle : Form
    {
        public FrmDoktorEkle()
        {
            InitializeComponent();
        }

        public void Temizle()

        {

            foreach (var item in this.Controls)
            {
                
                




                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }

                else if (item is ComboBox)
                {
                    ComboBox cmb = (ComboBox)item;
                    cmb.Text = "";
                }

                else if (item is NumericUpDown)
                {
                    NumericUpDown nmr = (NumericUpDown)item;
                    nmr.Value = 0;
                }

                else if (item is DateTimePicker)
                {
                    DateTimePicker dtm = (DateTimePicker)item;
                    dtm.Value = DateTime.Now;
                }

            }


        }
        private void FrmDoktorEkle_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(cinsiyet)))
            {
                comboCinsiDktEkle.Items.Add(item);
            }

            foreach (var item in Enum.GetValues(typeof(kan_grubu)))
            {
                comboKanDktEkle.Items.Add(item);
            }

            foreach (var item in Enum.GetValues(typeof(birim)))
            {
                comboBirimDktEkle.Items.Add(item);
            }

            foreach (var item in Enum.GetValues(typeof(unvan)))
            {
                comboUnvanDktEkle.Items.Add(item);
            }
        }

        private void btnDktEkleKaydet_Click(object sender, EventArgs e)
        {
            Kişi doktor = new Kişi();

            doktor.ad = txtDktAdEkle.Text;
            doktor.soyad = txtDktSoyadEkle.Text;
            doktor.TCKN = txtDktTCEkle.Text;
            doktor.D_tarihi = dateDktDogumEkle.Value;
            doktor.maas = NumMaasDktEkle.Value.ToString();
            

        }

        private void btnDktEkleTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
