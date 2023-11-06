namespace MahaloForms
{
    partial class FolhadePonto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolhadePonto));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DadosPessoaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolhadePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FériasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewPonto = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpesquisarfuncionario = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPonto)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Folha de Ponto";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1272, 40);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "stripmenu";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DadosPessoaisToolStripMenuItem,
            this.consultarFuncionáriosToolStripMenuItem,
            this.FolhadePagamentoToolStripMenuItem,
            this.FériasToolStripMenuItem,
            this.SairToolStripMenuItem});
            this.mENUToolStripMenuItem.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mENUToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.mENUToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mENUToolStripMenuItem.Image")));
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(126, 36);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // DadosPessoaisToolStripMenuItem
            // 
            this.DadosPessoaisToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DadosPessoaisToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DadosPessoaisToolStripMenuItem.Image")));
            this.DadosPessoaisToolStripMenuItem.Name = "DadosPessoaisToolStripMenuItem";
            this.DadosPessoaisToolStripMenuItem.Size = new System.Drawing.Size(389, 36);
            this.DadosPessoaisToolStripMenuItem.Text = "Cadastro de Funcionário";
            this.DadosPessoaisToolStripMenuItem.Click += new System.EventHandler(this.DadosPessoaisToolStripMenuItem_Click);
            // 
            // consultarFuncionáriosToolStripMenuItem
            // 
            this.consultarFuncionáriosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.consultarFuncionáriosToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.consultarFuncionáriosToolStripMenuItem.Image = global::MahaloForms.Properties.Resources.network;
            this.consultarFuncionáriosToolStripMenuItem.Name = "consultarFuncionáriosToolStripMenuItem";
            this.consultarFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(389, 36);
            this.consultarFuncionáriosToolStripMenuItem.Text = "Consultar Funcionários";
            this.consultarFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.consultarFuncionáriosToolStripMenuItem_Click);
            // 
            // FolhadePagamentoToolStripMenuItem
            // 
            this.FolhadePagamentoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FolhadePagamentoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FolhadePagamentoToolStripMenuItem.Image")));
            this.FolhadePagamentoToolStripMenuItem.Name = "FolhadePagamentoToolStripMenuItem";
            this.FolhadePagamentoToolStripMenuItem.Size = new System.Drawing.Size(389, 36);
            this.FolhadePagamentoToolStripMenuItem.Text = "Folha de Pagamento";
            this.FolhadePagamentoToolStripMenuItem.Click += new System.EventHandler(this.FolhadePagamentoToolStripMenuItem_Click);
            // 
            // FériasToolStripMenuItem
            // 
            this.FériasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FériasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FériasToolStripMenuItem.Image")));
            this.FériasToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Coral;
            this.FériasToolStripMenuItem.Name = "FériasToolStripMenuItem";
            this.FériasToolStripMenuItem.Size = new System.Drawing.Size(389, 36);
            this.FériasToolStripMenuItem.Text = "Férias";
            this.FériasToolStripMenuItem.Click += new System.EventHandler(this.FériasToolStripMenuItem_Click);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SairToolStripMenuItem.Image")));
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(389, 36);
            this.SairToolStripMenuItem.Text = "Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Buscar Funcionario por ID:";
            // 
            // dataGridViewPonto
            // 
            this.dataGridViewPonto.AllowUserToAddRows = false;
            this.dataGridViewPonto.AllowUserToDeleteRows = false;
            this.dataGridViewPonto.AllowUserToOrderColumns = true;
            this.dataGridViewPonto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewPonto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridViewPonto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPonto.Location = new System.Drawing.Point(2, 47);
            this.dataGridViewPonto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewPonto.Name = "dataGridViewPonto";
            this.dataGridViewPonto.ReadOnly = true;
            this.dataGridViewPonto.RowHeadersWidth = 51;
            this.dataGridViewPonto.RowTemplate.Height = 24;
            this.dataGridViewPonto.Size = new System.Drawing.Size(1039, 297);
            this.dataGridViewPonto.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(361, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpesquisarfuncionario
            // 
            this.txtpesquisarfuncionario.Location = new System.Drawing.Point(2, 2);
            this.txtpesquisarfuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpesquisarfuncionario.Name = "txtpesquisarfuncionario";
            this.txtpesquisarfuncionario.Size = new System.Drawing.Size(355, 22);
            this.txtpesquisarfuncionario.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtpesquisarfuncionario);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.dataGridViewPonto);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(161, 222);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1053, 486);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-14, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1807, 93);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FolhadePonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1272, 596);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FolhadePonto";
            this.Text = "Folha de Ponto";
            this.Load += new System.EventHandler(this.FolhadePonto_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPonto)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DadosPessoaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FolhadePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FériasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewPonto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpesquisarfuncionario;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem consultarFuncionáriosToolStripMenuItem;
    }
}