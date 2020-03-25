using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alan_Hesapla
{
    public partial class Form1 : Form
    {
        #region Metodlar

        #region üçgen

        public void üçgengizle()
        {

            textBox19.Enabled = false;
            textBox18.Enabled = false;
            textBox17.Enabled = false;
            textBox16.Enabled = false;
            textBox15.Enabled = false;
        
        }

        public void temizle1()
        {
            textBox19.Clear();
            textBox18.Clear();
            textBox17.Clear();
            textBox16.Clear();
            textBox15.Clear();
            textBox13.Clear();
        }
        #endregion

      


        #region Paralelkenar

        public void paralelkenargizle()
        {
            textBox30.Enabled = false;
            textBox31.Enabled = false;
            textBox32.Enabled = false;
            textBox33.Enabled = false;
            textBox34.Enabled = false;
            textBox35.Enabled = false;
            textBox36.Enabled = false;

        }

        public void paralelkenartemizle()
        {
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox34.Clear();
            textBox35.Clear();
            textBox36.Clear();
        }


        #endregion

        #endregion

        double sonuc, a, b, c, h, d;

        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Layout(object sender, LayoutEventArgs e)
        {
            üçgengizle();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                temizle1();
                textBox19.Enabled = true;
                textBox18.Enabled = true;
                textBox15.Enabled = true;
            }

            else if (radioButton6.Checked == false)
                üçgengizle();
            

        }

      

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                temizle1();
                textBox19.Enabled = true;
            
            }
            else if (radioButton5.Checked == false)
                üçgengizle();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                temizle1();
                textBox17.Enabled = true;
                textBox16.Enabled = true;
            
            
            }
            else if (radioButton2.Checked == false)
                üçgengizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          


            if (radioButton6.Checked == true)
            {
                a = int.Parse(textBox19.Text);
                b = int.Parse(textBox18.Text);
                d = int.Parse(textBox15.Text);

                sonuc = ((a * b) * (Math.Sin(Math.PI * d / 180))) / 2;


                textBox13.Text = sonuc.ToString();
            
            }

            else if (radioButton5.Checked == true)
            { 
            
                a = int.Parse(textBox19.Text);
                sonuc =((a*a*(Math.Sqrt(3))) / 4);
                textBox13.Text = sonuc.ToString();
            
            
            }

            else if(radioButton2.Checked==true)
            {
                c = int.Parse(textBox17.Text);
                h = int.Parse(textBox16.Text);

                sonuc = (c * h) / 2;
                textBox13.Text = sonuc.ToString();
            
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a;

            a = int.Parse(textBox21.Text);

            textBox20.Text = (a * a).ToString();
        }

        private void tabPage2_Layout(object sender, LayoutEventArgs e)
        {
            textBox21.Clear();
            textBox20.Clear();
        }

    

        private void button3_Click(object sender, EventArgs e)
        {
            textBox22.Text = (int.Parse(textBox23.Text) * int.Parse(textBox24.Text)).ToString();
        }

        private void tabPage3_Layout(object sender, LayoutEventArgs e)
        {
            textBox23.Clear();
            textBox24.Clear();
            textBox22.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox25.Text =(double.Parse(textBox26.Text)*(double.Parse(textBox26.Text) * (Math.PI)) / 4).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox27.Text = (double.Parse(textBox28.Text) * double.Parse(textBox29.Text)).ToString();
        }

        

        private void tabPage15_Layout(object sender, LayoutEventArgs e)
        {
            paralelkenargizle();
            paralelkenartemizle();


        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {

                textBox32.Enabled = true;
                textBox33.Enabled = true;
                textBox34.Enabled = true;
                textBox30.Enabled = true;



            }

            else
            {
                paralelkenargizle();
                paralelkenartemizle();
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {

                textBox33.Enabled = true;
                textBox30.Enabled = true;
                textBox35.Enabled = true;
                textBox36.Enabled = true;



            }

            else
            {
                paralelkenargizle();
                paralelkenartemizle();
            }
            
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {

                textBox32.Enabled = true;
                textBox31.Enabled = true;
                textBox30.Enabled = true;



            }

            else
            {
                paralelkenargizle();
                paralelkenartemizle();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
                textBox30.Text = (double.Parse(textBox32.Text) * double.Parse(textBox34.Text) *-1* Math.Sin(double.Parse(textBox33.Text))).ToString();
            else if (radioButton8.Checked == true)
                textBox30.Text = (double.Parse(textBox36.Text) * double.Parse(textBox35.Text) *-1* Math.Sin(double.Parse(textBox33.Text)) / 2).ToString();
            else
                textBox30.Text = (double.Parse(textBox32.Text) * double.Parse(textBox31.Text)).ToString();
        }

        private void tabPage16_Layout(object sender, LayoutEventArgs e)
        {
            textBox38.Clear();
            textBox39.Clear();
            textBox37.Clear();
            textBox40.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox38.Text = (((double.Parse(textBox40.Text) + double.Parse(textBox37.Text)) * double.Parse(textBox39.Text)) / 2).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox38.Clear();
            textBox39.Clear();
            textBox37.Clear();
            textBox40.Clear();
        }

      

        private void button13_Click(object sender, EventArgs e)
        {
            textBox41.Text = ((5 * double.Parse(textBox42.Text) * double.Parse(textBox42.Text) * Math.Tan(54)) / 4).ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox43.Text = ((3 * Math.Sqrt(3) * double.Parse(textBox44.Text) * double.Parse(textBox44.Text)) / 2).ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            temizle1();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox20.Clear();
            textBox21.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
           
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox25.Clear();
            textBox26.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox34.Clear();
            textBox35.Clear();
            textBox36.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox41.Clear();
            textBox42.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox43.Clear();
            textBox44.Clear();
        }
    }
}
