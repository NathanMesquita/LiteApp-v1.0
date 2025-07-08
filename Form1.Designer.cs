namespace LiteApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblNome = new Label();
            lblTelefone = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            btnAdicionar = new Button();
            btnLimpar = new Button();
            lstContatos = new ListBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = SystemColors.WindowText;
            lblNome.Location = new Point(30, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.ForeColor = SystemColors.WindowText;
            lblTelefone.Location = new Point(30, 70);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 1;
            lblTelefone.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(96, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(201, 23);
            txtNome.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(96, 67);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(201, 23);
            txtTelefone.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            btnAdicionar.ForeColor = SystemColors.WindowText;
            btnAdicionar.Location = new Point(63, 109);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(92, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.ForeColor = SystemColors.WindowText;
            btnLimpar.Location = new Point(176, 109);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(92, 23);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lstContatos
            // 
            lstContatos.FormattingEnabled = true;
            lstContatos.ItemHeight = 15;
            lstContatos.Location = new Point(30, 147);
            lstContatos.Name = "lstContatos";
            lstContatos.Size = new Size(267, 124);
            lstContatos.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 291);
            Controls.Add(lstContatos);
            Controls.Add(btnLimpar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LiteApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblTelefone;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private Button btnAdicionar;
        private Button btnLimpar;
        private ListBox lstContatos;
    }
}
