namespace Parcial_2
{
    partial class Gestion_de_Tecnicos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            dataGridView1 = new DataGridView();
            btnEliminar = new Button();
            btnModificar = new Button();
            mtxTelefono = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 40);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(273, 38);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 1;
            label2.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(63, 83);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 2;
            label3.Text = "Correo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(121, 34);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(146, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(133, 77);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(398, 23);
            txtCorreo.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(617, 214);
            dataGridView1.TabIndex = 6;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(575, 83);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(575, 45);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // mtxTelefono
            // 
            mtxTelefono.Location = new Point(341, 37);
            mtxTelefono.Name = "mtxTelefono";
            mtxTelefono.Size = new Size(190, 23);
            mtxTelefono.TabIndex = 10;
            // 
            // Gestion_de_Tecnicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mtxTelefono);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(dataGridView1);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Gestion_de_Tecnicos";
            Text = "Gestion_de_Tecnicos";
            Load += Gestion_de_Tecnicos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private DataGridView dataGridView1;
        private Button btnEliminar;
        private Button btnModificar;
        private MaskedTextBox mtxTelefono;
    }
}