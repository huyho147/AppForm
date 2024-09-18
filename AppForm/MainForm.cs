namespace AppForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tínhPhươngTrìnhBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TinhptBac2 Form = new TinhptBac2();
            Form.ShowDialog();
        }

        private void kiểmTraSốNguyênTốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KtraSoNguyenTo Form = new KtraSoNguyenTo();
            Form.ShowDialog();
        }

        private void đồngHồĐếmGiờToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopWatch Form = new StopWatch();
            Form.ShowDialog();
        }

        private void tínhToánTrênDãySốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TinhtoanDayso Form = new TinhtoanDayso();
            Form.ShowDialog();
        }
    }
}
