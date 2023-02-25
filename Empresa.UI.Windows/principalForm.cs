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
            var f = new ClientesForm();
            f.ShowDialog();
        }

        private void principalForm_Load(object sender, EventArgs e)
        {

        }


    }


}