namespace FinalProject111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewPetForm petForm = new NewPetForm();

            petForm.ShowDialog();
        }
    }
}
