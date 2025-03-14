namespace ExamenU2
{
    partial class AltasAgenda
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
            butcancelar = new Button();
            butinsertar = new Button();
            labCorreo = new Label();
            labtelefono = new Label();
            labAP = new Label();
            labAM = new Label();
            labnombre = new Label();
            txtAMaterno = new TextBox();
            txtCorreo = new TextBox();
            txtAPaterno = new TextBox();
            txtNombre = new TextBox();
            mtbTel = new MaskedTextBox();
            SuspendLayout();
            // 
            // butcancelar
            // 
            butcancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butcancelar.Location = new Point(168, 307);
            butcancelar.Name = "butcancelar";
            butcancelar.Size = new Size(94, 29);
            butcancelar.TabIndex = 27;
            butcancelar.Text = "Cancelar";
            butcancelar.UseVisualStyleBackColor = true;
            butcancelar.Click += butcancelar_Click;
            // 
            // butinsertar
            // 
            butinsertar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butinsertar.Location = new Point(43, 307);
            butinsertar.Name = "butinsertar";
            butinsertar.Size = new Size(94, 29);
            butinsertar.TabIndex = 26;
            butinsertar.Text = "Insertar";
            butinsertar.UseVisualStyleBackColor = true;
            butinsertar.Click += butinsertar_Click;
            // 
            // labCorreo
            // 
            labCorreo.AutoSize = true;
            labCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labCorreo.Location = new Point(5, 249);
            labCorreo.Name = "labCorreo";
            labCorreo.Size = new Size(137, 20);
            labCorreo.TabIndex = 25;
            labCorreo.Text = "Correo Electronico";
            // 
            // labtelefono
            // 
            labtelefono.AutoSize = true;
            labtelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labtelefono.Location = new Point(5, 203);
            labtelefono.Name = "labtelefono";
            labtelefono.Size = new Size(70, 20);
            labtelefono.TabIndex = 24;
            labtelefono.Text = "Telefono";
            // 
            // labAP
            // 
            labAP.AutoSize = true;
            labAP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labAP.Location = new Point(7, 15);
            labAP.Name = "labAP";
            labAP.Size = new Size(126, 20);
            labAP.TabIndex = 23;
            labAP.Text = "Apellido Paterno";
            // 
            // labAM
            // 
            labAM.AutoSize = true;
            labAM.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labAM.Location = new Point(5, 84);
            labAM.Name = "labAM";
            labAM.Size = new Size(131, 20);
            labAM.TabIndex = 22;
            labAM.Text = "Apellido Materno";
            // 
            // labnombre
            // 
            labnombre.AutoSize = true;
            labnombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labnombre.Location = new Point(5, 149);
            labnombre.Name = "labnombre";
            labnombre.Size = new Size(67, 20);
            labnombre.TabIndex = 21;
            labnombre.Text = "Nombre";
            // 
            // txtAMaterno
            // 
            txtAMaterno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtAMaterno.Location = new Point(147, 77);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(195, 27);
            txtAMaterno.TabIndex = 19;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCorreo.Location = new Point(147, 249);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(254, 27);
            txtCorreo.TabIndex = 18;
            // 
            // txtAPaterno
            // 
            txtAPaterno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtAPaterno.Location = new Point(133, 12);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(168, 27);
            txtAPaterno.TabIndex = 17;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtNombre.Location = new Point(75, 149);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 27);
            txtNombre.TabIndex = 14;
            // 
            // mtbTel
            // 
            mtbTel.Location = new Point(81, 196);
            mtbTel.Mask = "000-000-0000";
            mtbTel.Name = "mtbTel";
            mtbTel.Size = new Size(125, 27);
            mtbTel.TabIndex = 28;
            // 
            // AltasAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources._18_11;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(444, 358);
            Controls.Add(mtbTel);
            Controls.Add(butcancelar);
            Controls.Add(butinsertar);
            Controls.Add(labCorreo);
            Controls.Add(labtelefono);
            Controls.Add(labAP);
            Controls.Add(labAM);
            Controls.Add(labnombre);
            Controls.Add(txtAMaterno);
            Controls.Add(txtCorreo);
            Controls.Add(txtAPaterno);
            Controls.Add(txtNombre);
            Name = "AltasAgenda";
            Text = "AltasAgenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butcancelar;
        private Button butinsertar;
        private Label labCorreo;
        private Label labtelefono;
        private Label labAP;
        private Label labAM;
        private Label labnombre;
        private TextBox txtAMaterno;
        private TextBox txtCorreo;
        private TextBox txtAPaterno;
        private TextBox txtNombre;
        private MaskedTextBox mtbTel;
    }
}