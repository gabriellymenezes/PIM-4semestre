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
    public partial class Pagina_Inicial_RH : Form
    {
        private int idFuncionario;
        public Pagina_Inicial_RH()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Pagina_Inicial_RH_Load(object sender, EventArgs e)
        {

        }

        private void btnponto_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnfuncionario_Click(object sender, EventArgs e)
        {
            string Idfuncionario;
            string nome = txtnome.Text;
            string local = txtlocal.Text;
            string sexo = comboBoxSexo.SelectedItem.ToString();
            string estadoCivil = comboBoxEstadoCivil.SelectedItem.ToString();
            string escolaridade = comboBoxEscolaridade.SelectedItem.ToString();
            string endereco = txtendereco.Text;
            string cep = txtcep.Text;
            string cidade = txtcidade.Text;
            string bairro = txtbairro.Text;
            string cpf = txtcpf.Text;
            string tipoContrato = comboBoxContrato.SelectedItem.ToString();
            string cargo = txtcargo.Text;
            string setor = txtsetor.Text;
            string inicio = txtinicio.Text;
            string fim = txtfim.Text;
            string salario = txtsalario.Text;
            string dataNascimento = txtnascim.Text;
            string email = txtemail.Text;
            string telefone = txttel.Text;

            string connectionString = "Data Source=CASA\\SQLEXPRESS;Initial Catalog=Tbmahalo;Integrated Security=True;";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();
                // Cadastro de novo funcionário
                string insertQuery = "INSERT INTO dados_Pessoais (Nome, Locala, Sexo, Estadocivil, Escolaridade, Endereco, CEP, Cidade, Bairro, CPF, TipodeContrato, Cargo, Setor, Inicio, Fim, Salario, DataDeNascimento, Email, Telefone) " +
                                     "VALUES (@Nome, @Locala, @Sexo, @Estadocivil, @Escolaridade, @Endereco, @CEP, @Cidade, @Bairro, @CPF, @TipodeContrato, @Cargo, @Setor, @Inicio, @Fim, @Salario, @DataDeNascimento, @Email, @Telefone)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conexao))
                {
                    insertCmd.Parameters.AddWithValue("@Nome", nome);
                    insertCmd.Parameters.AddWithValue("@Locala", local);
                    insertCmd.Parameters.AddWithValue("@Sexo", sexo);
                    insertCmd.Parameters.AddWithValue("@Estadocivil", estadoCivil);
                    insertCmd.Parameters.AddWithValue("@Escolaridade", escolaridade);
                    insertCmd.Parameters.AddWithValue("@Endereco", endereco);
                    insertCmd.Parameters.AddWithValue("@CEP", cep);
                    insertCmd.Parameters.AddWithValue("@Cidade", cidade);
                    insertCmd.Parameters.AddWithValue("@Bairro", bairro);
                    insertCmd.Parameters.AddWithValue("@CPF", cpf);
                    insertCmd.Parameters.AddWithValue("@TipodeContrato", tipoContrato);
                    insertCmd.Parameters.AddWithValue("@Cargo", cargo);
                    insertCmd.Parameters.AddWithValue("@Setor", setor);
                    insertCmd.Parameters.AddWithValue("@Inicio", inicio);
                    insertCmd.Parameters.AddWithValue("@Fim", fim);
                    insertCmd.Parameters.AddWithValue("@Salario", salario);
                    insertCmd.Parameters.AddWithValue("@DataDeNascimento", dataNascimento);
                    insertCmd.Parameters.AddWithValue("@Email", email);
                    insertCmd.Parameters.AddWithValue("@Telefone", telefone);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Funcionário cadastrado com sucesso!");
                }
            }
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarDuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
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
