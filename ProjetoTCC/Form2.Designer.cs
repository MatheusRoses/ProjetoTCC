namespace ProjetoTCC
{
    partial class Form2
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
            this.labelAvaliacoes = new System.Windows.Forms.Label();
            this.labelAluno = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.labelObjPrinc = new System.Windows.Forms.Label();
            this.labelObjSecun = new System.Windows.Forms.Label();
            this.txtObjPrincipais = new System.Windows.Forms.TextBox();
            this.txtObjSecun = new System.Windows.Forms.TextBox();
            this.labelNomeAvaliacao = new System.Windows.Forms.Label();
            this.txtNomeAvaliacao = new System.Windows.Forms.TextBox();
            this.rd100 = new System.Windows.Forms.RadioButton();
            this.rd75 = new System.Windows.Forms.RadioButton();
            this.rd60 = new System.Windows.Forms.RadioButton();
            this.rd45 = new System.Windows.Forms.RadioButton();
            this.rd25 = new System.Windows.Forms.RadioButton();
            this.btnSalvaAvaliacao = new System.Windows.Forms.Button();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtIdAvaliacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAvaliacoes
            // 
            this.labelAvaliacoes.AutoSize = true;
            this.labelAvaliacoes.Location = new System.Drawing.Point(12, 9);
            this.labelAvaliacoes.Name = "labelAvaliacoes";
            this.labelAvaliacoes.Size = new System.Drawing.Size(59, 13);
            this.labelAvaliacoes.TabIndex = 0;
            this.labelAvaliacoes.Text = "Avaliações";
            // 
            // labelAluno
            // 
            this.labelAluno.AutoSize = true;
            this.labelAluno.Location = new System.Drawing.Point(12, 36);
            this.labelAluno.Name = "labelAluno";
            this.labelAluno.Size = new System.Drawing.Size(83, 13);
            this.labelAluno.TabIndex = 1;
            this.labelAluno.Text = "Nome do Aluno:";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Enabled = false;
            this.txtNomeAluno.Location = new System.Drawing.Point(134, 33);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(152, 20);
            this.txtNomeAluno.TabIndex = 2;
            // 
            // labelObjPrinc
            // 
            this.labelObjPrinc.AutoSize = true;
            this.labelObjPrinc.Location = new System.Drawing.Point(12, 56);
            this.labelObjPrinc.Name = "labelObjPrinc";
            this.labelObjPrinc.Size = new System.Drawing.Size(102, 13);
            this.labelObjPrinc.TabIndex = 3;
            this.labelObjPrinc.Text = "Objetivos Principais:";
            // 
            // labelObjSecun
            // 
            this.labelObjSecun.AutoSize = true;
            this.labelObjSecun.Location = new System.Drawing.Point(12, 78);
            this.labelObjSecun.Name = "labelObjSecun";
            this.labelObjSecun.Size = new System.Drawing.Size(116, 13);
            this.labelObjSecun.TabIndex = 4;
            this.labelObjSecun.Text = "Objetivos Secundarios:";
            // 
            // txtObjPrincipais
            // 
            this.txtObjPrincipais.Enabled = false;
            this.txtObjPrincipais.Location = new System.Drawing.Point(134, 56);
            this.txtObjPrincipais.Name = "txtObjPrincipais";
            this.txtObjPrincipais.Size = new System.Drawing.Size(152, 20);
            this.txtObjPrincipais.TabIndex = 5;
            // 
            // txtObjSecun
            // 
            this.txtObjSecun.Enabled = false;
            this.txtObjSecun.Location = new System.Drawing.Point(134, 78);
            this.txtObjSecun.Name = "txtObjSecun";
            this.txtObjSecun.Size = new System.Drawing.Size(152, 20);
            this.txtObjSecun.TabIndex = 6;
            // 
            // labelNomeAvaliacao
            // 
            this.labelNomeAvaliacao.AutoSize = true;
            this.labelNomeAvaliacao.Location = new System.Drawing.Point(12, 101);
            this.labelNomeAvaliacao.Name = "labelNomeAvaliacao";
            this.labelNomeAvaliacao.Size = new System.Drawing.Size(103, 13);
            this.labelNomeAvaliacao.TabIndex = 7;
            this.labelNomeAvaliacao.Text = "Nome da Avaliação:";
            // 
            // txtNomeAvaliacao
            // 
            this.txtNomeAvaliacao.Location = new System.Drawing.Point(134, 101);
            this.txtNomeAvaliacao.Name = "txtNomeAvaliacao";
            this.txtNomeAvaliacao.Size = new System.Drawing.Size(152, 20);
            this.txtNomeAvaliacao.TabIndex = 8;
            // 
            // rd100
            // 
            this.rd100.AutoSize = true;
            this.rd100.Location = new System.Drawing.Point(15, 135);
            this.rd100.Name = "rd100";
            this.rd100.Size = new System.Drawing.Size(51, 17);
            this.rd100.TabIndex = 9;
            this.rd100.TabStop = true;
            this.rd100.Text = "100%";
            this.rd100.UseVisualStyleBackColor = true;
            this.rd100.CheckedChanged += new System.EventHandler(this.rd100_CheckedChanged);
            // 
            // rd75
            // 
            this.rd75.AutoSize = true;
            this.rd75.Location = new System.Drawing.Point(15, 159);
            this.rd75.Name = "rd75";
            this.rd75.Size = new System.Drawing.Size(45, 17);
            this.rd75.TabIndex = 10;
            this.rd75.TabStop = true;
            this.rd75.Text = "75%";
            this.rd75.UseVisualStyleBackColor = true;
            this.rd75.CheckedChanged += new System.EventHandler(this.rd75_CheckedChanged);
            // 
            // rd60
            // 
            this.rd60.AutoSize = true;
            this.rd60.Location = new System.Drawing.Point(15, 183);
            this.rd60.Name = "rd60";
            this.rd60.Size = new System.Drawing.Size(45, 17);
            this.rd60.TabIndex = 11;
            this.rd60.TabStop = true;
            this.rd60.Text = "60%";
            this.rd60.UseVisualStyleBackColor = true;
            this.rd60.CheckedChanged += new System.EventHandler(this.rd60_CheckedChanged);
            // 
            // rd45
            // 
            this.rd45.AutoSize = true;
            this.rd45.Location = new System.Drawing.Point(15, 207);
            this.rd45.Name = "rd45";
            this.rd45.Size = new System.Drawing.Size(45, 17);
            this.rd45.TabIndex = 12;
            this.rd45.TabStop = true;
            this.rd45.Text = "45%";
            this.rd45.UseVisualStyleBackColor = true;
            this.rd45.CheckedChanged += new System.EventHandler(this.rd45_CheckedChanged);
            // 
            // rd25
            // 
            this.rd25.AutoSize = true;
            this.rd25.Location = new System.Drawing.Point(15, 231);
            this.rd25.Name = "rd25";
            this.rd25.Size = new System.Drawing.Size(45, 17);
            this.rd25.TabIndex = 13;
            this.rd25.TabStop = true;
            this.rd25.Text = "25%";
            this.rd25.UseVisualStyleBackColor = true;
            this.rd25.CheckedChanged += new System.EventHandler(this.rd25_CheckedChanged);
            // 
            // btnSalvaAvaliacao
            // 
            this.btnSalvaAvaliacao.Location = new System.Drawing.Point(98, 257);
            this.btnSalvaAvaliacao.Name = "btnSalvaAvaliacao";
            this.btnSalvaAvaliacao.Size = new System.Drawing.Size(101, 23);
            this.btnSalvaAvaliacao.TabIndex = 14;
            this.btnSalvaAvaliacao.Text = "Salvar Avaliação";
            this.btnSalvaAvaliacao.UseVisualStyleBackColor = true;
            this.btnSalvaAvaliacao.Click += new System.EventHandler(this.btnSalvaAvaliacao_Click);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(241, 6);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(10, 20);
            this.txtNota.TabIndex = 15;
            this.txtNota.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(257, 7);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(29, 20);
            this.txtID.TabIndex = 16;
            // 
            // txtIdAvaliacao
            // 
            this.txtIdAvaliacao.Location = new System.Drawing.Point(219, 6);
            this.txtIdAvaliacao.Name = "txtIdAvaliacao";
            this.txtIdAvaliacao.Size = new System.Drawing.Size(15, 20);
            this.txtIdAvaliacao.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 292);
            this.Controls.Add(this.txtIdAvaliacao);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.btnSalvaAvaliacao);
            this.Controls.Add(this.rd25);
            this.Controls.Add(this.rd45);
            this.Controls.Add(this.rd60);
            this.Controls.Add(this.rd75);
            this.Controls.Add(this.rd100);
            this.Controls.Add(this.txtNomeAvaliacao);
            this.Controls.Add(this.labelNomeAvaliacao);
            this.Controls.Add(this.txtObjSecun);
            this.Controls.Add(this.txtObjPrincipais);
            this.Controls.Add(this.labelObjSecun);
            this.Controls.Add(this.labelObjPrinc);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.labelAluno);
            this.Controls.Add(this.labelAvaliacoes);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAvaliacoes;
        private System.Windows.Forms.Label labelAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label labelObjPrinc;
        private System.Windows.Forms.Label labelObjSecun;
        private System.Windows.Forms.TextBox txtObjPrincipais;
        private System.Windows.Forms.TextBox txtObjSecun;
        private System.Windows.Forms.Label labelNomeAvaliacao;
        private System.Windows.Forms.TextBox txtNomeAvaliacao;
        private System.Windows.Forms.RadioButton rd100;
        private System.Windows.Forms.RadioButton rd75;
        private System.Windows.Forms.RadioButton rd60;
        private System.Windows.Forms.RadioButton rd45;
        private System.Windows.Forms.RadioButton rd25;
        private System.Windows.Forms.Button btnSalvaAvaliacao;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtIdAvaliacao;
    }
}