namespace NotasUnopar
{
    partial class frmPrincipal
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
            this.btnDiscursivas = new System.Windows.Forms.Button();
            this.cb_questao11 = new System.Windows.Forms.ComboBox();
            this.cb_questao12 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbDiscursivas = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbObjetivas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnObjetivas = new System.Windows.Forms.Button();
            this.cb_qtd_objetivas = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txbConceito = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDiscursivas
            // 
            this.btnDiscursivas.Location = new System.Drawing.Point(20, 106);
            this.btnDiscursivas.Name = "btnDiscursivas";
            this.btnDiscursivas.Size = new System.Drawing.Size(96, 33);
            this.btnDiscursivas.TabIndex = 0;
            this.btnDiscursivas.Text = "CALCULAR";
            this.btnDiscursivas.UseVisualStyleBackColor = true;
            this.btnDiscursivas.Visible = false;
            this.btnDiscursivas.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_questao11
            // 
            this.cb_questao11.FormattingEnabled = true;
            this.cb_questao11.Items.AddRange(new object[] {
            "Sem Conceito",
            "Insuficiente",
            "Suficiente",
            "Bom",
            "Muito Bom",
            "Excelente"});
            this.cb_questao11.Location = new System.Drawing.Point(69, 28);
            this.cb_questao11.Name = "cb_questao11";
            this.cb_questao11.Size = new System.Drawing.Size(101, 21);
            this.cb_questao11.TabIndex = 1;
            this.cb_questao11.SelectedValueChanged += new System.EventHandler(this.button1_Click);
            // 
            // cb_questao12
            // 
            this.cb_questao12.FormattingEnabled = true;
            this.cb_questao12.Items.AddRange(new object[] {
            "Sem Conceito",
            "Insuficiente",
            "Suficiente",
            "Bom",
            "Muito Bom",
            "Excelente"});
            this.cb_questao12.Location = new System.Drawing.Point(69, 66);
            this.cb_questao12.Name = "cb_questao12";
            this.cb_questao12.Size = new System.Drawing.Size(101, 21);
            this.cb_questao12.TabIndex = 2;
            this.cb_questao12.SelectedValueChanged += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Questão 11";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Questão 12";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbDiscursivas);
            this.groupBox1.Controls.Add(this.cb_questao12);
            this.groupBox1.Controls.Add(this.btnDiscursivas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_questao11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 99);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QUESTÕES DISCURSIVAS";
            // 
            // txbDiscursivas
            // 
            this.txbDiscursivas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txbDiscursivas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiscursivas.Location = new System.Drawing.Point(180, 43);
            this.txbDiscursivas.Name = "txbDiscursivas";
            this.txbDiscursivas.ReadOnly = true;
            this.txbDiscursivas.Size = new System.Drawing.Size(76, 29);
            this.txbDiscursivas.TabIndex = 5;
            this.txbDiscursivas.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbObjetivas);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnObjetivas);
            this.groupBox2.Controls.Add(this.cb_qtd_objetivas);
            this.groupBox2.Location = new System.Drawing.Point(12, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 63);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "QUESTÕES OBJETIVAS";
            // 
            // txbObjetivas
            // 
            this.txbObjetivas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txbObjetivas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbObjetivas.Location = new System.Drawing.Point(186, 19);
            this.txbObjetivas.Name = "txbObjetivas";
            this.txbObjetivas.ReadOnly = true;
            this.txbObjetivas.Size = new System.Drawing.Size(70, 29);
            this.txbObjetivas.TabIndex = 3;
            this.txbObjetivas.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nº de Acertos";
            // 
            // btnObjetivas
            // 
            this.btnObjetivas.Location = new System.Drawing.Point(20, 62);
            this.btnObjetivas.Name = "btnObjetivas";
            this.btnObjetivas.Size = new System.Drawing.Size(96, 33);
            this.btnObjetivas.TabIndex = 1;
            this.btnObjetivas.Text = "CALCULAR";
            this.btnObjetivas.UseVisualStyleBackColor = true;
            this.btnObjetivas.Visible = false;
            this.btnObjetivas.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_qtd_objetivas
            // 
            this.cb_qtd_objetivas.FormattingEnabled = true;
            this.cb_qtd_objetivas.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb_qtd_objetivas.Location = new System.Drawing.Point(109, 23);
            this.cb_qtd_objetivas.Name = "cb_qtd_objetivas";
            this.cb_qtd_objetivas.Size = new System.Drawing.Size(64, 21);
            this.cb_qtd_objetivas.TabIndex = 0;
            this.cb_qtd_objetivas.SelectedValueChanged += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 33);
            this.button3.TabIndex = 7;
            this.button3.Text = "CONCEITO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txbConceito
            // 
            this.txbConceito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txbConceito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConceito.Location = new System.Drawing.Point(122, 22);
            this.txbConceito.Name = "txbConceito";
            this.txbConceito.ReadOnly = true;
            this.txbConceito.Size = new System.Drawing.Size(134, 29);
            this.txbConceito.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.txbConceito);
            this.groupBox3.Location = new System.Drawing.Point(12, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 65);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NotasUnopar.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 77);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(32, 23);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(235, 28);
            this.lbTitulo.TabIndex = 11;
            this.lbTitulo.Text = "CONCEITO UNOPAR";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 341);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conceito Prova Presencial";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiscursivas;
        private System.Windows.Forms.ComboBox cb_questao11;
        private System.Windows.Forms.ComboBox cb_questao12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnObjetivas;
        private System.Windows.Forms.ComboBox cb_qtd_objetivas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txbDiscursivas;
        private System.Windows.Forms.TextBox txbObjetivas;
        private System.Windows.Forms.TextBox txbConceito;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitulo;
    }
}

