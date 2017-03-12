using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProjetoTCC
{
    public partial class Form3 : Form
    {
        DataGridViewRow Linha;
        public Form3(DataGridViewRow Linha)
        {
            InitializeComponent();

            txtId.Text = Linha.Cells[2].Value.ToString();

        }

        private void btnSalvarCadastroAluno_Click(object sender, EventArgs e)
        {

            if (txtNomeAluno.Text == "")
            {
                MessageBox.Show("Campo 'Nome do Aluno' é obrigatório!");
            }
            else if (txtIdadeAluno.Text == "")
            {
                MessageBox.Show("Campo 'Idade do Aluno' é obrigatório!");
            }
            else if (txtAnoEscolarAluno.Text == "")
            {
                MessageBox.Show("Campo 'Ano Escolar' é obrigatório!");
            }
            else
            {

                string conectarDB = "Persist Security Info=false;server=localhost;database=dbChecklist;uid=root;server=localhost;database=dbChecklist;uid=root;pwd=admin";
                MySqlConnection conectar = new MySqlConnection(conectarDB);
                try
                {
                    conectar.Open();

                    MySqlCommand command = new MySqlCommand("INSERT INTO alunos (nomeAluno,idade,sexo,anoEscolar)" + "VALUES('" + txtNomeAluno.Text + "','" + txtIdadeAluno.Text + "','" + txtSexo.Text + "','" + txtAnoEscolarAluno.Text + "')", conectar);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Aluno Cadastrado com Sucesso");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message.ToString());
                }
                Close();
            }
        }

        private void rdMasc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMasc.Checked == true)
            {
                txtSexo.Text = "Mas";
            }
            else
            {
                txtSexo.Text = "";
            }
        }

        private void rdFem_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFem.Checked == true)
            {
                txtSexo.Text = "Fem";
            }
            else
            {
                txtSexo.Text = "";
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
         

            string conectarDB = "Persist Security Info=false;server=localhost;database=dbChecklist;uid=root;server=localhost;database=dbChecklist;uid=root;pwd=admin";
            MySqlConnection conectar = new MySqlConnection(conectarDB);
            try
            {
                conectar.Open();

                MySqlCommand command = new MySqlCommand("UPDATE alunos SET  nomeAluno= '" + txtNomeAluno.Text + "', idade='" + txtIdadeAluno.Text + "', sexo='" + txtSexo.Text + "', anoEscolar='" + txtAnoEscolarAluno.Text + "'WHERE idAlunos=" + int.Parse(txtId.Text), conectar);
                command.ExecuteNonQuery();

                MessageBox.Show("Aluno Atualizado com Sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString());
            }
            
        }
    

    private void btnDeletar_Click(object sender, EventArgs e)
    {
          

            string conectarDB = "Persist Security Info=false;server=localhost;database=dbChecklist;uid=root;server=localhost;database=dbChecklist;uid=root;pwd=admin";
        MySqlConnection conectar = new MySqlConnection(conectarDB);
        try
        {
            conectar.Open();

            MySqlCommand command = new MySqlCommand("DELETE FROM alunos WHERE id= " + int.Parse(txtId.Text), conectar);
            command.ExecuteNonQuery();

            MessageBox.Show("Aluno deletado com Sucesso");
        }
        catch (Exception erro)
        {
            MessageBox.Show(erro.Message.ToString());
        }

        Close();
    }
    }
}