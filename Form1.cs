﻿using ooapLab3Startegy.Contexts;
using ooapLab3Startegy.Strategies;
using ooapLab3Startegy.Strategies.ArrStrategy;
using ooapLab3Startegy.Strategies.PointsStrategy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooapLab3Startegy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PointBut_Click(object sender, EventArgs e)
        {
            double x1, x2, y1, y2;

            x1 = double.Parse(X1.Text);
            x2 = double.Parse(X2.Text);
            y1 = double.Parse(Y1.Text);
            y2 = double.Parse(Y2.Text);

            var Points = new Points(x1, x2,y1,y2);

            string strategyName = comboBox1.Text;
                             
            pointRes.Text= Points.Calcuate(strategyName).ToString();
        }

        private void ArrBut_Click(object sender, EventArgs e)
        {
            int count = int.Parse(countArr.Text);
            if(5 >= count ||  count >= 30) {
                throw new Exception("Некоректное число эллементов в массиве.");
            }
            var arryas = new Arryas(count);
            ArrayAsText.Text = string.Join(",", arryas.arr);

            string strategyName = comboBox2.Text;
                     
            arrRes.Text = arryas.Calcuate(strategyName).ToString();
        }
    }
}
