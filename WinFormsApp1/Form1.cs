using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Robot[] robots = new Robot[3];
                for (int i = 0; i < robots.Length; i++)
                {
                    robots[i] = new Robot();
                }
                robots[0].kollife = Convert.ToInt32(textBox1.Text);
                robots[1].kollife = Convert.ToInt32(textBox2.Text);
                robots[2].kollife = Convert.ToInt32(textBox3.Text);
                int startLife = robots[0].kollife;
                label1.Text = "Количество жизней робота1 в начале игры: " + robots[0].kollife;
                label2.Text = "Количество жизней робота2 в начале игры: " + robots[1].kollife;
                label3.Text = "Количество жизней робота3 в начале игры: " + robots[2].kollife;
                robots[0].min(startLife);
                robots[0].Kol(startLife, new Robot[] {robots[1], robots[2] });
                label6.Text = "Количество жизней робота1 в конце игры: " + robots[0].GetLife();
                label5.Text = "Количество жизней робота2 в конце игры: " + robots[1].GetLife();
                label4.Text = "Количество жизней робота3 в конце игры: " + robots[2].GetLife();




            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
                throw;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
