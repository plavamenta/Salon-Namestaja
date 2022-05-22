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
    public partial class Raspodela : Form
    {
        DataTable narudzbina;
        int broj_sloga = 0;
        public Raspodela()
        {
            InitializeComponent();
        }

        private void cmb_godina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Load_data()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Narudzbina", veza);
            narudzbina = new DataTable();
            adapter.Fill(narudzbina);
        }
        private void Raspodela_Load(object sender, EventArgs e)
        {
            Load_data();
            ComboFill();
        }

        private void ComboFill()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter;
            DataTable dt_proizvod, dt_korisnik;


            dt_korisnik = new DataTable();
            adapter = new SqlDataAdapter("SELECT id, ime+prezime as naziv FROM Korisnik WHERE uloga = 1", veza);
            adapter.Fill(dt_korisnik);

            dt_proizvod = new DataTable();
            adapter = new SqlDataAdapter("SELECT id, ime, cena FROM Proizvod", veza);
            adapter.Fill(dt_proizvod);


            txt_kolicina.Text = narudzbina.Rows[broj_sloga]["kolicina"].ToString();

            cmb_proizvod.ValueMember = "id";
            cmb_proizvod.DisplayMember = "ime";
            cmb_proizvod.DataSource = dt_proizvod;

            cmb_korisnik.ValueMember = "id";
            cmb_korisnik.DisplayMember = "naziv";
            cmb_korisnik.DataSource = dt_korisnik;


            txt_id.Text = narudzbina.Rows[broj_sloga]["id"].ToString();

            if (narudzbina.Rows.Count == 0)
            {
                cmb_proizvod.SelectedValue = -1;
                cmb_korisnik.SelectedValue = -1;

            }
            else
            {
                cmb_proizvod.SelectedValue = narudzbina.Rows[broj_sloga]["proizvod_id"];
                cmb_korisnik.SelectedValue = narudzbina.Rows[broj_sloga]["Kome_id"];
                ;
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

            if (broj_sloga == narudzbina.Rows.Count - 1)
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

        private void btn_first_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            ComboFill();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            ComboFill();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            ComboFill();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            broj_sloga = narudzbina.Rows.Count - 1;
            ComboFill();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            String Naredba = "DELETE FROM Narudzbina WHERE id = " + txt_id.Text;
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba, veza);
            Boolean brisano = false;
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
                brisano = true;
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            if (brisano)
            {
                Load_data();
                if (broj_sloga > 0) broj_sloga--;
                ComboFill();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("UPDATE Narudzbina SET ");
            Naredba.Append("proizvod_id = '" + cmb_proizvod.SelectedValue + "', ");
            Naredba.Append("Kome_id = '" + cmb_korisnik.SelectedValue + "', ");
            Naredba.Append("kolicina = " + Convert.ToUInt32(txt_kolicina.Text));
            Naredba.Append("WHERE id = " + txt_id.Text);

            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);

            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }

            Load_data();
            broj_sloga = narudzbina.Rows.Count - 1;
            ComboFill();
        }
    

        private void btn_add_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txt_kolicina.Text);
            StringBuilder Naredba = new StringBuilder("INSERT INTO Narudzbina (proizvod_id, Kome_id, Kolicina) VALUES ('");
            Naredba.Append(cmb_proizvod.SelectedValue + "', '");
            Naredba.Append(cmb_korisnik.SelectedValue + "', ");
            Naredba.Append(num + ")");
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);

            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }

            Load_data();
            broj_sloga = narudzbina.Rows.Count - 1;
            ComboFill();
        }

        private void lbl_odeljenje_Click(object sender, EventArgs e)
        {

        }

        private void lbl_predmet_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nastavnik_Click(object sender, EventArgs e)
        {

        }

        private void cmb_predmet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_nastavnik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_odeljenje_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }
    }
}
