using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using ClinicNoteClass = Patient.ClinicNote;
using ManageClinicClass = Patient.ManageClinicNotes;
using VitalClass = Patient.Vitals;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3
{
    public partial class frmEncounterNote : Form
    {
        public ManageClinicClass _manageClinicClass=new ManageClinicClass();
        public frmEncounterNote()
        {
            InitializeComponent();
        }
        public new void EnabledButtons()
        {
            txtNoteId.Enabled = false;
            txtName.Enabled = false;
            txtProblem.Enabled = false;
            dtpBirthDate.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
            btnAddNote.Enabled = false;
        }
        public new void Enabled()
        {
            txtNoteId.Enabled = false;
            txtName.Enabled = false;
            txtProblem.Enabled = false;
            dtpBirthDate.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
            btnAddNote.Enabled = false;
        }
        private void frmEncounterNote_Load(object sender, EventArgs e)
        {
            //Enabled();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            
            int nId = int.Parse(txtNoteId.Text);
            string nName=txtName.Text;
            DateTime nBirthDate = dtpBirthDate.Value;
            string nProblem=txtProblem.Text;
            string nNote=rTxtNote.Text;

            ClinicNoteClass clinicNote = new ClinicNoteClass(nId, nName, nProblem, nBirthDate, nNote);
            _manageClinicClass.AddPatient(clinicNote);
            _manageClinicClass.AddNewUser(clinicNote);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtNoteId.Text = _manageClinicClass.GetNewID().ToString();
        }
    }
}
