﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form2 : Form
    {
        bool click = false;
        Point PositionPix;
        public void FormExit() 
        {
            Dispose();   
        }

        public Form2()
        {
            InitializeComponent();
            PositionPix = pictureBox1.Location;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            //this.Close();
            form3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PositionPix = pictureBox1.Location;
            pictureBox1.Left = e.X;
            pictureBox1.Top = e.X;
            click = true;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
            PositionPix = pictureBox1.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (click) 
            {
                pictureBox1.Left = pictureBox1.Location.X + (e.X - PositionPix.X); 
                pictureBox1.Top = pictureBox1.Location.Y  + (e.Y - PositionPix.Y);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            { 
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
