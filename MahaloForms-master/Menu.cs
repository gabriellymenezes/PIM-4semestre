using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MahaloForms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["COnsultar Funcionario"] == null)
            {
                // Se não houver, cria um novo formulário
                ConsultarFuncionario ConsultarFuncionario = new ConsultarFuncionario();
                ConsultarFuncionario.Show();

                // Fecha o formulário anterior 
                this.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
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

