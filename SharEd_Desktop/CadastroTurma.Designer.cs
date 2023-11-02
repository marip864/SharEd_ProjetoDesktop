namespace SharEd_Desktop
{
    partial class CadastroTurma
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
            this.cbxPeriodo = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.cbxSerie = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.cbxPeriodo);
            this.panel1.Controls.Add(this.lblPeriodo);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.cbxCurso);
            this.panel1.Controls.Add(this.cbxSerie);
            this.panel1.Controls.Add(this.lblCurso);
            this.panel1.Controls.Add(this.lblSerie);
            this.panel1.Location = new System.Drawing.Point(127, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 326);
            this.panel1.TabIndex = 0;
            // 
            // cbxPeriodo
            // 
            this.cbxPeriodo.Enabled = false;
            this.cbxPeriodo.FormattingEnabled = true;
            this.cbxPeriodo.Items.AddRange(new object[] {
            "Integral",
            "Diurno",
            "Vespertino",
            "Noturno"});
            this.cbxPeriodo.Location = new System.Drawing.Point(193, 181);
            this.cbxPeriodo.Name = "cbxPeriodo";
            this.cbxPeriodo.Size = new System.Drawing.Size(379, 24);
            this.cbxPeriodo.TabIndex = 6;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(105, 183);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(62, 17);
            this.lblPeriodo.TabIndex = 5;
            this.lblPeriodo.Text = "Período:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Location = new System.Drawing.Point(247, 241);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(182, 39);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cbxCurso
            // 
            this.cbxCurso.Enabled = false;
            this.cbxCurso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Items.AddRange(new object[] {
            "Agrimensura",
            "Desenvolvimento de Sistemas",
            "Edificações",
            "Enfermagem",
            "Mecânica",
            "Qualidade"});
            this.cbxCurso.Location = new System.Drawing.Point(193, 124);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(379, 25);
            this.cbxCurso.TabIndex = 3;
            this.cbxCurso.SelectedIndexChanged += new System.EventHandler(this.cbxCurso_SelectedIndexChanged);
            // 
            // cbxSerie
            // 
            this.cbxSerie.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSerie.FormattingEnabled = true;
            this.cbxSerie.Items.AddRange(new object[] {
            "1° ano",
            "2° ano",
            "3° ano",
            "4° ano"});
            this.cbxSerie.Location = new System.Drawing.Point(193, 65);
            this.cbxSerie.Name = "cbxSerie";
            this.cbxSerie.Size = new System.Drawing.Size(379, 25);
            this.cbxSerie.TabIndex = 2;
            this.cbxSerie.SelectedIndexChanged += new System.EventHandler(this.cbxSerie_SelectedIndexChanged);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(115, 127);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(52, 17);
            this.lblCurso.TabIndex = 1;
            this.lblCurso.Text = "Curso:";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(121, 68);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(46, 17);
            this.lblSerie.TabIndex = 0;
            this.lblSerie.Text = "Série:";
            // 
            // CadastroTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = global::SharEd_Desktop.Properties.Resources.Desktop__1_;
            this.ClientSize = new System.Drawing.Size(957, 486);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastroTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Turma";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.ComboBox cbxSerie;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.ComboBox cbxPeriodo;
        private System.Windows.Forms.Label lblPeriodo;
    }
}