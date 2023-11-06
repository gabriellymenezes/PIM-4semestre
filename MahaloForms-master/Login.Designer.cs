namespace MahaloForms
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.layoutesqueceu = new System.Windows.Forms.TableLayoutPanel();
            this.layoutloginome = new System.Windows.Forms.TableLayoutPanel();
            this.lblloginome = new System.Windows.Forms.Label();
            this.layoutentrar = new System.Windows.Forms.TableLayoutPanel();
            this.btnentrar = new System.Windows.Forms.Button();
            this.layoutlogin = new System.Windows.Forms.TableLayoutPanel();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.layoutlogo = new System.Windows.Forms.TableLayoutPanel();
            this.layoutloginome.SuspendLayout();
            this.layoutentrar.SuspendLayout();
            this.layoutlogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutesqueceu
            // 
            this.layoutesqueceu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layoutesqueceu.ColumnCount = 1;
            this.layoutesqueceu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.layoutesqueceu.Location = new System.Drawing.Point(593, 711);
            this.layoutesqueceu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutesqueceu.Name = "layoutesqueceu";
            this.layoutesqueceu.RowCount = 1;
            this.layoutesqueceu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutesqueceu.Size = new System.Drawing.Size(153, 23);
            this.layoutesqueceu.TabIndex = 12;
            // 
            // layoutloginome
            // 
            this.layoutloginome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layoutloginome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.layoutloginome.ColumnCount = 3;
            this.layoutloginome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutloginome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.layoutloginome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.layoutloginome.Controls.Add(this.lblloginome, 1, 1);
            this.layoutloginome.Location = new System.Drawing.Point(393, 427);
            this.layoutloginome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutloginome.Name = "layoutloginome";
            this.layoutloginome.RowCount = 2;
            this.layoutloginome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutloginome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layoutloginome.Size = new System.Drawing.Size(525, 48);
            this.layoutloginome.TabIndex = 11;
            // 
            // lblloginome
            // 
            this.lblloginome.AutoSize = true;
            this.lblloginome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloginome.ForeColor = System.Drawing.Color.White;
            this.lblloginome.Location = new System.Drawing.Point(238, 23);
            this.lblloginome.Name = "lblloginome";
            this.lblloginome.Size = new System.Drawing.Size(73, 24);
            this.lblloginome.TabIndex = 0;
            this.lblloginome.Text = "LOGIN";
            // 
            // layoutentrar
            // 
            this.layoutentrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layoutentrar.ColumnCount = 1;
            this.layoutentrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutentrar.Controls.Add(this.btnentrar, 0, 0);
            this.layoutentrar.Location = new System.Drawing.Point(548, 644);
            this.layoutentrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutentrar.Name = "layoutentrar";
            this.layoutentrar.RowCount = 1;
            this.layoutentrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutentrar.Size = new System.Drawing.Size(225, 62);
            this.layoutentrar.TabIndex = 9;
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnentrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnentrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnentrar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrar.ForeColor = System.Drawing.Color.White;
            this.btnentrar.Location = new System.Drawing.Point(3, 2);
            this.btnentrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(219, 53);
            this.btnentrar.TabIndex = 0;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // layoutlogin
            // 
            this.layoutlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layoutlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.layoutlogin.ColumnCount = 2;
            this.layoutlogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutlogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 427F));
            this.layoutlogin.Controls.Add(this.lbllogin, 0, 1);
            this.layoutlogin.Controls.Add(this.lblsenha, 0, 2);
            this.layoutlogin.Controls.Add(this.txtSenha, 1, 2);
            this.layoutlogin.Controls.Add(this.txtUsuario, 1, 1);
            this.layoutlogin.Location = new System.Drawing.Point(393, 473);
            this.layoutlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutlogin.Name = "layoutlogin";
            this.layoutlogin.RowCount = 4;
            this.layoutlogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutlogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.layoutlogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.layoutlogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutlogin.Size = new System.Drawing.Size(525, 119);
            this.layoutlogin.TabIndex = 8;
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.Color.White;
            this.lbllogin.Location = new System.Drawing.Point(3, 15);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(76, 19);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "Usuário:";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.ForeColor = System.Drawing.Color.White;
            this.lblsenha.Location = new System.Drawing.Point(3, 63);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(64, 19);
            this.lblsenha.TabIndex = 1;
            this.lblsenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(101, 65);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(365, 22);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(101, 17);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(365, 22);
            this.txtUsuario.TabIndex = 2;
            // 
            // layoutlogo
            // 
            this.layoutlogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layoutlogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("layoutlogo.BackgroundImage")));
            this.layoutlogo.ColumnCount = 1;
            this.layoutlogo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutlogo.Location = new System.Drawing.Point(557, 130);
            this.layoutlogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutlogo.Name = "layoutlogo";
            this.layoutlogo.RowCount = 1;
            this.layoutlogo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutlogo.Size = new System.Drawing.Size(259, 257);
            this.layoutlogo.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1363, 741);
            this.Controls.Add(this.layoutesqueceu);
            this.Controls.Add(this.layoutloginome);
            this.Controls.Add(this.layoutlogo);
            this.Controls.Add(this.layoutentrar);
            this.Controls.Add(this.layoutlogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Mahalo Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.layoutloginome.ResumeLayout(false);
            this.layoutloginome.PerformLayout();
            this.layoutentrar.ResumeLayout(false);
            this.layoutlogin.ResumeLayout(false);
            this.layoutlogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutesqueceu;
        private System.Windows.Forms.TableLayoutPanel layoutloginome;
        private System.Windows.Forms.Label lblloginome;
        private System.Windows.Forms.TableLayoutPanel layoutlogo;
        private System.Windows.Forms.TableLayoutPanel layoutentrar;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.TableLayoutPanel layoutlogin;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}

