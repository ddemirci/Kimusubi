using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kimusubi
{
    public partial class KayitEkrani : Form
    {
        public KayitEkrani()
        {
            InitializeComponent();
            comboBox1.Items.Add("Kadın");
            comboBox1.Items.Add("Erkek");

            comboBox2.Items.Add("0");
            comboBox2.Items.Add("A");
            comboBox2.Items.Add("B");
            comboBox2.Items.Add("AB");

            comboBox3.Items.Add("Rh (+)");
            comboBox3.Items.Add("Rh (-)");


            textBox3.MaxLength = 11;
            textBox4.MaxLength = 3;
            textBox5.MaxLength = 10;

            //only digits allowed
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(textBoxEnableDigit);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(textBoxEnableDigit);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(textBoxEnableDigit);

            this.button1.Enabled = false;
            this.button1.Click += new EventHandler(kayıt_Button_Clicked);
        }

        private void textBoxEnableDigit(object Sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

       
        private void kayıt_Button_Clicked(object Sender, EventArgs e)
        {
            if(textBox1.Text != null &&
               textBox2.Text != null &&
               textBox3.Text != null &&
               textBox4.Text != null &&
               textBox5.Text != null &&
               textBox6.Text != null &&
               textBox7.Text != null &&
               comboBox1.SelectedIndex != -1 &&
               comboBox2.SelectedIndex != -1 &&
               comboBox3.SelectedIndex != -1 )
            {

            }
        }
    }
}
