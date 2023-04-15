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
        public VitalClass _vitalClass=new VitalClass();
        public List<string> strings = new List<string>();
        public frmEncounterNote()
        {
            InitializeComponent();
        }
        public new void EnabledButtons()
        {
            txtNoteId.Enabled = false;
            txtName.Enabled = true;
            txtProblem.Enabled = true;
            dtpBirthDate.Enabled = true;
            
           
            
            rTxtNote.Enabled = true;
        }
        public new void DisableButtons()
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
            rTxtNote.Enabled = false;
        }
        private void frmEncounterNote_Load(object sender, EventArgs e)
        {
            _manageClinicClass.ReadUser();
            foreach (var user in _manageClinicClass.ClinicNotes)
            {
                if(user.Name!=null)
                {
                    lstPatients.Items.Add($"{user.Name}(Note Id:{user.Id})");
                }
            }
            DisableButtons();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            
            int nId = int.Parse(txtNoteId.Text);
            string nName=txtName.Text;
            DateTime nBirthDate = dtpBirthDate.Value;
            string[] nProblem=new string[lstProblems.Items.Count];
            string nNote=rTxtNote.Text;

            for(int i=0;i<lstProblems.Items.Count;i++)
            {
                nProblem[i]=lstProblems.Items[i].ToString();
            }
            try
            {
                ClinicNoteClass clinicNote = new ClinicNoteClass(nId, nName, nProblem, nBirthDate, nNote);
                _manageClinicClass.AddPatient(clinicNote);
                lstPatients.Items.Add($"{nName}(Note Id:{nId})");
                _manageClinicClass.AddNewUser(clinicNote);
                lblError.Text = "Your Note Has been added successfully";
                lblError.ForeColor = Color.Green;
                DisableButtons();
                rTxtNote.Text = "";
                txtName.Text = "";
                lstProblems.Items.Clear();
                lstBpMeasurment.Items.Clear();
            }
            catch (Exception ex)
            {
               lblError.Text=ex.Message;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            rTxtNote.Text = "";
            txtName.Text = "";
            txtNoteId.Text = "";
            lstProblems.Items.Clear();
            lblError.Text = "";
            txtNoteId.Text = _manageClinicClass.GetNewID().ToString();
            EnabledButtons();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstProblems.Items.Add(txtProblem.Text);
            txtProblem.Text = "";
        }

        private void rTxtNote_TextChanged(object sender, EventArgs e)
        {
            _vitalClass.vitals.Clear();
            _vitalClass.ExtractBp(rTxtNote.Text);
            _vitalClass.ExtractHr(rTxtNote.Text);
            _vitalClass.ExtractRr(rTxtNote.Text);
            _vitalClass.ExtractT(rTxtNote.Text);

            if (_vitalClass.vitals.Count != 0)
            {
                for (int j = 0; j < _vitalClass.vitals.Count; j++)
                {
                    if (!strings.Contains(_vitalClass.vitals[j].ToString()))
                    {
                        lstBpMeasurment.Items.Add(_vitalClass.vitals[j].ToString());
                        strings.Add(_vitalClass.vitals[j].ToString());
                        
                    }
                        
                }
            }
           
        }

        private void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            rTxtNote.Text = "";
            txtName.Text = "";
            txtNoteId.Text = "";
            lstProblems.Items.Clear();
            EnabledButtons();
            lblError.Text = "";
            btnAddNote.Enabled= false;
            btnAdd.Enabled=true;
            btnUpdate.Enabled= true;
            btnDelete.Enabled= true;
            string nName = lstPatients.GetItemText(lstPatients.SelectedItem);
            foreach (var user in _manageClinicClass.ClinicNotes)
            {
                if(nName==user.lstName)
                {
                    txtNoteId.Text = user.Id.ToString();
                    txtName.Text = user.Name;
                    dtpBirthDate.Value = user.BirthDate;
                    rTxtNote.Text = user.Note;
                    foreach (var prob in user.ArrayOfProblems)
                    {
                        lstProblems.Items.Add(prob);
                    }
                }
            }
        }
    }
}
