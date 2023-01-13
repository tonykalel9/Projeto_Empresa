namespace Empresa.UI.Windows
{
    public partial class principalForm : Form
    {
        public principalForm()
        {
            InitializeComponent();
        }

        private void teste1StripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void principalForm_Load(object sender, EventArgs e)
        {

        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteIncluirForm f = new ClienteIncluirForm();
            f.ShowDialog();
        }
    }


}