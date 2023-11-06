using System;

namespace MahaloForms
{
    partial class Férias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Férias));
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DadosPessoaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolhadePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.feriasfuncionario = new System.Windows.Forms.Button();
            this.dataGridViewFerias = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFerias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1101, 34);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 45);
            this.label12.TabIndex = 36;
            this.label12.Text = "Férias";
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1805, 70);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "stripmenu";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DadosPessoaisToolStripMenuItem,
            this.consultarFuncionáriosToolStripMenuItem,
            this.FolhadePagamentoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.SairToolStripMenuItem});
            this.mENUToolStripMenuItem.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mENUToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.mENUToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mENUToolStripMenuItem.Image")));
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(148, 42);
            this.mENUToolStripMenuItem.Text = "MENU";
            this.mENUToolStripMenuItem.Click += new System.EventHandler(this.mENUToolStripMenuItem_Click);
            // 
            // DadosPessoaisToolStripMenuItem
            // 
            this.DadosPessoaisToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DadosPessoaisToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DadosPessoaisToolStripMenuItem.Image")));
            this.DadosPessoaisToolStripMenuItem.Name = "DadosPessoaisToolStripMenuItem";
            this.DadosPessoaisToolStripMenuItem.Size = new System.Drawing.Size(458, 42);
            this.DadosPessoaisToolStripMenuItem.Text = "Cadastro de Funcionário";
            this.DadosPessoaisToolStripMenuItem.Click += new System.EventHandler(this.DadosPessoaisToolStripMenuItem_Click);
            // 
            // consultarFuncionáriosToolStripMenuItem
            // 
            this.consultarFuncionáriosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.consultarFuncionáriosToolStripMenuItem.Image = global::MahaloForms.Properties.Resources.network;
            this.consultarFuncionáriosToolStripMenuItem.Name = "consultarFuncionáriosToolStripMenuItem";
            this.consultarFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(458, 42);
            this.consultarFuncionáriosToolStripMenuItem.Text = "Consultar Funcionários";
            this.consultarFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.consultarFuncionáriosToolStripMenuItem_Click);
            // 
            // FolhadePagamentoToolStripMenuItem
            // 
            this.FolhadePagamentoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FolhadePagamentoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FolhadePagamentoToolStripMenuItem.Image")));
            this.FolhadePagamentoToolStripMenuItem.Name = "FolhadePagamentoToolStripMenuItem";
            this.FolhadePagamentoToolStripMenuItem.Size = new System.Drawing.Size(458, 42);
            this.FolhadePagamentoToolStripMenuItem.Text = "Folha de Pagamento";
            this.FolhadePagamentoToolStripMenuItem.Click += new System.EventHandler(this.FolhadePagamentoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(458, 42);
            this.toolStripMenuItem1.Text = "Folha de Ponto";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SairToolStripMenuItem.Image")));
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(458, 42);
            this.SairToolStripMenuItem.Text = "Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtpesquisar);
            this.flowLayoutPanel1.Controls.Add(this.feriasfuncionario);
            this.flowLayoutPanel1.Controls.Add(this.dataGridViewFerias);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(299, 336);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1267, 598);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Location = new System.Drawing.Point(3, 2);
            this.txtpesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(472, 26);
            this.txtpesquisar.TabIndex = 9;
            // 
            // feriasfuncionario
            // 
            this.feriasfuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.feriasfuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feriasfuncionario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feriasfuncionario.Location = new System.Drawing.Point(481, 2);
            this.feriasfuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.feriasfuncionario.Name = "feriasfuncionario";
            this.feriasfuncionario.Size = new System.Drawing.Size(127, 50);
            this.feriasfuncionario.TabIndex = 10;
            this.feriasfuncionario.Text = "Pesquisar";
            this.feriasfuncionario.UseVisualStyleBackColor = false;
            this.feriasfuncionario.Click += new System.EventHandler(this.feriasfuncionario_Click);
            // 
            // dataGridViewFerias
            // 
            this.dataGridViewFerias.AllowUserToAddRows = false;
            this.dataGridViewFerias.AllowUserToDeleteRows = false;
            this.dataGridViewFerias.AllowUserToOrderColumns = true;
            this.dataGridViewFerias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewFerias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridViewFerias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFerias.Location = new System.Drawing.Point(3, 56);
            this.dataGridViewFerias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewFerias.Name = "dataGridViewFerias";
            this.dataGridViewFerias.ReadOnly = true;
            this.dataGridViewFerias.RowHeadersWidth = 51;
            this.dataGridViewFerias.RowTemplate.Height = 24;
            this.dataGridViewFerias.Size = new System.Drawing.Size(1196, 366);
            this.dataGridViewFerias.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 314);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Buscar Funcionario por ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, -10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2409, 114);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // Férias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1805, 902);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Férias";
            this.Text = "Férias";
            this.Load += new System.EventHandler(this.Férias_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFerias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DadosPessoaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FolhadePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtpesquisar;
        private System.Windows.Forms.Button feriasfuncionario;
        private System.Windows.Forms.DataGridView dataGridViewFerias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem consultarFuncionáriosToolStripMenuItem;
    }
}