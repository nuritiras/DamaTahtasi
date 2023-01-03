using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaTahtasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ButonOlustur();
        }

        private void ButonOlustur()
        {
            Button[,] button = new Button[8, 8];
            ushort ust = 0;
            ushort sol = 0;
            for (int i = 0; i < button.GetUpperBound(0); i++)
            {
                for (int j = 0; j < button.GetUpperBound(1); j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Height = 50;
                    button[i, j].Width = 50;
                    button[i, j].Left = sol;
                    button[i, j].Top = ust;
                    sol += 50;
                    if ((i + j) % 2 == 1)
                    {
                        button[i, j].BackColor = Color.White;
                    }
                    else
                    {
                        button[i, j].BackColor = Color.Black;
                    }
                    this.Controls.Add(button[i, j]);
                }
                sol = 0;
                ust += 50;
            }
        }
    }
}
