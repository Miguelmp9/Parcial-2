namespace Parcial_2
{
    partial class Gestion_de_Equipos
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtgEquipos = new DataGridView();
            cmbEstado = new ComboBox();
            mtxFecha = new MaskedTextBox();
            txtNombre = new TextBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtCategoria = new TextBox();
            mtxCodigo = new MaskedTextBox();
            label7 = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgEquipos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 37);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(255, 37);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 1;
            label2.Text = "Modelo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 80);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 2;
            label3.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(243, 80);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 3;
            label4.Text = "Categoria:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(484, 37);
            label5.Name = "label5";
            label5.Size = new Size(117, 17);
            label5.TabIndex = 4;
            label5.Text = "Fecha de Compra:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(549, 79);
            label6.Name = "label6";
            label6.Size = new Size(52, 17);
            label6.TabIndex = 5;
            label6.Text = "Estado:";
            // 
            // dtgEquipos
            // 
            dtgEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEquipos.Location = new Point(43, 142);
            dtgEquipos.Name = "dtgEquipos";
            dtgEquipos.Size = new Size(620, 186);
            dtgEquipos.TabIndex = 6;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(607, 80);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 7;
            // 
            // mtxFecha
            // 
            mtxFecha.Location = new Point(607, 39);
            mtxFecha.Name = "mtxFecha";
            mtxFecha.Size = new Size(121, 23);
            mtxFecha.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(97, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(140, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(97, 78);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(140, 23);
            txtMarca.TabIndex = 10;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(318, 39);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(145, 23);
            txtModelo.TabIndex = 11;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(318, 79);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(145, 23);
            txtCategoria.TabIndex = 12;
            // 
            // mtxCodigo
            // 
            mtxCodigo.Location = new Point(160, 114);
            mtxCodigo.Name = "mtxCodigo";
            mtxCodigo.Size = new Size(140, 23);
            mtxCodigo.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(32, 114);
            label7.Name = "label7";
            label7.Size = new Size(122, 17);
            label7.TabIndex = 14;
            label7.Text = "Codigo del equipo:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(43, 351);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(124, 351);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // Gestion_de_Equipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(label7);
            Controls.Add(mtxCodigo);
            Controls.Add(txtCategoria);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(txtNombre);
            Controls.Add(mtxFecha);
            Controls.Add(cmbEstado);
            Controls.Add(dtgEquipos);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Gestion_de_Equipos";
            Text = "Gestion_de_Equipos";
            ((System.ComponentModel.ISupportInitialize)dtgEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dtgEquipos;
        private ComboBox cmbEstado;
        private MaskedTextBox mtxFecha;
        private TextBox txtNombre;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtCategoria;
        private MaskedTextBox mtxCodigo;
        private Label label7;
        private Button btnEliminar;
        private Button btnEditar;
    }
}