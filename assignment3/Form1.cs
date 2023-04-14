﻿using System;
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
            txtName.Enabled = true;
            txtProblem.Enabled = true;
            dtpBirthDate.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
            btnAddNote.Enabled = true;
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
        }
        private void frmEncounterNote_Load(object sender, EventArgs e)
        {
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

            ClinicNoteClass clinicNote = new ClinicNoteClass(nId, nName, nProblem, nBirthDate, nNote);
            _manageClinicClass.AddPatient(clinicNote);
            _manageClinicClass.AddNewUser(clinicNote);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            EnabledButtons();
            txtNoteId.Text = _manageClinicClass.GetNewID().ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstProblems.Items.Add(txtProblem.Text);
        }
    }
}
