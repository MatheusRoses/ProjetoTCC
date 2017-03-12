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
    public partial class Form2 : Form
    {
        private DataGridViewRow dataGridViewRow;

        public Form2(String cbObjPrinc, string cbObjSecun, DataGridViewRow Linha)
        {
            InitializeComponent();

            txtObjPrincipais.Text = cbObjPrinc;
            txtObjSecun.Text = cbObjSecun;
            txtNomeAluno.Text = Linha.Cells[0].Value.ToString();
            txtID.Text = Linha.Cells[2].Value.ToString();

        }

        private void btnSalvaAvaliacao_Click(object sender, EventArgs e)
        {
            if (txtNomeAluno.Text == "")
            {
                MessageBox.Show("Campo 'Nome do Aluno' é obrigatório!");
            }
            else if (txtObjPrincipais.Text == "")
            {
                MessageBox.Show("Campo 'Objetivos Prinicipais' é obrigatório!");
            }
            else if (txtObjSecun.Text == "")
            {
                MessageBox.Show("Campo 'Objetivos Secundarios' é obrigatório!");
            }
            else if (txtNomeAvaliacao.Text == "")
            {
                MessageBox.Show("Campo 'Nome da Avaliação' é obrigatório!");
            } else
            {
                string conectarDB = "Persist Security Info=false;server=localhost;database=dbChecklist;uid=root;server=localhost;database=dbChecklist;uid=root;pwd=admin";
                MySqlConnection conectar = new MySqlConnection(conectarDB);
                try
                {
                    conectar.Open();
                    MySqlCommand command = new MySqlCommand("INSERT INTO avaliacao (nomeAluno,objPrinc,objSecun,nomeAvaliacao,nota,idAlunos)" + "VALUES('" + txtNomeAluno.Text + "','" + txtObjPrincipais.Text + "','" + txtObjSecun.Text + "','" + txtNomeAvaliacao.Text + "','" + txtNota.Text + "','" + txtID.Text + "')", conectar);
                    command.ExecuteNonQuery();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message.ToString());
                }

                MessageBox.Show("Desafio avaliado com sucesso");
                Close();
            }
        }

        private void rd100_CheckedChanged(object sender, EventArgs e)
        {
            if (rd100.Checked == true)
            {
               txtNota.Text = "100";
            }
            else
            {
                txtNota.Text = "";
            }
        }

        private void rd75_CheckedChanged(object sender, EventArgs e)
        {
            if (rd75.Checked == true)
            {
                txtNota.Text = "75";
            }
            else
            {
                txtNota.Text = "";
            }
        }

        private void rd60_CheckedChanged(object sender, EventArgs e)
        {
            if (rd60.Checked == true)
            {
                txtNota.Text = "60";
            }
            else
            {
                txtNota.Text = "";
            }
        }

        private void rd45_CheckedChanged(object sender, EventArgs e)
        {
            if (rd45.Checked == true)
            {
                txtNota.Text = "45";
            }
            else
            {
                txtNota.Text = "";
            }
        }

        private void rd25_CheckedChanged(object sender, EventArgs e)
        {
            if (rd25.Checked == true)
            {
                txtNota.Text = "25";
            }
            else
            {
                txtNota.Text = "";
            }
        }        
    }
}
