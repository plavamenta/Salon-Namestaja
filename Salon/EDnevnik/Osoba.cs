using System;
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
    public partial class Osoba : Form
    {
        int broj_sloga = 0;
        DataTable tabela;
        string ime, prezime, adresa, email, pass;
        int uloga = -1;
        public Osoba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            Txt_Load();
        }
        private void Load_Data()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Korisnik", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);

        }

        private void Txt_Load()
        {
            if(tabela.Rows.Count == 0)
            {
                txt_id.Text = "";
                txt_ime.Text = "";
                txt_prezime.Text = "";
                txt_adresa.Text = "";
                txt_email.Text = "";
                txt_pass.Text = "";
                txt_uloga.Text = "";
            }
            else
            {
                txt_id.Text = tabela.Rows[broj_sloga]["id"].ToString();
                txt_ime.Text = tabela.Rows[broj_sloga]["ime"].ToString();
                txt_prezime.Text = tabela.Rows[broj_sloga]["prezime"].ToString();
                txt_adresa.Text = tabela.Rows[broj_sloga]["adresa"].ToString();
                txt_email.Text = tabela.Rows[broj_sloga]["email"].ToString();
                txt_pass.Text = tabela.Rows[broj_sloga]["pass"].ToString();
                txt_uloga.Text = tabela.Rows[broj_sloga]["uloga"].ToString();
            }
            if (broj_sloga == 0)
            {
                btn_first.Enabled = false;
                btn_prev.Enabled = false;
            }
            else
            {
                btn_first.Enabled = true;
                btn_prev.Enabled = true;
            }
            if (broj_sloga == tabela.Rows.Count - 1)
            {
                btn_last.Enabled = false;
                btn_next.Enabled = false;

            }
            else
            {
                btn_last.Enabled = true;
                btn_next.Enabled = true;

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.Connect();
            ime = txt_ime.Text;
            prezime = txt_prezime.Text;
            adresa = txt_adresa.Text;
            email = txt_email.Text;
            pass = txt_pass.Text;
            uloga = int.Parse(txt_uloga.Text);
            if (ime == "" && prezime == "" && adresa == "" && email == "" && pass == "" && uloga == -1)
                MessageBox.Show("Niste uneli nijedan podatak za updateovanje");
            veza.Open();
            SqlCommand naredba = new SqlCommand($"update Korisnik set ime = '{ime}', prezime = '{prezime}', adresa = '{adresa}',  email = '{email}', pass = '{pass}', uloga = '{uloga}' where id = {txt_id.Text}", veza);
            naredba.ExecuteNonQuery();
            veza.Close();
            tabela.Clear();
            Load_Data();
            Txt_Load();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            SqlConnection veza = Konekcija.Connect();
            SqlCommand naredba = new SqlCommand(String.Format($"delete from Korisnik where id={txt_id.Text}"), veza);
            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();
            tabela.Clear();
            Load_Data();
            broj_sloga = 0;
            Txt_Load();


        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void Osoba_Load(object sender, EventArgs e)
        {
            Load_Data();
            Txt_Load();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            Txt_Load();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            Txt_Load();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            broj_sloga = tabela.Rows.Count - 1;
            Txt_Load();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

            SqlConnection veza = Konekcija.Connect();
            ime = txt_ime.Text;
            prezime = txt_prezime.Text;
            adresa = txt_adresa.Text;
            email = txt_email.Text;
            pass = txt_pass.Text;
            uloga = int.Parse(txt_uloga.Text);
            try
            {
                veza.Open();
                SqlCommand naredba = new SqlCommand($"insert into Korisnik values('{ime}','{prezime}','{adresa}','{email}','{pass}','{uloga}')", veza);
                naredba.ExecuteNonQuery();
                veza.Close();
                tabela.Clear();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            Load_Data();
            broj_sloga = tabela.Rows.Count - 1;
            Txt_Load(); ;

        }
    }
}
