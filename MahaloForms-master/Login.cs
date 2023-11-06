using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MahaloForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private int ObterIDDoUsuario(string usuario, string senha)
        {
            int idFuncionario = -1; // Valor padrão, indicando que nenhum usuário foi encontrado

            string connectionString = "Data Source=CASA\\SQLEXPRESS;Initial Catalog=Tbmahalo;Integrated Security=True;";

            string query = "SELECT ID FROM Usuarios WHERE Usuario = @Usuario AND Senha = @Senha";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    conexao.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        idFuncionario = (int)result; // Obtém o ID do usuário
                    }
                }
            }

            return idFuncionario;
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)

        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            string connectionString = "Data Source=CASA\\SQLEXPRESS;Initial Catalog=Tbmahalo;Integrated Security=True;";

            string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Senha = @Senha";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    conexao.Open();
                    int count = (int)cmd.ExecuteScalar();

                    conexao.Close();

                  if (usuario == "admin" && senha == "456789")
                        {
                           
                            Menu menu = new Menu();
                            menu.Show();
                            this.Hide();
                        }
                        else if (count > 0)
                        {
                            int idFuncionario = ObterIDDoUsuario(usuario, senha);
                            Menu menu = new Menu();
                            menu.Show();
                            this.Hide();
                        }
                        else
                    {
                        MessageBox.Show("Nome de usuário ou senha incorretos.");
                    }

                }
            }
        }
    }
}

