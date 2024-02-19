using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Button button = new Button();
            //button.Width = 50;
            //button.Height = 50;
            //button.Text = "MyButton";
            //this.Controls.Add(button);

            Button[,] buttons = new Button[8, 8];

            // int count = 1;


            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = buttons[i, j].Width * j;
                    buttons[i, j].Top = buttons[i, j].Height * i;
                    //buttons[i, j].Text = count.ToString();
                    //count++;
                    if (i % 2 == 0 && j % 2 == 1)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    if (i % 2 == 1 && j % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }

                    // Yada tek seferde

                    //if ((i + j) % 2 == 0)
                    //{
                    //    buttons[i, j].BackColor = Color.Black;
                    //}

                    this.Controls.Add(buttons[i, j]);
                }
            }
        }
    }
}
