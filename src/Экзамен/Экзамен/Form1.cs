using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экзамен
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            button1.Visible = false;

            textBox3.Visible = false;
            textBox4.Visible = false;
            label5.Visible = false;
            label6.Visible = false; 
            label3.Visible = false;
            label4.Visible = false;
            button2.Visible = false;

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string Path = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Path = openFileDialog1.FileName;

                webBrowser1.Navigate(new Uri(Path));

                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                button1.Visible = true;

                textBox3.Visible = true;
                textBox4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                button2.Visible = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);

                if (y + x * x <= 2)
                {
                    if (x <= y)
                    {
                        MessageBox.Show("принадлежит");
                    }
                    else
                    {
                        if (x >= 0 && x >= y && y >= 0)
                        {
                            MessageBox.Show("принадлежит");
                        }
                        else
                        {
                            MessageBox.Show("не принадлежит");
                        }
                    }
                }
                else
                    MessageBox.Show("не принадлежит");

            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вариант №3\nМинаев Георгий Владимирович");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox3.Text);
                double y = Convert.ToDouble(textBox4.Text);
                double r = 2;
                if ((x*x) + (y*y) <= (r*r))
                {
                    if (x >= 0 && y >= 0)
                    {
                        if (x + y >= 2)
                        {
                            MessageBox.Show("Точка входит в заданную область");
                        }
                        else
                        {
                            MessageBox.Show("Точка не входит в заданную область");
                        }
                    }
                    else
                    {
                        if (x < 0 && y > 0)
                        {
                            if (y - x <= 2)
                            {
                                MessageBox.Show("Точка входит в заданную область");
                            }
                            else
                            {
                                MessageBox.Show("Точка не входит в заданную область");
                            }
                        }
                        else
                        {
                            if (x < 0 && y < 0)
                            {
                                if (x + y <= -2)
                                {
                                    MessageBox.Show("Точка входит в заданную область");
                                }
                                else
                                {
                                    MessageBox.Show("Точка не входит в заданную область");
                                }
                            }
                            else
                            {
                                if (x - y <= 2)
                                {
                                    MessageBox.Show("Точка входит в заданную область");
                                }
                                else
                                {
                                    MessageBox.Show("Точка не входит в заданную область");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Точка не входит в заданную область");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
    }
}
