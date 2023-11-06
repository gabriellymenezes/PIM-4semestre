using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MahaloForms
{
    public partial class FolhadePonto : Form

    {
        public FolhadePonto()
        {
            InitializeComponent();

        }

        private void FolhadePonto_Load(object sender, EventArgs e)
        {
        }

        // Método para buscar dados da folha de ponto por ID ou nome
        private void BuscarFolhaPonto(int? id, string nome)
        {
            string connectionString = "Data Source=CASA\\SQLEXPRESS;Initial Catalog=Tbmahalo;Integrated Security=True";
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();

                string query = "SELECT rp.IDFuncionario AS[Id do Funcionario], dp.Nome AS[Nome], rp.Data AS[Data do Registro], rp.Entrada, rp.AlmocoInicio AS[Inicio do Almoço], rp.AlmocoFim AS[Fim do Almoço], rp.Saida, CONVERT(varchar, DATEADD(SECOND, DATEDIFF(SECOND, rp.Entrada, rp.Saida), 0), 108) AS[Horas Trabalhadas], CASE WHEN DATEDIFF(SECOND, rp.AlmocoInicio, rp.AlmocoFim) < 3600 THEN CASE WHEN DATEDIFF(SECOND, rp.Entrada, rp.Saida) -28800 > 0 THEN CONVERT(varchar, DATEADD(SECOND, DATEDIFF(SECOND, rp.Entrada, rp.Saida) -28800, 0), 108) ELSE '00:00:00' END ELSE CASE WHEN DATEDIFF(SECOND, rp.Entrada, rp.Saida) - DATEDIFF(SECOND, rp.AlmocoInicio, rp.AlmocoFim) - 28800 > 0 THEN CONVERT(varchar, DATEADD(SECOND, DATEDIFF(SECOND, rp.Entrada, rp.Saida) -DATEDIFF(SECOND, rp.AlmocoInicio, rp.AlmocoFim) - 28800, 0), 108) ELSE '00:00:00' END END AS[Horas Extras] FROM RegistroPonto rp INNER JOIN dados_Pessoais dp ON rp.IDFuncionario = dp.IDFuncionario WHERE(rp.IDFuncionario = @IDFuncionario OR @IDFuncionario IS NULL) AND(dp.Nome = @Nome OR @Nome IS NULL)";


                SqlCommand command = new SqlCommand(query, conexao);

                if (id.HasValue)
                {
                    command.Parameters.Add("@IDFuncionario", SqlDbType.Int).Value = id;
                }
                else
                {
                    command.Parameters.Add("@IDFuncionario", SqlDbType.Int).Value = DBNull.Value;
                }

                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = string.IsNullOrEmpty(nome) ? DBNull.Value : (object)nome;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewPonto.DataSource = dataTable; // dataGridViewPonto é o nome do seu DataGridView
            }
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
        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtpesquisarfuncionario.Text;
            int id;

            if (int.TryParse(input, out id))
            {
                // Pesquisar por ID se o input for um número
                BuscarFolhaPonto(id, null);
            }
            else
            {
                // Pesquisar por nome se o input não for um número
                BuscarFolhaPonto(0, input);
            }
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void FériasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Cadastro de Funcionario"] == null)
            {
                // Se não houver, cria um novo formulário
                Férias Férias = new Férias();
                Férias.Show();

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
    }
}

       