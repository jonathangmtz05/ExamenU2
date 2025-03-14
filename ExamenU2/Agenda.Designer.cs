namespace ExamenU2
{
    partial class Agenda
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
            dataGridView1 = new DataGridView();
            butinsertar = new Button();
            butSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(833, 384);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // butinsertar
            // 
            butinsertar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butinsertar.Location = new Point(12, 12);
            butinsertar.Name = "butinsertar";
            butinsertar.Size = new Size(114, 36);
            butinsertar.TabIndex = 1;
            butinsertar.Text = "Insertar";
            butinsertar.UseVisualStyleBackColor = true;
            butinsertar.Click += butinsertar_Click;
            // 
            // butSalir
            // 
            butSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butSalir.Location = new Point(150, 12);
            butSalir.Name = "butSalir";
            butSalir.Size = new Size(114, 36);
            butSalir.TabIndex = 2;
            butSalir.Text = "Salir";
            butSalir.UseVisualStyleBackColor = true;
            butSalir.Click += butSalir_Click;
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(849, 450);
            Controls.Add(butSalir);
            Controls.Add(butinsertar);
            Controls.Add(dataGridView1);
            Name = "Agenda";
            Text = "Agenda";
            Activated += Agenda_Activated;
            Load += Agenda_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button butinsertar;
        private Button butSalir;
    }
}