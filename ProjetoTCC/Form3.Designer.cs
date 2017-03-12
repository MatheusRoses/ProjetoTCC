namespace ProjetoTCC
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCadastrarAluno = new System.Windows.Forms.Label();
            this.labelNomeAluno = new System.Windows.Forms.Label();
            this.labelIdadeAluno = new System.Windows.Forms.Label();
            this.labelAnoEscolar = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtIdadeAluno = new System.Windows.Forms.TextBox();
            this.txtAnoEscolarAluno = new System.Windows.Forms.TextBox();
            this.btnSalvarCadastroAluno = new System.Windows.Forms.Button();
            this.rdMasc = new System.Windows.Forms.RadioButton();
            this.rdFem = new System.Windows.Forms.RadioButton();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCadastrarAluno
            // 
            this.labelCadastrarAluno.AutoSize = true;
            this.labelCadastrarAluno.Location = new System.Drawing.Point(13, 13);
            this.labelCadastrarAluno.Name = "labelCadastrarAluno";
            this.labelCadastrarAluno.Size = new System.Drawing.Size(82, 13);
            this.labelCadastrarAluno.TabIndex = 0;
            this.labelCadastrarAluno.Text = "Cadastrar Aluno";
            // 
            // labelNomeAluno
            // 
            this.labelNomeAluno.AutoSize = true;
            this.labelNomeAluno.Location = new System.Drawing.Point(13, 41);
            this.labelNomeAluno.Name = "labelNomeAluno";
            this.labelNomeAluno.Size = new System.Drawing.Size(83, 13);
            this.labelNomeAluno.TabIndex = 1;
            this.labelNomeAluno.Text = "Nome do Aluno:";
            // 
            // labelIdadeAluno
            // 
            this.labelIdadeAluno.AutoSize = true;
            this.labelIdadeAluno.Location = new System.Drawing.Point(13, 67);
            this.labelIdadeAluno.Name = "labelIdadeAluno";
            this.labelIdadeAluno.Size = new System.Drawing.Size(37, 13);
            this.labelIdadeAluno.TabIndex = 2;
            this.labelIdadeAluno.Text = "Idade:";
            // 
            // labelAnoEscolar
            // 
            this.labelAnoEscolar.AutoSize = true;
            this.labelAnoEscolar.Location = new System.Drawing.Point(13, 90);
            this.labelAnoEscolar.Name = "labelAnoEscolar";
            this.labelAnoEscolar.Size = new System.Drawing.Size(67, 13);
            this.labelAnoEscolar.TabIndex = 3;
            this.labelAnoEscolar.Text = "Ano Escolar:";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(102, 38);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(155, 20);
            this.txtNomeAluno.TabIndex = 4;
            // 
            // txtIdadeAluno
            // 
            this.txtIdadeAluno.Location = new System.Drawing.Point(102, 64);
            this.txtIdadeAluno.Name = "txtIdadeAluno";
            this.txtIdadeAluno.Size = new System.Drawing.Size(155, 20);
            this.txtIdadeAluno.TabIndex = 5;
            // 
            // txtAnoEscolarAluno
            // 
            this.txtAnoEscolarAluno.Location = new System.Drawing.Point(102, 87);
            this.txtAnoEscolarAluno.Name = "txtAnoEscolarAluno";
            this.txtAnoEscolarAluno.Size = new System.Drawing.Size(155, 20);
            this.txtAnoEscolarAluno.TabIndex = 6;
            // 
            // btnSalvarCadastroAluno
            // 
            this.btnSalvarCadastroAluno.Location = new System.Drawing.Point(12, 141);
            this.btnSalvarCadastroAluno.Name = "btnSalvarCadastroAluno";
            this.btnSalvarCadastroAluno.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCadastroAluno.TabIndex = 7;
            this.btnSalvarCadastroAluno.Text = "Criar";
            this.btnSalvarCadastroAluno.UseVisualStyleBackColor = true;
            this.btnSalvarCadastroAluno.Click += new System.EventHandler(this.btnSalvarCadastroAluno_Click);
            // 
            // rdMasc
            // 
            this.rdMasc.AutoSize = true;
            this.rdMasc.Location = new System.Drawing.Point(16, 113);
            this.rdMasc.Name = "rdMasc";
            this.rdMasc.Size = new System.Drawing.Size(73, 17);
            this.rdMasc.TabIndex = 8;
            this.rdMasc.TabStop = true;
            this.rdMasc.Text = "Masculino";
            this.rdMasc.UseVisualStyleBackColor = true;
            this.rdMasc.CheckedChanged += new System.EventHandler(this.rdMasc_CheckedChanged);
            // 
            // rdFem
            // 
            this.rdFem.AutoSize = true;
            this.rdFem.Location = new System.Drawing.Point(108, 114);
            this.rdFem.Name = "rdFem";
            this.rdFem.Size = new System.Drawing.Size(67, 17);
            this.rdFem.TabIndex = 9;
            this.rdFem.TabStop = true;
            this.rdFem.Text = "Feminino";
            this.rdFem.UseVisualStyleBackColor = true;
            this.rdFem.CheckedChanged += new System.EventHandler(this.rdFem_CheckedChanged);
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(247, 115);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(10, 20);
            this.txtSexo.TabIndex = 10;
            this.txtSexo.Visible = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(94, 141);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(81, 23);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(182, 141);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 12;
            this.btnDeletar.Text = "Excluir";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(231, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(26, 20);
            this.txtId.TabIndex = 19;
            this.txtId.Visible = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(204, 16);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 18;
            this.labelID.Text = "ID:";
            this.labelID.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 176);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.rdFem);
            this.Controls.Add(this.rdMasc);
            this.Controls.Add(this.btnSalvarCadastroAluno);
            this.Controls.Add(this.txtAnoEscolarAluno);
            this.Controls.Add(this.txtIdadeAluno);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.labelAnoEscolar);
            this.Controls.Add(this.labelIdadeAluno);
            this.Controls.Add(this.labelNomeAluno);
            this.Controls.Add(this.labelCadastrarAluno);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCadastrarAluno;
        private System.Windows.Forms.Label labelNomeAluno;
        private System.Windows.Forms.Label labelIdadeAluno;
        private System.Windows.Forms.Label labelAnoEscolar;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtIdadeAluno;
        private System.Windows.Forms.TextBox txtAnoEscolarAluno;
        private System.Windows.Forms.Button btnSalvarCadastroAluno;
        private System.Windows.Forms.RadioButton rdMasc;
        private System.Windows.Forms.RadioButton rdFem;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelID;
    }
}