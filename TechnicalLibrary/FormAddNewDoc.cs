using System;
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
        }
        public void ShowComboboxes()
        {
            foreach (Document doc in model.DocumentSet)
            {
                comboBoxTypeOfDoc.Items.Add(doc);
            }
            comboBoxStatus.Items.Clear();
            foreach (Author author in model.AuthorSet)
            {
                comboBoxStatus.Items.Add(author.Status);
            }
            comboBoxGroup.Items.Clear();
            foreach (Author author in model.AuthorSet)
            {
                if (author.StudyGroup!=null)
                comboBoxGroup.Items.Add(author.StudyGroup);
            }
            comboBoxStudentName.Items.Clear();
            foreach (Author author in model.AuthorSet)
            {
                if (author.StudyGroup != null)
                comboBoxStudentName.Items.Add(author.Name);
            }
            comboBoxDepartment.Items.Clear();
            foreach (Author author in model.AuthorSet)
            {
                if (author.Department != null)
                    comboBoxDepartment.Items.Add(author.Department);
            }
            comboBoxEmployeeName.Items.Clear();
            foreach (Author author in model.AuthorSet)
            {
                if (author.Department != null)
                    comboBoxEmployeeName.Items.Add(author.Name);
            }
            comboBoxAcademicDegree.Items.Clear();
            foreach (Author author in model.AuthorSet)
            {
                if (author.AcademicDegree != null)
                    comboBoxAcademicDegree.Items.Add(author.AcademicDegree);
            }
            comboBoxAcademicTitle.Items.Clear();
            foreach (Author author in model.AuthorSet)
            {
                if (author.AcademicTitle != null)
                    comboBoxAcademicTitle.Items.Add(author.AcademicTitle);
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
                        doc.Type = comboBoxTypeOfDoc.Text;
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
                            ent.Author = model.AuthorSet.Find(model.AuthorSet
                                .Where(x => x.Name.Contains(comboBoxStudentName.Text)).ToList()[0].Id);
                            ent.Document =
                                model.DocumentSet.Find(model.DocumentSet.Where(x => x.Name.Contains(textBoxTitle.Text))
                                    .ToList()[0].Id);
                        }

                        if (comboBoxEmployeeName.Text != null)
                        {
                            ent.Author = model.AuthorSet.Find(model.AuthorSet
                                .Where(x => x.Name.Contains(comboBoxEmployeeName.Text)).ToList()[0].Id);
                            ent.Document =
                                model.DocumentSet.Find(model.DocumentSet.Where(x => x.Name.Contains(textBoxTitle.Text))
                                    .ToList()[0].Id);
                        }
                    }
                    if (comboBoxStudentName.Text != null)
                    {
                        Author author =
                            model.AuthorSet.Find(model.AuthorSet.Where(x => x.Name.Contains(comboBoxStudentName.Text))
                                .ToList()[0].Id);
                        author.StDocEntity.Add(ent);
                    }

                    if (comboBoxEmployeeName.Text != null)
                    {
                        Author author =
                            model.AuthorSet.Find(model.AuthorSet.Where(x => x.Name.Contains(comboBoxEmployeeName.Text))
                                .ToList()[0].Id);
                        author.StDocEntity.Add(ent);
                    }

                    model.DocumentSet.Find(model.DocumentSet.Where(x => x.Name.Contains(textBoxTitle.Text)).ToList()[0]
                        .Id);
                    doc.StDocEntity.Add(ent);
                    model.PeopleDocEntitySet.Add(ent);
                    model.SaveChanges();
                }

            }
        }

        private void FormAddNewDoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentMainForm.Show();
        }
    }
}
