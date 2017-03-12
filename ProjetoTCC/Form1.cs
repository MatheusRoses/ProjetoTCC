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
using MySql.Data;



namespace ProjetoTCC
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

           
        }

        private void btnAvaliacao_Click(object sender, EventArgs e)
        {
            Form2 avaliacao = new Form2(cbObjPrinc.Text, cbObjSecun.Text, dgAlunos.CurrentRow);
            avaliacao.Show();
          

        }

        private void btnCadasAluno_Click(object sender, EventArgs e)
        {
            Form3 cadasAluno = new Form3 (dgAlunos.CurrentRow);
            cadasAluno.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           //webBrowser1.Navigate("https://scratch.mit.edu/projects/editor/");

            string conectarDB = "Persist Security Info=false;server=localhost;database=dbChecklist;uid=root;server=localhost;database=dbChecklist;uid=root;pwd=admin";
            MySqlConnection conectar = new MySqlConnection(conectarDB);

            conectar.Open();

            try
            {
                

                DataSet ds = new DataSet();
                MySqlDataAdapter alunos = new MySqlDataAdapter("Select nomeAluno NOME, idade IDADE, idAlunos ID From alunos", conectar);
                alunos.Fill(ds);
                dgAlunos.DataSource = ds;
                dgAlunos.DataMember = ds.Tables[0].TableName;               
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString());
            }
                      
            try
            { 
                DataSet ds = new DataSet();
            MySqlDataAdapter desafios = new MySqlDataAdapter("Select sum(nota)  From avaliacao INNER JOIN alunos ON avaliacao.idAlunos=alunos.idAlunos; ", conectar);
            desafios.Fill(ds);
            dgDesafios.DataSource = ds;
            dgDesafios.DataMember = ds.Tables[0].TableName;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString());
            }
        }

        private void cbObjPrinc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string objPrinc = cbObjPrinc.SelectedText;
        }

        private void cbObjSecun_SelectedIndexChanged(object sender, EventArgs e)
        {
            string objSecun = cbObjSecun.SelectedText;
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {

        }
    }
}
