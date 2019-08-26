﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BIZ;
using BIZ.Seguridad;
using BLL.GestoresSeguridad;

namespace GUI.Seguridad
{
    public partial class UCPerfilesUsuarios : UserControl
    {
        GestorUsuario UnGestorUsuario = new GestorUsuario();
        Usuario unUsuario = new Usuario();
        GestorPatente unGestorPatente = new GestorPatente();
        GestorFamilia unGestorFamilia = new GestorFamilia();

        public UCPerfilesUsuarios()
        {
            InitializeComponent();
           
        }
       

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void AdsdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCBitacora ucbit = new UCBitacora();
            ucbit.Show();
        }

        private void Button19_Click(object sender, EventArgs e)
        {           

            dgvUsuariosGestion.DataSource = null;
            dgvUsuariosGestion.DataSource = UnGestorUsuario.TraerTodo();           

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            // Bloqueo Controles
            //dgvUsuariosGestion.Enabled = false;
            //btnActualizarGrilla.Enabled = false;
            //btnCargarUsuario.Enabled = false;
            //btnDescartarCambiosUsuario.Enabled = true;
            //btnGuardarCambiosUsuario.Enabled = true;

            try
            {
                // Cargo Usuario seleccionado en grilla                
                unUsuario = new Usuario();
                unUsuario = (Usuario)dgvUsuariosGestion.CurrentRow.DataBoundItem ;
                // Logueo (traigo Perfil) del Usuario
                unUsuario = UnGestorUsuario.Login(unUsuario);

                CargarPermisosUsuario(unUsuario);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        private void Button4_Click_1(object sender, EventArgs e)
        {
            // Agregar Familia seleccionada de la grilla
            Familia unaFamilia = new Familia();
            unaFamilia = (Familia)dgvUsuarioSinFamilias.CurrentRow.DataBoundItem;

            unUsuario.AgregarFamilia(unaFamilia);

            CargarPermisosUsuario(unUsuario);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            // Quitar Familia seleccionada de la grilla
            Familia unaFamilia = new Familia();
            unaFamilia = (Familia)dgvFamiliasUsuario.CurrentRow.DataBoundItem;

            unUsuario.QuitarFamilia(unaFamilia);

            CargarPermisosUsuario(unUsuario);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            // Agrego Patente seleccionada de la grilla
            Patente unaPatente = new Patente();
            unaPatente = (Patente)dgvUsuarioSinPatentes.CurrentRow.DataBoundItem;

            unUsuario.AgregarPatente(unaPatente);

            CargarPermisosUsuario(unUsuario);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            // quito Patente seleccionada de la grilla
            Patente unaPatente = new Patente();
            unaPatente = (Patente)dgvPatentesUsuario.CurrentRow.DataBoundItem;

            unUsuario.QuitarPatente(unaPatente);

            CargarPermisosUsuario(unUsuario);
        }

        public void CargarPermisosUsuario(Usuario unUsuario)
        {
            List<Patente> PatentesFaltantes;
            List<Familia> FamiliasFaltantes;

            // Muestro las Familias del Usuario

            dgvFamiliasUsuario.DataSource = null;
            dgvFamiliasUsuario.DataSource = unUsuario.Perfil.Lista.Where(x => x.GetType() == typeof(Familia)).ToList();

            // Muestro todas las Patentes individuales del Usuario
            dgvPatentesUsuario.DataSource = null;
            dgvPatentesUsuario.DataSource = unUsuario.Perfil.Lista.Where(x => x.GetType() == typeof(Patente)).ToList();

            // Muestro las Patentes de las Familias que el Usuario tenga
            List<Permiso> miniLista = new List<Permiso>();
            miniLista = unUsuario.Perfil.Lista.Where(x => x.GetType() == typeof(Familia)).ToList();
            dgvUsuarioPatenteFamilia.DataSource = null;
            dgvUsuarioPatenteFamilia.DataSource = miniLista.SelectMany(x => x.ListaCompleta).Distinct().ToList();

            // Llevo todas las Patentes existentes a PatentesFaltantes
            PatentesFaltantes = new List<Patente>();
            PatentesFaltantes = unGestorPatente.TraerTodo();

            // Saco las Patentes que el Usuario ya tiene
            foreach (Patente item in unUsuario.Perfil.ListaCompleta)
            {
                if (PatentesFaltantes.Contains(item))
                    PatentesFaltantes.Remove(item);
            }

            // Muestro Patentes que Usuario no tiene esta bien el name del dg?LACONCHA
            dgvUsuarioSinPatentes.DataSource = null;
            dgvUsuarioSinPatentes.DataSource = PatentesFaltantes;

            // Llevo todas las Familias existentes a FamiliasFaltantes
            FamiliasFaltantes = unGestorFamilia.TraerTodo();

            // Saco las Familias que el Usuario ya tiene
            foreach (var item in unUsuario.Perfil.Lista)
            {
                if (item.GetType() == typeof(Familia))
                {
                    if (FamiliasFaltantes.Exists(x => x.Id == item.Id))
                        FamiliasFaltantes.RemoveAll(y => y.Id == item.Id);
                }
            }

            // Muestro Familias que Usuario no tiene
            dgvUsuarioSinFamilias.DataSource = null;
            dgvUsuarioSinFamilias.DataSource = FamiliasFaltantes;
        }

       

    }
}
