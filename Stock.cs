﻿using System;
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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
            RedondearBoton(btn_CargarNuevoProducto,7 );
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Accede al formulario principal y lo minimiza
            Form formularioPrincipal = Application.OpenForms[0]; // Asume que el formulario principal es el primero abierto
            formularioPrincipal.WindowState = FormWindowState.Minimized;
        }

        private void Stock_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
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

    }
}
