using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploPlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayStation2 N;
            N = new PlayStation2();
            N.Consola = "Consola: PlayStation2 Controles: ";
            N.Control = 4;
            N.Memoria = " Memoria: 100GB";
            N.Headset = " Headset: disponible  ";
            MessageBox.Show(N.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayStation1 G;
            G = new PlayStation1();
            G.Consola = "Consola: PlayStation 1 Controles: ";
            G.Control = 4;
            G.Memoria = " Memoria: 80gb";
            MessageBox.Show(G.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlayStation4 P;
            P = new PlayStation4();
            P.Consola = "Consola: PlayStation 4 Controles: ";
            P.Control = 1;
            P.Memoria = " Memoria: 1000GB";
            P.Online = " Modo Online disponible  ";
            P.Headset = " Headset: disponible  ";
            P.Sensormovimiento = "Sensor de movimiento: Disponible ";
            MessageBox.Show(P.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlayStation3 X;
            X = new PlayStation3();
            X.Consola = "Consola: PlayStation 3 Controles: ";
            X.Control = 4;
            X.Memoria = " Memoria: 700GB";
            X.Online = " Modo Online disponible  ";
            X.Headset = " Headset: disponible  ";
            MessageBox.Show(X.ToString());
        }
    }
}
