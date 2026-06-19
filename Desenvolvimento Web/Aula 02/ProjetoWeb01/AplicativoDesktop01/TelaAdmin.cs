using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace AplicativoDesktop01
{
    public partial class TelaAdmin : Form
    {
        private const string urlApiAdmin = "http://localhost:5057/api/usuarios/admin";
        // Ajuste a connectionString conforme seu ambiente ou mova para config
        private const string connectionString = "Server = ECFP507D1319381\\SQLEXPRESS01; Database = Aluno; Trusted_Connection = True; TrustServerCertificate = True;";

        public TelaAdmin()
        {
            InitializeComponent();
            _ = CarregarAlunosAsync();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private async Task CarregarAlunosAsync()
        {
            try
            {
                using var conexao = new SqlConnection(connectionString);
                await conexao.OpenAsync();

                const string sql = "SELECT CursoID, Nome, Email, Regra, StatuWIFI, StatusAction, RA, Senha FROM Alunos";
                using var comando = new SqlCommand(sql, conexao);
                using var reader = await comando.ExecuteReaderAsync();

                var tabela = new DataTable();
                tabela.Load(reader);

                dgvAlunos.Invoke(() => dgvAlunos.DataSource = tabela);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao carregar alunos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
