namespace Parcial_2
{
    partial class Menu
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            menuStrip1 = new MenuStrip();
            gestionDeEquiposToolStripMenuItem = new ToolStripMenuItem();
            gestionDeEquiposToolStripMenuItem1 = new ToolStripMenuItem();
            gestionDeTecnicosToolStripMenuItem = new ToolStripMenuItem();
            gestionDeTecnicosToolStripMenuItem1 = new ToolStripMenuItem();
            registroDeMantenimientoToolStripMenuItem = new ToolStripMenuItem();
            registroDeMantenimientoToolStripMenuItem1 = new ToolStripMenuItem();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            cascadaToolStripMenuItem = new ToolStripMenuItem();
            horizontalToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionDeEquiposToolStripMenuItem, gestionDeTecnicosToolStripMenuItem, registroDeMantenimientoToolStripMenuItem, opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionDeEquiposToolStripMenuItem
            // 
            gestionDeEquiposToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionDeEquiposToolStripMenuItem1 });
            gestionDeEquiposToolStripMenuItem.Name = "gestionDeEquiposToolStripMenuItem";
            gestionDeEquiposToolStripMenuItem.Size = new Size(71, 20);
            gestionDeEquiposToolStripMenuItem.Text = "Seccion-1";
            // 
            // gestionDeEquiposToolStripMenuItem1
            // 
            gestionDeEquiposToolStripMenuItem1.Image = Properties.Resources.equipo_de_documentos;
            gestionDeEquiposToolStripMenuItem1.Name = "gestionDeEquiposToolStripMenuItem1";
            gestionDeEquiposToolStripMenuItem1.Size = new Size(180, 22);
            gestionDeEquiposToolStripMenuItem1.Text = "-Gestion de Equipos";
            // 
            // gestionDeTecnicosToolStripMenuItem
            // 
            gestionDeTecnicosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionDeTecnicosToolStripMenuItem1 });
            gestionDeTecnicosToolStripMenuItem.Name = "gestionDeTecnicosToolStripMenuItem";
            gestionDeTecnicosToolStripMenuItem.Size = new Size(71, 20);
            gestionDeTecnicosToolStripMenuItem.Text = "Seccion-2";
            gestionDeTecnicosToolStripMenuItem.Click += gestionDeTecnicosToolStripMenuItem_Click;
            // 
            // gestionDeTecnicosToolStripMenuItem1
            // 
            gestionDeTecnicosToolStripMenuItem1.Image = Properties.Resources.plano;
            gestionDeTecnicosToolStripMenuItem1.Name = "gestionDeTecnicosToolStripMenuItem1";
            gestionDeTecnicosToolStripMenuItem1.Size = new Size(183, 22);
            gestionDeTecnicosToolStripMenuItem1.Text = "-Gestion de Tecnicos";
            gestionDeTecnicosToolStripMenuItem1.Click += gestionDeTecnicosToolStripMenuItem1_Click;
            // 
            // registroDeMantenimientoToolStripMenuItem
            // 
            registroDeMantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registroDeMantenimientoToolStripMenuItem1 });
            registroDeMantenimientoToolStripMenuItem.Name = "registroDeMantenimientoToolStripMenuItem";
            registroDeMantenimientoToolStripMenuItem.Size = new Size(71, 20);
            registroDeMantenimientoToolStripMenuItem.Text = "Seccion-3";
            // 
            // registroDeMantenimientoToolStripMenuItem1
            // 
            registroDeMantenimientoToolStripMenuItem1.Image = Properties.Resources.sosteniendo_el_engranaje_de_mano;
            registroDeMantenimientoToolStripMenuItem1.Name = "registroDeMantenimientoToolStripMenuItem1";
            registroDeMantenimientoToolStripMenuItem1.Size = new Size(223, 22);
            registroDeMantenimientoToolStripMenuItem1.Text = "-Registro de Mantenimiento";
            registroDeMantenimientoToolStripMenuItem1.Click += registroDeMantenimientoToolStripMenuItem1_Click;
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadaToolStripMenuItem, horizontalToolStripMenuItem, verticalToolStripMenuItem, salirToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(67, 20);
            opcionesToolStripMenuItem.Text = "opciones";
            // 
            // cascadaToolStripMenuItem
            // 
            cascadaToolStripMenuItem.Image = (Image)resources.GetObject("cascadaToolStripMenuItem.Image");
            cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            cascadaToolStripMenuItem.Size = new Size(134, 22);
            cascadaToolStripMenuItem.Text = "-Cascada";
            cascadaToolStripMenuItem.Click += cascadaToolStripMenuItem_Click;
            // 
            // horizontalToolStripMenuItem
            // 
            horizontalToolStripMenuItem.Image = (Image)resources.GetObject("horizontalToolStripMenuItem.Image");
            horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            horizontalToolStripMenuItem.Size = new Size(134, 22);
            horizontalToolStripMenuItem.Text = "-Horizontal";
            horizontalToolStripMenuItem.Click += horizontalToolStripMenuItem_Click;
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.Image = (Image)resources.GetObject("verticalToolStripMenuItem.Image");
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(134, 22);
            verticalToolStripMenuItem.Text = "-Vertical";
            verticalToolStripMenuItem.Click += verticalToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Image = (Image)resources.GetObject("salirToolStripMenuItem.Image");
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(134, 22);
            salirToolStripMenuItem.Text = "-Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionDeEquiposToolStripMenuItem;
        private ToolStripMenuItem gestionDeTecnicosToolStripMenuItem;
        private ToolStripMenuItem registroDeMantenimientoToolStripMenuItem;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem cascadaToolStripMenuItem;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem gestionDeEquiposToolStripMenuItem1;
        private ToolStripMenuItem gestionDeTecnicosToolStripMenuItem1;
        private ToolStripMenuItem registroDeMantenimientoToolStripMenuItem1;
    }
}
