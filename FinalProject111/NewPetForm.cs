using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject111
{
    public partial class NewPetForm : Form
    {
        private MainForm _mainForm;
        private int PetCount;
        bool IsEditing;
        private int CurrentSelectionId;

        public NewPetForm(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
            PetCount = 1;
            IsEditing = false;
            CurrentSelectionId = -1;
        }

        public void ToggleEdit(bool newState)
        {
            IsEditing = newState;
            _mainForm.EditPet(0, new Pet());
        }

        private void CreatePet()
        {
            if (!EntryIsValid())
            {
                MessageBox.Show("Invalid entry, please try again.");
                return;
            }

            Pet pet = new Pet
            {
                PetId = PetCount,
                Name = txtName.Text,
                Species = txtSpecies.Text,
                Color = txtColor.Text,
                Age = txtAge.Text,
            };

            _mainForm.AddPet(pet);

            PetCount++;
        }

        public void EditPet()
        {
            if (!EntryIsValid())
            {
                MessageBox.Show("Invalid entry, please try again.");
                return;
            }

            _mainForm.EditPet(CurrentSelectionId, new Pet
            {
                PetId = CurrentSelectionId,
                Name = txtName.Text,
                Species = txtSpecies.Text,
                Color = txtColor.Text,
                Age = txtAge.Text,
            });

            CurrentSelectionId = -1;
            ToggleEdit(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                EditPet();
            }
            else
            {
                CreatePet();
            }
            ClearForm();
            Hide();
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtSpecies.Text = "";
            txtColor.Text = "";
            txtAge.Text = "";
        }

        public void LoadPet(Pet pet)
        {
            CurrentSelectionId = pet.PetId;
            txtName.Text = pet.Name;
            txtSpecies.Text = pet.Species;
            txtColor.Text = pet.Color;
            txtAge.Text = pet.Age;
        }

        private bool EntryIsValid()
        {
            bool validEntry = true;

            if (Validators.IsEmptyText(txtName) || Validators.IsTextNull(txtName))
            {
                MessageBox.Show("Pet name required. Please try again.");
                validEntry = false;
            }

            if (Validators.IsEmptyText(txtSpecies) || Validators.IsTextNull(txtSpecies))
            {
                MessageBox.Show("Pet species required. Please try again.");
                validEntry = false;
            }

            if (Validators.IsEmptyText(txtColor) || Validators.IsTextNull(txtColor))
            {
                MessageBox.Show("Pet color required. Please try again.");
                validEntry = false;
            }

            if (Validators.IsEmptyText(txtAge) || Validators.IsTextNull(txtAge))
            {
                MessageBox.Show("Pet age required. Please try again.");
                validEntry = false;
            }

            return validEntry;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
