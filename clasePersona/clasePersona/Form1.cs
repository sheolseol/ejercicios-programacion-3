﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace clasePersona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre = " + nombre.Text);
            MessageBox.Show("Apellido = " + apellido.Text);
            MessageBox.Show("Edad = " + edad.Text);
            MessageBox.Show("Sexo = " + sexo.Text);
            MessageBox.Show("Pais = " + pais.Text);
            MessageBox.Show("Direccion = " + direccion.Text);
        }

    }
}
