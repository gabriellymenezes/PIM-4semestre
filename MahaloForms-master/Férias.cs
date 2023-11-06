using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MahaloForms
{
    public partial class Férias : Form
    {

        public Férias()
        {
            InitializeComponent();
        }

        private void Férias_Load(object sender, EventArgs e)
        {
        }

        private void BuscarFerias(int? idFuncionario)
        {
            string connectionString = "Data Source=CASA\\SQLEXPRESS;Initial Catalog=Tbmahalo;Integrated Security=True";
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();

                string query = "SELECT " +
                               "f.IDFuncionario AS [Id do Funcionario]," +
                               "dp.Nome AS [Nome], " +
                               "f.dataInicioFerias AS [Data de Início das Férias], " +
                               "f.dataTerminoFerias AS [Data de Término das Férias], " +
                               "DATEDIFF(day, f.dataInicioFerias, f.dataTerminoFerias) AS [Duração das Férias], " +
                               "f.statusFerias AS [Status das Férias] " +
                               "FROM Ferias f " +
                               "INNER JOIN dados_Pessoais dp ON f.IDFuncionario = dp.IDFuncionario " +
                               "WHERE f.IDFuncionario = @IDFuncionario";

                SqlCommand command = new SqlCommand(query, conexao);

                if (idFuncionario.HasValue)
                {
                    command.Parameters.Add("@IDFuncionario", SqlDbType.Int).Value = idFuncionario;
                }
                else
                {
                    command.Parameters.Add("@IDFuncionario", SqlDbType.Int).Value = DBNull.Value;
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewFerias.DataSource = dataTable; // dataGridViewFerias é o nome do seu DataGridView
            }
        }
        private void textBoxFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridViewFerias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void feriasfuncionario_Click(object sender, EventArgs e)
        {
            string input = txtpesquisar.Text;
            int idFuncionario;

            if (int.TryParse(input, out idFuncionario))
            {
                BuscarFerias(idFuncionario);
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de funcionário válido.");
            }
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DadosPessoaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Cadastro de Funcionario"] == null)
            {
                // Se não houver, cria um novo formulário
                Pagina_Inicial_RH Pagina_Inicial_RH = new Pagina_Inicial_RH();
                Pagina_Inicial_RH.Show();

                // Fecha o formulário anterior 
                this.Hide();
            }
        }

        private void consultarFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Consultar Funcionario"] == null)
            {
                // Se não houver, cria um novo formulário
                ConsultarFuncionario ConsultarFuncionario = new ConsultarFuncionario();
                ConsultarFuncionario.Show();

                // Fecha o formulário anterior 
                this.Hide();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Folha de Ponto"] == null)
            {
                // Se não houver, cria um novo formulário
                FolhadePonto FolhadePonto = new FolhadePonto();
                FolhadePonto.Show();

                // Fecha o formulário anterior 
                this.Hide();
            }
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FolhadePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Folha de Pagamento"] == null)
            {
                // Se não houver, cria um novo formulário
                FolhadePagamento FolhadePagamento = new FolhadePagamento();
                FolhadePagamento.Show();

                // Fecha o formulário anterior 
                this.Hide();
            }
        }
    }
}