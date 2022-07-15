using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Crud.Properties;

namespace Crud
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        //Conexão com o banco de dados
        string connectionBD = @"Server=.\sqlexpress;Database=BD_CADASTRO;Trusted_Connection=True;";

        private void Consulta_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM CLIENTE";

            System.Data.SqlClient.SqlConnection con = new SqlConnection(connectionBD);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            try
            {
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    DataTable table = new DataTable();
                    table.Load(reader);

                    dataGridView.DataSource = table;

                }
                else
                    MessageBox.Show("Nenhum registro encontrado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Application.OpenForms["frmCadastroCliente"].Visible = true;
            //sApplication.OpenForms["Consulta"].Visible = true;
            
        }
    }
}
