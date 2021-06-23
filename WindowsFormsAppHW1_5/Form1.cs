﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHW1_5
{
    public partial class Form1 : Form
    {
        const int near = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(button1.Location.X-(Cursor.Position.X - Form1.ActiveForm.Location.X) < near && button1.Location.X - (Cursor.Position.X - Form1.ActiveForm.Location.X) > 0)
            {
                button1.Location = new Point(button1.Location.X + 1, button1.Location.Y);
            }
            else if (button1.Location.X - (Cursor.Position.X - Form1.ActiveForm.Location.X) > -near && button1.Location.X - (Cursor.Position.X - Form1.ActiveForm.Location.X) < 0)
            {
                button1.Location = new Point(button1.Location.X - 1, button1.Location.Y);
            }
            if (button1.Location.Y - (Cursor.Position.Y - Form1.ActiveForm.Location.Y) < near && button1.Location.Y - (Cursor.Position.Y - Form1.ActiveForm.Location.Y) > 0)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y + 1);
            }
            else if (button1.Location.Y - (Cursor.Position.Y - Form1.ActiveForm.Location.Y) > -near && button1.Location.Y - (Cursor.Position.Y - Form1.ActiveForm.Location.Y) < 0)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y - 1);
            }
        }
    }
}
