using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using OpenTK;
using System.Windows.Forms;

namespace Graficos2dy3d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Superficie de dibujo
            Graphics g = e.Graphics;
            // Línea
            Pen lápiz = new Pen(Color.Bisque, 3);
            g.DrawLine(lápiz, 10, 10, 240, 100);
            // Rectangulo
            Rectangle rect = new Rectangle(10, 120, 230, 90);
            g.DrawRectangle(lápiz, rect);
            g.FillRectangle(Brushes.Bisque,rect);
            //Poligono
            PointF[] Poligono =
            {
                new Point(350, 1),
                new Point(240, 60),
                new Point(270, 170),
                new Point(430, 170),
                new Point(460, 60)
            };
            g.DrawPolygon(lápiz, Poligono);
            g.FillPolygon(Brushes.Bisque, Poligono);
            // Puntos que definen la curva flexible cardinal
            Point[] puntos = {
                new Point(561, 25),
                new Point(570, 15),
                new Point(500, 5),
                new Point(520, 25),
                new Point(550, 50),
                new Point(620, 200),
                new Point(520, 120) 
            };
            // Dibujar la curva
            g.DrawCurve(lápiz, puntos);
        }

        private void btn3d_Click(object sender, EventArgs e)
        {
            using (Game game = new Game())
            {
                game.Run(30, 30);
            }
        }
    }
}
