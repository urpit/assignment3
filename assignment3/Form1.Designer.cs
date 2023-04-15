namespace assignment3
{
    partial class frmEncounterNote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.rTxtNote = new System.Windows.Forms.RichTextBox();
            this.lstBpMeasurment = new System.Windows.Forms.ListBox();
            this.lstProblems = new System.Windows.Forms.ListBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtProblem = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNoteId = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblBp = new System.Windows.Forms.Label();
            this.lblListProblems = new System.Windows.Forms.Label();
            this.lblProblem = new System.Windows.Forms.Label();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstPatients = new System.Windows.Forms.ListBox();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnAddNote);
            this.groupBox1.Controls.Add(this.rTxtNote);
            this.groupBox1.Controls.Add(this.lstBpMeasurment);
            this.groupBox1.Controls.Add(this.lstProblems);
            this.groupBox1.Controls.Add(this.dtpBirthDate);
            this.groupBox1.Controls.Add(this.txtProblem);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtNoteId);
            this.groupBox1.Controls.Add(this.lblNote);
            this.groupBox1.Controls.Add(this.lblBp);
            this.groupBox1.Controls.Add(this.lblListProblems);
            this.groupBox1.Controls.Add(this.lblProblem);
            this.groupBox1.Controls.Add(this.lblDateBirth);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Location = new System.Drawing.Point(195, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 393);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit/Delete Encounter Note:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(164, 348);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update Note";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(270, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete Note";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(235, 169);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(59, 348);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(75, 23);
            this.btnAddNote.TabIndex = 14;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // rTxtNote
            // 
            this.rTxtNote.Location = new System.Drawing.Point(59, 208);
            this.rTxtNote.Name = "rTxtNote";
            this.rTxtNote.Size = new System.Drawing.Size(457, 134);
            this.rTxtNote.TabIndex = 13;
            this.rTxtNote.Text = "";
            this.rTxtNote.TextChanged += new System.EventHandler(this.rTxtNote_TextChanged);
            // 
            // lstBpMeasurment
            // 
            this.lstBpMeasurment.FormattingEnabled = true;
            this.lstBpMeasurment.Location = new System.Drawing.Point(423, 67);
            this.lstBpMeasurment.Name = "lstBpMeasurment";
            this.lstBpMeasurment.Size = new System.Drawing.Size(117, 95);
            this.lstBpMeasurment.TabIndex = 12;
            // 
            // lstProblems
            // 
            this.lstProblems.FormattingEnabled = true;
            this.lstProblems.Location = new System.Drawing.Point(313, 67);
            this.lstProblems.Name = "lstProblems";
            this.lstProblems.Size = new System.Drawing.Size(82, 95);
            this.lstProblems.TabIndex = 11;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(128, 109);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(100, 20);
            this.dtpBirthDate.TabIndex = 10;
            // 
            // txtProblem
            // 
            this.txtProblem.Location = new System.Drawing.Point(128, 142);
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.Size = new System.Drawing.Size(140, 20);
            this.txtProblem.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtNoteId
            // 
            this.txtNoteId.Location = new System.Drawing.Point(128, 40);
            this.txtNoteId.Name = "txtNoteId";
            this.txtNoteId.Size = new System.Drawing.Size(100, 20);
            this.txtNoteId.TabIndex = 7;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(56, 191);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(38, 13);
            this.lblNote.TabIndex = 6;
            this.lblNote.Text = "Notes:";
            // 
            // lblBp
            // 
            this.lblBp.AutoSize = true;
            this.lblBp.Location = new System.Drawing.Point(420, 43);
            this.lblBp.Name = "lblBp";
            this.lblBp.Size = new System.Drawing.Size(96, 13);
            this.lblBp.TabIndex = 5;
            this.lblBp.Text = "BP Measurements:";
            // 
            // lblListProblems
            // 
            this.lblListProblems.AutoSize = true;
            this.lblListProblems.Location = new System.Drawing.Point(310, 43);
            this.lblListProblems.Name = "lblListProblems";
            this.lblListProblems.Size = new System.Drawing.Size(53, 13);
            this.lblListProblems.TabIndex = 4;
            this.lblListProblems.Text = "Problems:";
            // 
            // lblProblem
            // 
            this.lblProblem.AutoSize = true;
            this.lblProblem.Location = new System.Drawing.Point(52, 145);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Size = new System.Drawing.Size(70, 13);
            this.lblProblem.TabIndex = 3;
            this.lblProblem.Text = "New Problem";
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.Location = new System.Drawing.Point(52, 109);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(69, 13);
            this.lblDateBirth.TabIndex = 2;
            this.lblDateBirth.Text = "Date of Birth:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(52, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Patient Name:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(52, 43);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(47, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Note ID:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(28, 28);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start New Note";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstPatients
            // 
            this.lstPatients.FormattingEnabled = true;
            this.lstPatients.Location = new System.Drawing.Point(28, 71);
            this.lstPatients.Name = "lstPatients";
            this.lstPatients.Size = new System.Drawing.Size(120, 342);
            this.lstPatients.TabIndex = 2;
            this.lstPatients.SelectedIndexChanged += new System.EventHandler(this.lstPatients_SelectedIndexChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(28, 445);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 3;
            // 
            // frmEncounterNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lstPatients);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEncounterNote";
            this.Text = "Encounter Notes";
            this.Load += new System.EventHandler(this.frmEncounterNote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.RichTextBox rTxtNote;
        private System.Windows.Forms.ListBox lstBpMeasurment;
        private System.Windows.Forms.ListBox lstProblems;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox txtProblem;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNoteId;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblBp;
        private System.Windows.Forms.Label lblListProblems;
        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstPatients;
        private System.Windows.Forms.Label lblError;
    }
}

