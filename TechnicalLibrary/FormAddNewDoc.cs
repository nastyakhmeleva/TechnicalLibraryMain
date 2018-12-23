﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalLibrary
{
    public partial class FormAddNewDoc : Form
    {
        public static LibraryContainer model=new LibraryContainer();
        public MainForm ParentMainForm;
        public FormAddNewDoc()
        {
            InitializeComponent();
            ShowComboboxes();
            addDirection();
            addGroup();
            addStudentName();
            addDirections();
            addEmployeeName();
        }

        public void addDirection()
        {
            if (comboBoxStatus.Text == "Студент")
            {
                comboBoxDirection.DataSource = model.EducationDirectionSet.ToList();
                comboBoxDirection.DisplayMember = "Name";
            }
        }

        public void addGroup()
        {
            EducationDirection eddir = (EducationDirection)comboBoxDirection.SelectedItem;
            List<StudyGroup> listSG = model.StudyGroupSet.Where(x => x.EducationDirection.Id == eddir.Id).ToList();
            comboBoxGroup.DataSource = listSG;
            comboBoxGroup.DisplayMember = "Name";
        }

        public void addStudentName()
        {
            StudyGroup stgr = (StudyGroup)comboBoxGroup.SelectedItem;
            List<Student> listSt = model.StudentSet.Where(x => x.StudyGroup.Id == stgr.Id).ToList();
            comboBoxStudentName.DataSource = listSt;
            comboBoxStudentName.DisplayMember = "Name";
        }
        public void addDirections()
        {
            if (comboBoxStatus.Text == "Сотрудник")
            {
                comboBoxDepartment.DataSource = model.DepartmentSet.ToList();
                comboBoxDepartment.DisplayMember = "Name";
            }
        }
        public void addEmployeeName()
        {
            Department depart = (Department)comboBoxDepartment.SelectedItem;
            List<Employee> listEmp = model.EmployeeSet.Where(x => x.Department.Id == depart.Id).ToList();
            comboBoxEmployeeName.DataSource = listEmp;
            comboBoxEmployeeName.DisplayMember = "Name";
        }
        public void ShowComboboxes()
        {
            comboBoxTypeOfDoc.Items.Clear();
            foreach (Type type in model.TypeSet)
            {
                if (type.Name!=null)
                    comboBoxTypeOfDoc.Items.Add(type.Name);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var documents = model.DocumentSet.Where(u => u.Name.Contains(textBoxTitle.Text)).ToList();
            if (documents.Count <= 0)
            {
                if (((textBoxTitle.Text != "") && (textBoxYear.Text != "") && (textBoxPrintCopy.Text!="")&&(textBoxDigCopy.Text!="")&&
                     (comboBoxTypeOfDoc.SelectedItem != null) && (comboBoxStatus.SelectedItem != null) &&
                     (comboBoxGroup.SelectedItem != null) && (comboBoxStudentName.SelectedItem != null)) ||

                    ((textBoxTitle.Text != "") && (textBoxYear.Text != "") && (textBoxPrintCopy.Text != "") && (textBoxDigCopy.Text != "") &&
                     (comboBoxTypeOfDoc.SelectedItem != null) && (comboBoxStatus.SelectedItem != null) &&
                     (comboBoxDepartment.SelectedItem != null) && (comboBoxEmployeeName.SelectedItem != null)))
                {
                    Document doc = new Document();
                    {
                        doc.Type.Name = comboBoxTypeOfDoc.Text;
                        doc.Name = textBoxTitle.Text;
                        doc.PrintCopy = textBoxPrintCopy.Text;
                        doc.ElectroCopy = textBoxDigCopy.Text;
                        try
                        {
                            if (Int32.Parse(textBoxYear.Text) <= DateTime.Now.Year)
                            {
                                doc.Year = Int32.Parse(textBoxYear.Text);
                            }
                            else
                            {
                                MessageBox.Show("Неверно указан год");
                                return;
                            }
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Неверно указан год");
                            return;
                        }
                    }
                    
                    model.DocumentSet.Add(doc);
                    model.SaveChanges();

                    PeopleDocEntity ent = new PeopleDocEntity();
                    {
                        if ((comboBoxStudentName.Text != null) && (textBoxTitle.Text != ""))
                        {
                            ent.Student = model.StudentSet.Find(model.StudentSet
                                .Where(x => x.Name.Contains(comboBoxStudentName.Text)).ToList()[0].Id);
                            ent.Document =
                                model.DocumentSet.Find(model.DocumentSet.Where(x => x.Name.Contains(textBoxTitle.Text))
                                    .ToList()[0].Id);
                        }

                        if ((comboBoxEmployeeName.Text != null) && (textBoxTitle.Text != ""))
                        {
                            ent.Employee = model.EmployeeSet.Find(model.EmployeeSet
                                .Where(x => x.Name.Contains(comboBoxEmployeeName.Text)).ToList()[0].Id);
                            ent.Document =
                                model.DocumentSet.Find(model.DocumentSet.Where(x => x.Name.Contains(textBoxTitle.Text))
                                    .ToList()[0].Id);
                        }
                    }
                    if (comboBoxStudentName.Text != null)
                    {
                        Student student =
                            model.StudentSet.Find(model.StudentSet.Where(x => x.Name.Contains(comboBoxStudentName.Text))
                                .ToList()[0].Id);
                        student.PeopleDocEntity.Add(ent);
                    }

                    if (comboBoxEmployeeName.Text != null)
                    {
                        Employee employee =
                            model.EmployeeSet.Find(model.EmployeeSet.Where(x => x.Name.Contains(comboBoxEmployeeName.Text))
                                .ToList()[0].Id);
                        employee.PeopleDocEntity.Add(ent);
                    }

                    model.DocumentSet.Find(model.DocumentSet.Where(x => x.Name.Contains(textBoxTitle.Text)).ToList()[0]
                        .Id);
                    doc.PeopleDocEntity.Add(ent);
                    model.PeopleDocEntitySet.Add(ent);
                    model.SaveChanges();
                }
            }
        }

        private void FormAddNewDoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentMainForm.Show();
        }

        private void comboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            EducationDirection eddir = (EducationDirection)comboBoxDirection.SelectedItem;
            List<StudyGroup> listSG = model.StudyGroupSet.Where(x => x.EducationDirection.Id == eddir.Id).ToList();
            comboBoxGroup.DataSource = listSG;
            comboBoxGroup.DisplayMember = "Name";
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudyGroup stgr = (StudyGroup)comboBoxGroup.SelectedItem;
            List<Student> listSt = model.StudentSet.Where(x => x.StudyGroup.Id == stgr.Id).ToList();
            comboBoxStudentName.DataSource = listSt;
            comboBoxStudentName.DisplayMember = "Name";
        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Department depart = (Department)comboBoxDepartment.SelectedItem;
            List<Employee> listEmp = model.EmployeeSet.Where(x => x.Department.Id == depart.Id).ToList();
            comboBoxEmployeeName.DataSource = listEmp;
            comboBoxEmployeeName.DisplayMember = "Name";
        }
    }
}
