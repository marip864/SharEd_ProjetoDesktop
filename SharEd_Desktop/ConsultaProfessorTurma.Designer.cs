namespace SharEd_Desktop
{
    partial class ConsultaProfessorTurma
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
            this.cbxTurma = new System.Windows.Forms.ComboBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.turma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disiciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lblTurma);
            this.panel1.Controls.Add(this.cbxTurma);
            this.panel1.Location = new System.Drawing.Point(106, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 314);
            this.panel1.TabIndex = 0;
            // 
            // cbxTurma
            // 
            this.cbxTurma.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTurma.FormattingEnabled = true;
            this.cbxTurma.Location = new System.Drawing.Point(167, 40);
            this.cbxTurma.Name = "cbxTurma";
            this.cbxTurma.Size = new System.Drawing.Size(489, 25);
            this.cbxTurma.TabIndex = 0;
            this.cbxTurma.SelectedIndexChanged += new System.EventHandler(this.cbxTurma_SelectedIndexChanged);
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurma.Location = new System.Drawing.Point(90, 48);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(54, 17);
            this.lblTurma.TabIndex = 1;
            this.lblTurma.Text = "Turma:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turma,
            this.disiciplina});
            this.dataGridView1.Location = new System.Drawing.Point(93, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(563, 177);
            this.dataGridView1.TabIndex = 2;
            // 
            // turma
            // 
            this.turma.HeaderText = "Professor";
            this.turma.MinimumWidth = 6;
            this.turma.Name = "turma";
            this.turma.ReadOnly = true;
            this.turma.Width = 150;
            // 
            // disiciplina
            // 
            this.disiciplina.HeaderText = "Disciplina";
            this.disiciplina.MinimumWidth = 6;
            this.disiciplina.Name = "disiciplina";
            this.disiciplina.ReadOnly = true;
            this.disiciplina.Width = 150;
            // 
            // ConsultaProfessorTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SharEd_Desktop.Properties.Resources.Desktop__1_;
            this.ClientSize = new System.Drawing.Size(957, 486);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConsultaProfessorTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Professor em Turma";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.ComboBox cbxTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn turma;
        private System.Windows.Forms.DataGridViewTextBoxColumn disiciplina;
    }
}