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
        public int count = 0;
        public int[] bucket = new int[3];


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

                if (Convert.ToInt32(textBox1.Text) <= 0 || (Convert.ToInt32(textBox2.Text) <= 0 || (Convert.ToInt32(textBox3.Text) <= 0)))
                {
                    MessageBox.Show("Кол-во жизней робота не может быть 0 или меньше");
                }
                else
                {
                    if (count == 0)
                    {
                        robots[0].SetLife(Convert.ToInt32(textBox1.Text));
                        robots[1].SetLife(Convert.ToInt32(textBox2.Text));
                        robots[2].SetLife(Convert.ToInt32(textBox3.Text));
                        count++;
                    }
                    else
                    {
                        robots[0].SetLife(bucket[0]);
                        robots[1].SetLife(bucket[1]);
                        robots[2].SetLife(bucket[2]);

                        textBox1.Visible = false;
                        textBox2.Visible = false;
                        textBox3.Visible = false;
                    }
                    int startLife = robots[0].GetLife();
                    label1.Text = "Количество жизней робота1 в начале игры: " + robots[0].GetLife();
                    label2.Text = "Количество жизней робота2 в начале игры: " + robots[1].GetLife();
                    label3.Text = "Количество жизней робота3 в начале игры: " + robots[2].GetLife();
                    robots[0].min(startLife);
                    robots[0].Kol(startLife, new Robot[] { robots[1], robots[2] });
                    label6.Text = "Количество жизней робота1 в конце игры: " + robots[0].GetLife();
                    label5.Text = "Количество жизней робота2 в конце игры: " + robots[1].GetLife();
                    label4.Text = "Количество жизней робота3 в конце игры: " + robots[2].GetLife();

                    bucket[0] = robots[0].GetLife();
                    bucket[1] = robots[1].GetLife();
                    bucket[2] = robots[2].GetLife();
                }




            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
