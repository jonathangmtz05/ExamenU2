namespace ExamenU2
{
    partial class CambiosAgenda
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
            txtNombre = new TextBox();
            txtId = new TextBox();
            txtAPaterno = new TextBox();
            txtCorreo = new TextBox();
            txtAMaterno = new TextBox();
            labid = new Label();
            labnombre = new Label();
            labAM = new Label();
            labAP = new Label();
            labtelefono = new Label();
            labCorreo = new Label();
            butactualizar = new Button();
            butcancelar = new Button();
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtNombre.Location = new Point(84, 208);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtId.Location = new Point(72, 11);
            txtId.Name = "txtId";
            txtId.Size = new Size(123, 27);
            txtId.TabIndex = 2;
            // 
            // txtAPaterno
            // 
            txtAPaterno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtAPaterno.Location = new Point(142, 71);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(168, 27);
            txtAPaterno.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCorreo.Location = new Point(156, 308);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(254, 27);
            txtCorreo.TabIndex = 4;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtAMaterno.Location = new Point(156, 136);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(195, 27);
            txtAMaterno.TabIndex = 5;
            // 
            // labid
            // 
            labid.AutoSize = true;
            labid.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labid.Location = new Point(16, 11);
            labid.Name = "labid";
            labid.Size = new Size(23, 20);
            labid.TabIndex = 6;
            labid.Text = "Id";
            // 
            // labnombre
            // 
            labnombre.AutoSize = true;
            labnombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labnombre.Location = new Point(14, 208);
            labnombre.Name = "labnombre";
            labnombre.Size = new Size(67, 20);
            labnombre.TabIndex = 7;
            labnombre.Text = "Nombre";
            // 
            // labAM
            // 
            labAM.AutoSize = true;
            labAM.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labAM.Location = new Point(14, 143);
            labAM.Name = "labAM";
            labAM.Size = new Size(131, 20);
            labAM.TabIndex = 8;
            labAM.Text = "Apellido Materno";
            // 
            // labAP
            // 
            labAP.AutoSize = true;
            labAP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labAP.Location = new Point(16, 74);
            labAP.Name = "labAP";
            labAP.Size = new Size(126, 20);
            labAP.TabIndex = 9;
            labAP.Text = "Apellido Paterno";
            // 
            // labtelefono
            // 
            labtelefono.AutoSize = true;
            labtelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labtelefono.Location = new Point(14, 262);
            labtelefono.Name = "labtelefono";
            labtelefono.Size = new Size(70, 20);
            labtelefono.TabIndex = 10;
            labtelefono.Text = "Telefono";
            // 
            // labCorreo
            // 
            labCorreo.AutoSize = true;
            labCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labCorreo.Location = new Point(14, 308);
            labCorreo.Name = "labCorreo";
            labCorreo.Size = new Size(137, 20);
            labCorreo.TabIndex = 11;
            labCorreo.Text = "Correo Electronico";
            // 
            // butactualizar
            // 
            butactualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butactualizar.Location = new Point(52, 366);
            butactualizar.Name = "butactualizar";
            butactualizar.Size = new Size(94, 29);
            butactualizar.TabIndex = 12;
            butactualizar.Text = "Actualizar";
            butactualizar.UseVisualStyleBackColor = true;
            butactualizar.Click += butactualizar_Click;
            // 
            // butcancelar
            // 
            butcancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butcancelar.Location = new Point(177, 366);
            butcancelar.Name = "butcancelar";
            butcancelar.Size = new Size(94, 29);
            butcancelar.TabIndex = 13;
            butcancelar.Text = "Cancelar";
            butcancelar.UseVisualStyleBackColor = true;
            butcancelar.Click += butcancelar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(325, 369);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(102, 255);
            maskedTextBox1.Mask = "000-000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(127, 27);
            maskedTextBox1.TabIndex = 15;
            // 
            // CambiosAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources._18_11;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(506, 410);
            Controls.Add(maskedTextBox1);
            Controls.Add(button1);
            Controls.Add(butcancelar);
            Controls.Add(butactualizar);
            Controls.Add(labCorreo);
            Controls.Add(labtelefono);
            Controls.Add(labAP);
            Controls.Add(labAM);
            Controls.Add(labnombre);
            Controls.Add(labid);
            Controls.Add(txtAMaterno);
            Controls.Add(txtCorreo);
            Controls.Add(txtAPaterno);
            Controls.Add(txtId);
            Controls.Add(txtNombre);
            ForeColor = SystemColors.ControlText;
            Name = "CambiosAgenda";
            Text = "CambiosAgenda";
            Load += CambiosAgenda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtId;
        private TextBox txtAPaterno;
        private TextBox txtCorreo;
        private TextBox txtAMaterno;
        private Label labid;
        private Label labnombre;
        private Label labAM;
        private Label labAP;
        private Label labtelefono;
        private Label labCorreo;
        private Button butactualizar;
        private Button butcancelar;
        private Button button1;
        private MaskedTextBox maskedTextBox1;
    }
}