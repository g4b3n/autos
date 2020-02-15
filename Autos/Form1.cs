using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autos
{
    public partial class Autos : Form
    {

        public static bool benzin;
        public static bool gazolaj;


        public Autos()
        {
    
        InitializeComponent();
        

    }

        
        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            benzin = true;
            pictureBox1.Image = new Bitmap("benzin.jpg");
        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gazolaj = true;
            
            pictureBox1.Image = new Bitmap("gazolaj.jpg");
        }

        public void button_szamitas_Click(object sender, EventArgs e)
        {

            int motorterfogat = Convert.ToInt32(textBox2.Text);
            if (textBox2.Text =="0")
            {
                MessageBox.Show("Nem adtál meg motortérfogatot!", "Motortérfogat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            int megtettkm = Convert.ToInt32(textBox1.Text);
            if (textBox1.Text == "0")
            {
                MessageBox.Show("Nem adtál meg megtett kilométert!", "Megtett km", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            double atlagfogyasztas;
            double uzemanyagar;
                        
            if (benzin == true)
            {
                uzemanyagar = 402;
                if (motorterfogat <= 1000)
                {
                    atlagfogyasztas = 7.6;
                }
                else if (motorterfogat <= 1500 && motorterfogat >= 1001)
                {
                    atlagfogyasztas = 8.6;
                }
                else if (motorterfogat <= 2000 && motorterfogat >= 1501)
                {
                    atlagfogyasztas = 9.5;
                }
                else if (motorterfogat <= 3000 && motorterfogat >= 2001)
                {
                    atlagfogyasztas = 11.4;
                }
                else
                {
                    atlagfogyasztas = 13.3;
                }
            }
            
            else  
            {
                uzemanyagar = 425;
                if (motorterfogat <= 1500)
                {
                    atlagfogyasztas = 5.7;
                }
                else if (motorterfogat <= 2000 && motorterfogat >= 1501)
                {
                    atlagfogyasztas = 6.7;
                }
                else if (motorterfogat <= 3000 && motorterfogat >= 2001)
                {
                    atlagfogyasztas = 7.6;
                }
                else
                {
                    atlagfogyasztas = 9.5;
                }
                
            }
            textBox3.Text = Convert.ToString(atlagfogyasztas);
            textBox5.Text = Convert.ToString(uzemanyagar);
            

            double teljeskoltseg = ((atlagfogyasztas * uzemanyagar) * (megtettkm / 100.0));

            textBox4.Text = Convert.ToString(teljeskoltseg);




        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            Információk krumpli = new Információk();
            krumpli.Show();
        }
    }
}
