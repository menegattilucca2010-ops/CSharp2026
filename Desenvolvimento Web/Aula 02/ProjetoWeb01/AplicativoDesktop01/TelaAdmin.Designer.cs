namespace AplicativoDesktop01
{
    partial class TelaAdmin
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
            Button1 = new Button();
            dgvAlunos = new DataGridView();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button1.Location = new Point(425, 12);
            Button1.Name = "Button1";
            Button1.Size = new Size(155, 40);
            Button1.TabIndex = 0;
            Button1.Text = "Aprovar";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // dgvAlunos
            // 
            dgvAlunos.Location = new Point(4, 78);
            dgvAlunos.Name = "dgvAlunos";
            dgvAlunos.Size = new Size(968, 360);
            dgvAlunos.TabIndex = 1;
            dgvAlunos.AllowUserToAddRows = false;
            dgvAlunos.AllowUserToDeleteRows = false;
            dgvAlunos.ReadOnly = true;
            dgvAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // TelaAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(984, 461);
            Controls.Add(dgvAlunos);
            Controls.Add(Button1);
            Name = "TelaAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Cadastro de Usuarios";
            ResumeLayout(false);
        }

        #endregion

        private Button Button1;
        private DataGridView dgvAlunos;
    }
}