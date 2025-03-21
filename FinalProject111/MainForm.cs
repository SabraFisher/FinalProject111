namespace FinalProject111
{
    public partial class MainForm : Form
    {
        private NewPetForm _petForm;
        private List<Pet> _petList;
        public MainForm()
        {
            InitializeComponent();
            _petForm = new NewPetForm(this);
            _petList = new List<Pet>();
            _petList.Add(new Pet
            {
                Name = "Fido",
                Species = "Dog",
                Color = "Brown",
                Age = "3"
            });
            ReloadDataGrid();
            dgvPets.Rows[0].Selected = true;
        }

        private void ReloadDataGrid()
        {
            dgvPets.DataSource = null;
            dgvPets.DataSource = _petList;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _petForm.ShowDialog();
        }

        public void AddPet(Pet pet)
        {
            _petList.Add(pet);
            ReloadDataGrid();
        }

        public void EditPet(int id, Pet updatedPet)
        {
            var p = _petList.Find(x => x.PetId == id);

            if (p != null)
            {
                p.Name = updatedPet.Name;
                p.Species = updatedPet.Species;
                p.Color = updatedPet.Color;
                p.Age = updatedPet.Age;
            }
            ReloadDataGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Pet p;
            var index = dgvPets.SelectedRows[0].Index;
            p = _petList[index];
            _petForm.LoadPet(p);
            _petForm.ToggleEdit(true);
            _petForm.Show();
        }

        public void dgvPets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Visible = true;
            ReloadDataGrid();
        }

        
    }
}
