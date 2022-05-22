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
    public partial class Sifarnik : Form
    {
        string ime_tabele;
        DataTable tabela;
        SqlDataAdapter Adapter;
        public Sifarnik(string tabela)
        {
            
            ime_tabele = tabela;
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sifarnik_Load(object sender, EventArgs e)
        {
            Adapter = new SqlDataAdapter("SELECT * FROM " + ime_tabele, Konekcija.Connect());
            tabela = new DataTable();
            Adapter.Fill(tabela);
            dataGridView2.DataSource = tabela;
            dataGridView2.Columns["id"].ReadOnly = true;

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DataTable menjano = tabela.GetChanges();
            Adapter.UpdateCommand = new SqlCommandBuilder(Adapter).GetUpdateCommand();
            if(menjano != null)
            {
                Adapter.Update(menjano);
                this.Close();
            }
        }
    }
}
