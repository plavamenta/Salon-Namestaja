﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EDnevnik
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(txt_name.Text=="" || txt_pass.Text == "")
            {
                MessageBox.Show("Unesite email i lozinku");
                return;
            }
            else
            {
                try
                {
                    SqlConnection veza = Konekcija.Connect();
                    SqlCommand komanda = new SqlCommand("SELECT *FROM Korisnik where email=@username", veza);
                    komanda.Parameters.AddWithValue("@username", txt_name.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    int brojac = tabela.Rows.Count;
                    if (brojac == 1)
                    {
                        if (String.Compare(tabela.Rows[0]["pass"].ToString(), txt_pass.Text) == 0)
                        {
                            MessageBox.Show("Uspesno ste se ulogovali");
                            Program.user_ime = tabela.Rows[0]["ime"].ToString();
                            Program.user_prezime = tabela.Rows[0]["prezime"].ToString();
                            Program.user_uloga = (int)tabela.Rows[0]["uloga"];
                            this.Hide();
                            Glavna2 frm_Glavna2 = new Glavna2();
                            frm_Glavna2.Show();
                        }
                        else
                        {
                            MessageBox.Show("Neispravna lozinka!");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Nepostojeci email!");
                    }
                }
                catch(Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }

            }
        }
    }
}
