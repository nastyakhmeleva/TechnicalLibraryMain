namespace TechnicalLibrary
{
    partial class FormAddNewDoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTypeOfDoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.labeldirection = new System.Windows.Forms.Label();
            this.comboBoxStudentName = new System.Windows.Forms.ComboBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.comboBoxAcademicTitle = new System.Windows.Forms.ComboBox();
            this.comboBoxAcademicDegree = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployeeName = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.labelAcademicTitle = new System.Windows.Forms.Label();
            this.labelAcademicDegree = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.labelPrintCopy = new System.Windows.Forms.Label();
            this.labelDigCopy = new System.Windows.Forms.Label();
            this.textBoxPrintCopy = new System.Windows.Forms.TextBox();
            this.textBoxDigCopy = new System.Windows.Forms.TextBox();
            this.buttonOKdirect = new System.Windows.Forms.Button();
            this.groupBoxStudent.SuspendLayout();
            this.groupBoxEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип документа";
            // 
            // comboBoxTypeOfDoc
            // 
            this.comboBoxTypeOfDoc.FormattingEnabled = true;
            this.comboBoxTypeOfDoc.Location = new System.Drawing.Point(102, 10);
            this.comboBoxTypeOfDoc.Name = "comboBoxTypeOfDoc";
            this.comboBoxTypeOfDoc.Size = new System.Drawing.Size(185, 21);
            this.comboBoxTypeOfDoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(102, 42);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(185, 20);
            this.textBoxTitle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Год создания";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(102, 77);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(185, 20);
            this.textBoxYear.TabIndex = 5;
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.comboBoxDirection);
            this.groupBoxStudent.Controls.Add(this.labeldirection);
            this.groupBoxStudent.Controls.Add(this.comboBoxStudentName);
            this.groupBoxStudent.Controls.Add(this.comboBoxGroup);
            this.groupBoxStudent.Controls.Add(this.labelGroup);
            this.groupBoxStudent.Controls.Add(this.labelStudentName);
            this.groupBoxStudent.Location = new System.Drawing.Point(12, 143);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Size = new System.Drawing.Size(276, 106);
            this.groupBoxStudent.TabIndex = 6;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Автор";
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Location = new System.Drawing.Point(87, 22);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(183, 21);
            this.comboBoxDirection.TabIndex = 5;
            this.comboBoxDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxDirection_SelectedIndexChanged);
            // 
            // labeldirection
            // 
            this.labeldirection.AutoSize = true;
            this.labeldirection.Location = new System.Drawing.Point(6, 25);
            this.labeldirection.Name = "labeldirection";
            this.labeldirection.Size = new System.Drawing.Size(75, 13);
            this.labeldirection.TabIndex = 4;
            this.labeldirection.Text = "Направление";
            // 
            // comboBoxStudentName
            // 
            this.comboBoxStudentName.FormattingEnabled = true;
            this.comboBoxStudentName.Location = new System.Drawing.Point(87, 76);
            this.comboBoxStudentName.Name = "comboBoxStudentName";
            this.comboBoxStudentName.Size = new System.Drawing.Size(183, 21);
            this.comboBoxStudentName.TabIndex = 3;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(87, 49);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGroup.TabIndex = 2;
            this.comboBoxGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroup_SelectedIndexChanged);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(6, 52);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(42, 13);
            this.labelGroup.TabIndex = 1;
            this.labelGroup.Text = "Группа";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(6, 79);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(29, 13);
            this.labelStudentName.TabIndex = 0;
            this.labelStudentName.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Статус автора";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Студент",
            "Сотрудник"});
            this.comboBoxStatus.Location = new System.Drawing.Point(102, 106);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(186, 21);
            this.comboBoxStatus.TabIndex = 1;
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.comboBoxAcademicTitle);
            this.groupBoxEmployee.Controls.Add(this.comboBoxAcademicDegree);
            this.groupBoxEmployee.Controls.Add(this.comboBoxEmployeeName);
            this.groupBoxEmployee.Controls.Add(this.comboBoxDepartment);
            this.groupBoxEmployee.Controls.Add(this.labelAcademicTitle);
            this.groupBoxEmployee.Controls.Add(this.labelAcademicDegree);
            this.groupBoxEmployee.Controls.Add(this.labelDepartment);
            this.groupBoxEmployee.Controls.Add(this.labelEmployeeName);
            this.groupBoxEmployee.Location = new System.Drawing.Point(347, 143);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(272, 142);
            this.groupBoxEmployee.TabIndex = 7;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "Автор";
            // 
            // comboBoxAcademicTitle
            // 
            this.comboBoxAcademicTitle.FormattingEnabled = true;
            this.comboBoxAcademicTitle.Location = new System.Drawing.Point(99, 110);
            this.comboBoxAcademicTitle.Name = "comboBoxAcademicTitle";
            this.comboBoxAcademicTitle.Size = new System.Drawing.Size(167, 21);
            this.comboBoxAcademicTitle.TabIndex = 7;
            // 
            // comboBoxAcademicDegree
            // 
            this.comboBoxAcademicDegree.FormattingEnabled = true;
            this.comboBoxAcademicDegree.Location = new System.Drawing.Point(99, 82);
            this.comboBoxAcademicDegree.Name = "comboBoxAcademicDegree";
            this.comboBoxAcademicDegree.Size = new System.Drawing.Size(167, 21);
            this.comboBoxAcademicDegree.TabIndex = 6;
            // 
            // comboBoxEmployeeName
            // 
            this.comboBoxEmployeeName.FormattingEnabled = true;
            this.comboBoxEmployeeName.Location = new System.Drawing.Point(99, 52);
            this.comboBoxEmployeeName.Name = "comboBoxEmployeeName";
            this.comboBoxEmployeeName.Size = new System.Drawing.Size(167, 21);
            this.comboBoxEmployeeName.TabIndex = 5;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(99, 25);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(167, 21);
            this.comboBoxDepartment.TabIndex = 4;
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            // 
            // labelAcademicTitle
            // 
            this.labelAcademicTitle.AutoSize = true;
            this.labelAcademicTitle.Location = new System.Drawing.Point(6, 113);
            this.labelAcademicTitle.Name = "labelAcademicTitle";
            this.labelAcademicTitle.Size = new System.Drawing.Size(83, 13);
            this.labelAcademicTitle.TabIndex = 3;
            this.labelAcademicTitle.Text = "Ученое звание";
            // 
            // labelAcademicDegree
            // 
            this.labelAcademicDegree.AutoSize = true;
            this.labelAcademicDegree.Location = new System.Drawing.Point(6, 85);
            this.labelAcademicDegree.Name = "labelAcademicDegree";
            this.labelAcademicDegree.Size = new System.Drawing.Size(88, 13);
            this.labelAcademicDegree.TabIndex = 2;
            this.labelAcademicDegree.Text = "Ученая степень";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(6, 28);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(87, 13);
            this.labelDepartment.TabIndex = 1;
            this.labelDepartment.Text = "Подразделение";
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Location = new System.Drawing.Point(6, 55);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(29, 13);
            this.labelEmployeeName.TabIndex = 0;
            this.labelEmployeeName.Text = "Имя";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить нового автора";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(16, 299);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(93, 39);
            this.Save.TabIndex = 9;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(115, 299);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(93, 39);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Отменить добавление";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // labelPrintCopy
            // 
            this.labelPrintCopy.AutoSize = true;
            this.labelPrintCopy.Location = new System.Drawing.Point(9, 252);
            this.labelPrintCopy.Name = "labelPrintCopy";
            this.labelPrintCopy.Size = new System.Drawing.Size(104, 13);
            this.labelPrintCopy.TabIndex = 11;
            this.labelPrintCopy.Text = "Физическая копия";
            // 
            // labelDigCopy
            // 
            this.labelDigCopy.AutoSize = true;
            this.labelDigCopy.Location = new System.Drawing.Point(9, 272);
            this.labelDigCopy.Name = "labelDigCopy";
            this.labelDigCopy.Size = new System.Drawing.Size(106, 13);
            this.labelDigCopy.TabIndex = 12;
            this.labelDigCopy.Text = "Электронная копия";
            // 
            // textBoxPrintCopy
            // 
            this.textBoxPrintCopy.Location = new System.Drawing.Point(119, 249);
            this.textBoxPrintCopy.Name = "textBoxPrintCopy";
            this.textBoxPrintCopy.Size = new System.Drawing.Size(169, 20);
            this.textBoxPrintCopy.TabIndex = 13;
            // 
            // textBoxDigCopy
            // 
            this.textBoxDigCopy.Location = new System.Drawing.Point(119, 269);
            this.textBoxDigCopy.Name = "textBoxDigCopy";
            this.textBoxDigCopy.Size = new System.Drawing.Size(169, 20);
            this.textBoxDigCopy.TabIndex = 14;
            // 
            // buttonOKdirect
            // 
            this.buttonOKdirect.Location = new System.Drawing.Point(294, 104);
            this.buttonOKdirect.Name = "buttonOKdirect";
            this.buttonOKdirect.Size = new System.Drawing.Size(34, 23);
            this.buttonOKdirect.TabIndex = 15;
            this.buttonOKdirect.Text = "ОК";
            this.buttonOKdirect.UseVisualStyleBackColor = true;
            this.buttonOKdirect.Click += new System.EventHandler(this.buttonOKdirect_Click);
            // 
            // FormAddNewDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 366);
            this.Controls.Add(this.textBoxDigCopy);
            this.Controls.Add(this.textBoxPrintCopy);
            this.Controls.Add(this.buttonOKdirect);
            this.Controls.Add(this.labelDigCopy);
            this.Controls.Add(this.labelPrintCopy);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxEmployee);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.groupBoxStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTypeOfDoc);
            this.Controls.Add(this.label1);
            this.Name = "FormAddNewDoc";
            this.Text = "AddNewDoc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddNewDoc_FormClosing);
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxStudent.PerformLayout();
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTypeOfDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.Label labelAcademicDegree;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.Label labelAcademicTitle;
        private System.Windows.Forms.ComboBox comboBoxStudentName;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.ComboBox comboBoxAcademicTitle;
        private System.Windows.Forms.ComboBox comboBoxAcademicDegree;
        private System.Windows.Forms.ComboBox comboBoxEmployeeName;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label labelPrintCopy;
        private System.Windows.Forms.Label labelDigCopy;
        private System.Windows.Forms.TextBox textBoxPrintCopy;
        private System.Windows.Forms.TextBox textBoxDigCopy;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.Label labeldirection;
        private System.Windows.Forms.Button buttonOKdirect;
    }
}