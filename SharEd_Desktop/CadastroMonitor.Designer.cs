namespace SharEd_Desktop
{
    partial class CadastroMonitor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxSerie = new System.Windows.Forms.ComboBox();
            this.cbxDisciplina = new System.Windows.Forms.ComboBox();
            this.txtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtRa = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRa = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.cbxSerie);
            this.panel1.Controls.Add(this.cbxDisciplina);
            this.panel1.Controls.Add(this.txtNascimento);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtTelefone);
            this.panel1.Controls.Add(this.txtRg);
            this.panel1.Controls.Add(this.txtRa);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.lblSerie);
            this.panel1.Controls.Add(this.lblNascimento);
            this.panel1.Controls.Add(this.lblDisciplina);
            this.panel1.Controls.Add(this.lblTelefone);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblRa);
            this.panel1.Controls.Add(this.lblRg);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Location = new System.Drawing.Point(139, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 348);
            this.panel1.TabIndex = 0;
            // 
            // cbxSerie
            // 
            this.cbxSerie.Enabled = false;
            this.cbxSerie.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSerie.FormattingEnabled = true;
            this.cbxSerie.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.cbxSerie.Location = new System.Drawing.Point(446, 225);
            this.cbxSerie.Name = "cbxSerie";
            this.cbxSerie.Size = new System.Drawing.Size(162, 25);
            this.cbxSerie.TabIndex = 16;
            // 
            // cbxDisciplina
            // 
            this.cbxDisciplina.Enabled = false;
            this.cbxDisciplina.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDisciplina.FormattingEnabled = true;
            this.cbxDisciplina.Items.AddRange(new object[] {
            "Técnico",
            "Humanas",
            "Linguagens",
            "Exatas",
            "C. da Natureza"});
            this.cbxDisciplina.Location = new System.Drawing.Point(137, 225);
            this.cbxDisciplina.Name = "cbxDisciplina";
            this.cbxDisciplina.Size = new System.Drawing.Size(223, 25);
            this.cbxDisciplina.TabIndex = 15;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Enabled = false;
            this.txtNascimento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNascimento.Location = new System.Drawing.Point(487, 171);
            this.txtNascimento.Mask = "00/00/0000";
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(121, 25);
            this.txtNascimento.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(137, 171);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 25);
            this.txtEmail.TabIndex = 13;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(429, 112);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(179, 25);
            this.txtTelefone.TabIndex = 12;
            // 
            // txtRg
            // 
            this.txtRg.Enabled = false;
            this.txtRg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(137, 112);
            this.txtRg.Mask = "00,000,000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(183, 25);
            this.txtRg.TabIndex = 11;
            // 
            // txtRa
            // 
            this.txtRa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRa.Location = new System.Drawing.Point(137, 66);
            this.txtRa.Name = "txtRa";
            this.txtRa.Size = new System.Drawing.Size(121, 25);
            this.txtRa.TabIndex = 10;
            this.txtRa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRa_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(327, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(281, 25);
            this.txtNome.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCadastrar.Location = new System.Drawing.Point(248, 280);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(175, 39);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(377, 228);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(46, 17);
            this.lblSerie.TabIndex = 7;
            this.lblSerie.Text = "Série:";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(385, 174);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(90, 17);
            this.lblNascimento.TabIndex = 6;
            this.lblNascimento.Text = "Nascimento:";
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisciplina.Location = new System.Drawing.Point(82, 228);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(42, 17);
            this.lblDisciplina.TabIndex = 5;
            this.lblDisciplina.Text = "Área:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(346, 117);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(66, 17);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(70, 174);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 17);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblRa
            // 
            this.lblRa.AutoSize = true;
            this.lblRa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRa.Location = new System.Drawing.Point(92, 69);
            this.lblRa.Name = "lblRa";
            this.lblRa.Size = new System.Drawing.Size(32, 17);
            this.lblRa.TabIndex = 2;
            this.lblRa.Text = "RA:";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(90, 117);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(34, 17);
            this.lblRg.TabIndex = 1;
            this.lblRg.Text = "RG:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(269, 69);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // CadastroMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = global::SharEd_Desktop.Properties.Resources.Desktop__1_;
            this.ClientSize = new System.Drawing.Size(957, 486);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastroMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Monitor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRa;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.ComboBox cbxSerie;
        private System.Windows.Forms.ComboBox cbxDisciplina;
        private System.Windows.Forms.MaskedTextBox txtNascimento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.TextBox txtRa;
        private System.Windows.Forms.TextBox txtNome;
    }
}