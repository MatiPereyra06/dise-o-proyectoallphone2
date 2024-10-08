using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace diseño_proyectoallphone2
{
    public partial class MovimientoCaja : Form
    {
        public MovimientoCaja()
        {
            InitializeComponent();
            RedondearBoton(btn_IngredarMovimiento, 7);
            RedondearBoton(btn_AbrirCaja, 7);
            RedondearBoton(btn_CerrarCaja, 7);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MovimientoCaja_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        //metodo para redondear botones
        public void RedondearBoton(Button boton, int radio)
        {
            // Asegurar que el radio no sea mayor que la mitad del tamaño del botón
            if (radio > boton.Height / 2 || radio > boton.Width / 2)
            {
                radio = Math.Min(boton.Height, boton.Width) / 2;
            }

            GraphicsPath path = new GraphicsPath();

            // Crear las esquinas redondeadas
            path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90); // Esquina superior izquierda
            path.AddArc(new Rectangle(boton.Width - radio - 1, 0, radio, radio), 270, 90); // Esquina superior derecha
            path.AddArc(new Rectangle(boton.Width - radio - 1, boton.Height - radio - 1, radio, radio), 0, 90); // Esquina inferior derecha
            path.AddArc(new Rectangle(0, boton.Height - radio - 1, radio, radio), 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            // Asignar la región redondeada al botón
            boton.Region = new Region(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //cerrar
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Accede al formulario principal y lo minimiza
            Form formularioPrincipal = Application.OpenForms[0]; // Asume que el formulario principal es el primero abierto
            formularioPrincipal.WindowState = FormWindowState.Minimized;
        }

        private void btn_AbrirCaja_Click(object sender, EventArgs e)
        {

        }

        private void btn_CerrarCaja_Click(object sender, EventArgs e)
        {

        }

        private void MovimientoCaja_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
