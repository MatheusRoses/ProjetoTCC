namespace ProjetoTCC
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dgDesafios = new System.Windows.Forms.DataGridView();
            this.dgAlunos = new System.Windows.Forms.DataGridView();
            this.btnAvaliacao = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.cbObjSecun = new System.Windows.Forms.ComboBox();
            this.cbObjPrinc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRanking = new System.Windows.Forms.Label();
            this.btnCadasAluno = new System.Windows.Forms.Button();
            this.dbchecklistDataSet = new ProjetoTCC.dbchecklistDataSet();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosTableAdapter = new ProjetoTCC.dbchecklistDataSetTableAdapters.alunosTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDesafios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbchecklistDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.webBrowser1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 479);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scratch";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 19);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(659, 454);
            this.webBrowser1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAtualizar);
            this.groupBox2.Controls.Add(this.dgDesafios);
            this.groupBox2.Controls.Add(this.dgAlunos);
            this.groupBox2.Controls.Add(this.btnAvaliacao);
            this.groupBox2.Controls.Add(this.btnRelatorios);
            this.groupBox2.Controls.Add(this.cbObjSecun);
            this.groupBox2.Controls.Add(this.cbObjPrinc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labelRanking);
            this.groupBox2.Controls.Add(this.btnCadasAluno);
            this.groupBox2.Location = new System.Drawing.Point(689, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 479);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(149, 451);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 14;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // dgDesafios
            // 
            this.dgDesafios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgDesafios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgDesafios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgDesafios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDesafios.Location = new System.Drawing.Point(9, 317);
            this.dgDesafios.Name = "dgDesafios";
            this.dgDesafios.Size = new System.Drawing.Size(228, 127);
            this.dgDesafios.TabIndex = 13;
            // 
            // dgAlunos
            // 
            this.dgAlunos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgAlunos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlunos.Location = new System.Drawing.Point(10, 48);
            this.dgAlunos.Name = "dgAlunos";
            this.dgAlunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAlunos.Size = new System.Drawing.Size(226, 163);
            this.dgAlunos.TabIndex = 12;
            // 
            // btnAvaliacao
            // 
            this.btnAvaliacao.Location = new System.Drawing.Point(126, 19);
            this.btnAvaliacao.Name = "btnAvaliacao";
            this.btnAvaliacao.Size = new System.Drawing.Size(111, 23);
            this.btnAvaliacao.TabIndex = 11;
            this.btnAvaliacao.Text = "Avaliação";
            this.btnAvaliacao.UseVisualStyleBackColor = true;
            this.btnAvaliacao.Click += new System.EventHandler(this.btnAvaliacao_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Location = new System.Drawing.Point(45, 450);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(75, 23);
            this.btnRelatorios.TabIndex = 10;
            this.btnRelatorios.Text = "Relatorios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // cbObjSecun
            // 
            this.cbObjSecun.FormattingEnabled = true;
            this.cbObjSecun.Items.AddRange(new object[] {
            "Laço de Repetição",
            "Laco de Decisão",
            "Estruturas Condicionais",
            "Operadores Logicos"});
            this.cbObjSecun.Location = new System.Drawing.Point(10, 270);
            this.cbObjSecun.Name = "cbObjSecun";
            this.cbObjSecun.Size = new System.Drawing.Size(226, 21);
            this.cbObjSecun.TabIndex = 9;
            this.cbObjSecun.SelectedIndexChanged += new System.EventHandler(this.cbObjSecun_SelectedIndexChanged);
            // 
            // cbObjPrinc
            // 
            this.cbObjPrinc.FormattingEnabled = true;
            this.cbObjPrinc.Items.AddRange(new object[] {
            "Laço de Repetição",
            "Laco de Decisão",
            "Estruturas Condicionais",
            "Operadores Logicos"});
            this.cbObjPrinc.Location = new System.Drawing.Point(10, 229);
            this.cbObjPrinc.Name = "cbObjPrinc";
            this.cbObjPrinc.Size = new System.Drawing.Size(228, 21);
            this.cbObjPrinc.TabIndex = 8;
            this.cbObjPrinc.SelectedIndexChanged += new System.EventHandler(this.cbObjPrinc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Objetivos Secundarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Objetivos Principais";
            // 
            // labelRanking
            // 
            this.labelRanking.AutoSize = true;
            this.labelRanking.Location = new System.Drawing.Point(6, 301);
            this.labelRanking.Name = "labelRanking";
            this.labelRanking.Size = new System.Drawing.Size(106, 13);
            this.labelRanking.TabIndex = 4;
            this.labelRanking.Text = "Ranking de Desafios";
            // 
            // btnCadasAluno
            // 
            this.btnCadasAluno.Location = new System.Drawing.Point(7, 19);
            this.btnCadasAluno.Name = "btnCadasAluno";
            this.btnCadasAluno.Size = new System.Drawing.Size(113, 23);
            this.btnCadasAluno.TabIndex = 0;
            this.btnCadasAluno.Text = "Alunos";
            this.btnCadasAluno.UseVisualStyleBackColor = true;
            this.btnCadasAluno.Click += new System.EventHandler(this.btnCadasAluno_Click);
            // 
            // dbchecklistDataSet
            // 
            this.dbchecklistDataSet.DataSetName = "dbchecklistDataSet";
            this.dbchecklistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "alunos";
            this.alunosBindingSource.DataSource = this.dbchecklistDataSet;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDesafios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbchecklistDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCadasAluno;
        private System.Windows.Forms.Button btnAvaliacao;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.ComboBox cbObjSecun;
        private System.Windows.Forms.ComboBox cbObjPrinc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRanking;
        private dbchecklistDataSet dbchecklistDataSet;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private dbchecklistDataSetTableAdapters.alunosTableAdapter alunosTableAdapter;
        private System.Windows.Forms.DataGridView dgDesafios;
        private System.Windows.Forms.DataGridView dgAlunos;
        private System.Windows.Forms.Button btnAtualizar;
    }
}

