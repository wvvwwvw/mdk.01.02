using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BMIcalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void znach_Click(object sender, EventArgs e)
        {

        }

        string sex;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            woman.BorderStyle = BorderStyle.None;
            man.BorderStyle = BorderStyle.FixedSingle;
            man.BackColor = Color.Gainsboro;
            woman.BackColor = Color.White;
            sex = "male";

        }

        private void woman_Click(object sender, EventArgs e)
        {
            man.BorderStyle = BorderStyle.None;
            woman.BorderStyle = BorderStyle.FixedSingle;
            man.BackColor = Color.White;
            woman.BackColor = Color.Gainsboro;
            sex = "female";
            diag_pic.Image = System.Drawing.Image.FromFile("C:\\Users\\виолетта\\Desktop\\ed\\picc\\female-icon.png");
        }

        private void rasch_Click(object sender, EventArgs e)
        {
            double Weights = Convert.ToDouble(weight.Text);
            double Heights = Convert.ToDouble(height.Text);
            Heights = Heights / 100;
            double BMI = Math.Round(Weights / (Heights * Heights), 1);

      

            if (BMI < 18.5)
            {
                if (sex == "female")
                {
                    diag_pic.Image = System.Drawing.Image.FromFile("C:\\Users\\виолетта\\Desktop\\ed\\picc\\female-icon.png");
                }
                else
                {
                    diag_pic.Image = System.Drawing.Image.FromFile("C:\\Users\\виолетта\\Desktop\\ed\\picc\\bmi-underweight-icon.png");
                }
                trackBar.Value = Convert.ToInt32(BMI);
                diagg.Text = ("недостаточный");

            }
            else if (BMI < 24.9)
            {
                if (sex == "female")
                {
                    diag_pic.Image = System.Drawing.Image.FromFile("C:\\Users\\виолетта\\Desktop\\ed\\picc\\female-icon.png");
                }
                else
                {
                    diag_pic.Image = System.Drawing.Image.FromFile("C:\\Users\\виолетта\\Desktop\\ed\\picc\\bmi-healthy-icon.png");
                }
                trackBar.Value = Convert.ToInt32(BMI);
                diagg.Text = ("здоровый");
            }
            else if (BMI < 29.9)
            {
                if (sex == "female")
                {
                    diag_pic.Image = System.Drawing.Image.FromFile("C:\\Users\\виолетта\\Desktop\\ed\\picc\\female-icon.png");
                }
                else
                {
                    diag_pic.Image = System.Drawing.Image.FromFile("C:\\Users\\виолетта\\Desktop\\ed\\picc\\bmi-obese-icon.png");
                }
                trackBar.Value = Convert.ToInt32(BMI);
                diagg.Text = ("избыточный");
            }
            else if (BMI > 30)
            {
                if (sex == "female")
                {
                    diag_pic.Image = System.Drawing.Image.FromFile("C:\\Users\\виолетта\\Desktop\\ed\\picc\\female-icon.png");
                }
                else
                {
                    diag_pic.Image = System.Drawing.Image.FromFile("C:\\Users\\виолетта\\Desktop\\ed\\picc\\bmi-overweight-icon.png");
                }
                trackBar.Value = Convert.ToInt32(BMI);
                diagg.Text = ("Ожирение");
            }

            znach.Text = Convert.ToString(BMI);
        }

        private void otmen_Click(object sender, EventArgs e)
        {
            znach.Text = null;
            trackBar.Value = 10;
            height.Text = null;
            weight.Text = null;
            woman.BorderStyle = BorderStyle.None;
            man.BorderStyle = BorderStyle.None;
            woman.BackColor = Color.White;
            man.BackColor = Color.White;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void diagg_Click(object sender, EventArgs e)
        {

        }
    }
}
