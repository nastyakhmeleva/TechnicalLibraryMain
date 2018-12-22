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
            comboBoxTypeOfDoc.Items.Clear();
            foreach (Document doc in model.DocumentSet)
            {
                comboBoxTypeOfDoc.Items.Add(doc.Type);
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
            
        }
    }
}
