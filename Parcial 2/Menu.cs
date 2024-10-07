namespace Parcial_2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formhijo in MdiChildren)
            {
                formhijo.Close();
            }
        }

        private void gestionDeTecnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionDeTecnicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void registroDeMantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
