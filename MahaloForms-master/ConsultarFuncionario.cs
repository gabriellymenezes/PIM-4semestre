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

namespace MahaloForms
{
    public partial class ConsultarFuncionario : Form
    {
        public ConsultarFuncionario()
        {
            InitializeComponent();
        }

        private void ConsultarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(txtIdFuncionari.Text, out int idFuncionario))
                {
                    string connectionString = "Data Source=CASA\\SQLEXPRESS;Initial Catalog=Tbmahalo;Integrated Security=True;";

                    using (SqlConnection conexao = new SqlConnection(connectionString))
                    {
                        conexao.Open();
                        string query = "SELECT * FROM dados_Pessoais WHERE IDFuncionario = @IDFuncionario";

                        using (SqlCommand command = new SqlCommand(query, conexao))
                        {
                            command.Parameters.AddWithValue("@IDFuncionario", idFuncionario);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Preencha os campos de texto com os dados do funcionário
                               
                                    txtIdFuncionario.Text = reader["IDFuncionario"].ToString();
                                    txtnome.Text = reader["Nome"].ToString();
                                    txtLocal.Text = reader["Locala"].ToString();
                                    txtsexo.Text = reader["Sexo"].ToString();
                                    txtestadocivil.Text = reader["Estadocivil"].ToString();
                                    txtescolaridade.Text = reader["Escolaridade"].ToString();
                                    txtendereco.Text = reader["Endereco"].ToString();
                                    txtcep.Text = reader["CEP"].ToString();
                                    txtcidade.Text = reader["Cidade"].ToString();
                                    txtbairro.Text = reader["Bairro"].ToString();
                                    txtcpf.Text = reader["CPF"].ToString();
                                    txtcontrato.Text = reader["TipodeContrato"].ToString();
                                    txtcargo.Text = reader["Cargo"].ToString();
                                    txtsetor.Text = reader["Setor"].ToString();
                                    txtinicio.Text = reader["Inicio"].ToString();
                                    txtfim.Text = reader["Fim"].ToString();
                                    txtsalario.Text = reader["Salario"].ToString();
                                    txtnascim.Text = reader["DataDeNascimento"].ToString();
                                    txtemail.Text = reader["Email"].ToString();
                                    txttel.Text = reader["Telefone"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Funcionário não encontrado.");
                                }
                            }
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Digite um ID de funcionário válido.");
                }
            }
        }
            
            private void SairToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        private void SairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FériasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Férias"] == null)
            {
                // Se não houver, cria um novo formulário
                Férias Férias = new Férias();
                Férias.Show();

                // Fecha o formulário anterior 
                this.Hide();
            }
        }

        private void BancodeHorasToolStripMenuItem_Click(object sender, EventArgs e)
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

        
