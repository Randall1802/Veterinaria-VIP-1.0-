﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria__VIP_1._0_
{
    public partial class PaginaVentas : Form
    {
        private string user;

        public PaginaVentas()
        {
            InitializeComponent();
        }

        public PaginaVentas(string user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            PaginaPrincipal formularioNuevo = new PaginaPrincipal(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnMascota_Click_1(object sender, EventArgs e)
        {
            PaginaMascota formularioNuevo = new PaginaMascota(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnUsuario_Click_1(object sender, EventArgs e)
        {
            PaginaUsuario formularioNuevo = new PaginaUsuario(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnForo_Click(object sender, EventArgs e)
        {
            ForoVIP formularioNuevo = new ForoVIP(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void PaginaVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaPrincipal paginaPrincipal = new PaginaPrincipal(user);
            this.Hide();
            paginaPrincipal.Show();
            paginaPrincipal.FormClosed += (s, args) => this.Close();
        }
    }
}
