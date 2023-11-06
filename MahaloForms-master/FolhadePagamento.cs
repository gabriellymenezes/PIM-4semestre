using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



namespace MahaloForms
{
    public partial class FolhadePagamento : Form
    {


        public FolhadePagamento()
        {
            InitializeComponent();

        }

        private void FolhadePagamento_Load(object sender, EventArgs e)
        {

        }

        private int ConsultarIDFuncionario(string mes)
        {
            int idFuncionario = -1; // Inicializa com um valor que indica que o funcionário não foi encontrado

            string connectionString = "Data Source=CASA\\SQLEXPRESS;Initial Catalog=Tbmahalo;Integrated Security=True";
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();

                string query = "SELECT IDFuncionario FROM FolhaPagamento WHERE Mes = @mes AND IDFuncionario IN (SELECT IDFuncionario FROM dados_Pessoais WHERE IDFuncionario = @IDFuncionario)";
                SqlCommand command = new SqlCommand(query, conexao);
                command.Parameters.Add("@mes", SqlDbType.VarChar).Value = mes;
                command.Parameters.Add("@IDFuncionario", SqlDbType.VarChar).Value = idFuncionario;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idFuncionario = reader.GetInt32(0);
                    }
                }

                return idFuncionario;
            }
        }
        private string ConsultarMesReferencia()
        {

            return txtmes.Text;
        }

        private void button1btnPagar_Click(object sender, EventArgs e)

        {
            if (!int.TryParse(txtpesquisarfuncionario.Text, out int idFuncionario))
            {
                MessageBox.Show("Digite um ID de funcionário válido.");
                return;
            }

            string mes = txtmes.Text;

            if (string.IsNullOrEmpty(mes))
            {
                MessageBox.Show("Selecione o mês de referência.");
                return;
            }


            // Se ambos o ID do funcionário e o mês de referência forem válidos, prossiga com a consulta e os cálculos.
            RealizarConsultaEPagamento(idFuncionario, mes);
        }

        private void RealizarConsultaEPagamento(int idFuncionario, string mes)
        {
            string connectionString = "Data Source=CASA\\SQLEXPRESS;Initial Catalog=Tbmahalo;Integrated Security=True";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();

                // Query SQL para recuperar informações do funcionário
                string query = "SELECT dp.Nome AS [Nome], dp.CPF AS [CPF], dp.Cargo, dp.salario AS [salario], fp.mes AS [Mes], fp.ano AS [Ano], fp.NovaColunaHorasTrabalhadas AS [HorasTrabalhadas] FROM dados_Pessoais dp LEFT JOIN FolhaPagamento fp ON fp.IDFuncionario = dp.IDFuncionario WHERE dp.IDFuncionario = @IDFuncionario AND fp.mes = @mes";

                using (SqlCommand command = new SqlCommand(query, conexao))
                {
                    command.Parameters.Add("@IDFuncionario", SqlDbType.Int).Value = idFuncionario;
                    command.Parameters.Add("@mes", SqlDbType.VarChar).Value = mes;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nomeFuncionario = reader["Nome"].ToString();
                            string cpfFuncionario = reader["CPF"].ToString();
                            string cargoFuncionario = reader["Cargo"].ToString();

                            decimal salarioBase = Convert.ToDecimal(reader["salario"]);
                            decimal horasTrabalhadas = reader.GetDecimal(reader.GetOrdinal("HorasTrabalhadas"));


                            // Agora você tem as informações do funcionário do banco de dados
                            txtIdFuncionario.Text = idFuncionario.ToString();
                            txtNomeFuncionario.Text = nomeFuncionario;
                            txtCPFFuncionario.Text = cpfFuncionario;
                            txtCargo.Text = cargoFuncionario;
                            txtano.Text = "2023";
                            txtmes2.Text = mes;
                            txtCNPJEmpresa.Text = "56.440.956/2569-10";

                            // Realize os cálculos com base nas informações
                            decimal salarioBruto = salarioBase * horasTrabalhadas;
                            decimal fgts = salarioBruto * 0.08m; // 8% de FGTS
                            decimal inss = CalcularINSS(salarioBruto);
                            decimal irrf = CalcularIRRF(salarioBruto);

                            txtSalarioBruto.Text = salarioBruto.ToString("C");
                            txtFGTS.Text = fgts.ToString("C");
                            txtINSS.Text = inss.ToString("C");
                            txtIRRF.Text = irrf.ToString("C");

                            decimal totalDescontos = inss + irrf;
                            txtTotalDescontos.Text = totalDescontos.ToString("C");

                            decimal salarioLiquido = salarioBruto - totalDescontos;
                            txtSalarioLiquido.Text = salarioLiquido.ToString("C");
                        }
                        else
                        {
                            MessageBox.Show("Funcionário não encontrado para o mês e ano de referência especificados.");
                        }
                    }
                }
            }
        }

        // Função para converter horas no formato "HH:MM:SS" para um valor decimal
        private decimal ConverterHorasParaDecimal(string horasTrabalhadas)
        {
            if (TimeSpan.TryParse(horasTrabalhadas, out TimeSpan timeSpan))
            {
                // Converte o TimeSpan para minutos, incluindo frações de minutos
                decimal minutosDecimal = (decimal)timeSpan.TotalMinutes;
                return minutosDecimal;
            }
            return 0.0m; // Retorna 0 em caso de falha na conversão
        }



        private decimal CalcularINSS(decimal salarioBruto)
        {
            decimal descontoINSS = 0;

            if (salarioBruto <= 1320.00m)
            {
                descontoINSS = salarioBruto * 0.075m;
            }
            else if (salarioBruto <= 2571.29m)
            {
                descontoINSS = salarioBruto * 0.09m;
            }
            else if (salarioBruto <= 3856.94m)
            {
                descontoINSS = salarioBruto * 0.12m;
            }
            else
            {
                descontoINSS = salarioBruto * 0.14m;
            }
            return descontoINSS;
        }


        private decimal CalcularIRRF(decimal salarioBruto)
        {
            decimal descontoIRRF = 0;

            if (salarioBruto > 4664.68m)
            {
                descontoIRRF = (salarioBruto * 0.275m) - 884.96m;
            }
            else if (salarioBruto > 3751.05m)
            {
                descontoIRRF = (salarioBruto * 0.225m) - 651.73m;
            }
            else if (salarioBruto > 2826.65m)
            {
                descontoIRRF = (salarioBruto * 0.15m) - 370.40m;
            }
            else if (salarioBruto > 2112.01m)
            {
                descontoIRRF = (salarioBruto * 0.075m) - 158.40m;
            }

            return descontoIRRF;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void consultarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void BancodeHorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Cadastro de Funcionario"] == null)
            {
                // Se não houver, cria um novo formulário
                FolhadePonto FolhadePonto = new FolhadePonto();
                FolhadePonto.Show();

                // Fecha o formulário anterior 
                this.Hide();
            }
        }
    }
}