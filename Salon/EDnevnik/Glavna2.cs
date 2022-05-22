﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDnevnik
{
    public partial class Glavna2 : Form
    {
        public Glavna2()
        {
            InitializeComponent();
        }

        private void raspodelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raspodela frm_raspodela = new Raspodela();
            frm_raspodela.Show();
        }

        private void osobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frm_sifarnik = new Sifarnik("Boja");
            frm_sifarnik.Show();
        }

        private void smeroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frm_smer = new Sifarnik("Kategorija");
            frm_smer.Show();
        }

        private void skolskeGodineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frm_sifarnik = new Sifarnik("Materijal");
            frm_sifarnik.Show();

        }

        private void predmetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frm_sifarnik = new Sifarnik("Proizvod");
            frm_sifarnik.Show();
        }

        private void Glavna2_Load(object sender, EventArgs e)
        {
            string user = Program.user_ime + " " + Program.user_prezime;
            lbl_korisnik.Text = user;
        }

        private void uOblikuGridaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void osobeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Osoba frm_osoba = new Osoba();
            frm_osoba.Show();

        }

    

        private void Glavna2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
        private void izvestajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frm_sifarnik = new Sifarnik("Magacin");
            frm_sifarnik.Show();
        }

        private void proizvodjacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frm_sifarnik = new Sifarnik("Proizvodjac");
            frm_sifarnik.Show();

        }

        private void korisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frm_sifarnik = new Sifarnik("Korisnik");
            frm_sifarnik.Show();
        }
    }
}
