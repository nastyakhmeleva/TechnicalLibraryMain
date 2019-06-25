using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalLibrary
{
    public partial class MainForm : Form
    {
        public static LibraryContainer model = new LibraryContainer();

        public MainForm()
        {
            InitializeComponent();
            ShowTable();
        }

        public void ShowTable()
        {
            dataGridViewDoc.Rows.Clear();
            model = new LibraryContainer();

            List<string[]> data=new List<string[]>();

            foreach (Document doc in model.DocumentSet)
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = doc.Id.ToString();
                data[data.Count - 1][1] = doc.Name;
                data[data.Count - 1][2] = Convert.ToString(doc.Year);


                var list = model.PeopleDocEntitySet.Where(x => x.Document.Id==doc.Id).ToList();
                string authors=null;
                foreach (var el in list)
                {
                    if (el.Employee != null)
                    {
                        authors += el.Employee.Name+ "; ";
                    }
                    if (el.Student != null)
                    {
                        authors += el.Student.Name + "; ";
                    }
                }
                data[data.Count - 1][3] = authors;

                dataGridViewDoc.Rows.Add(data[data.Count - 1]);
            }
        }

        private void deleteDocument()
        {
            try
            {
                int id = Int32.Parse(dataGridViewDoc.CurrentRow.Cells[0].Value.ToString());
                foreach (PeopleDocEntity pd in model.PeopleDocEntitySet)
                {
                    if (pd.Document.Id == id)
                        model.PeopleDocEntitySet.Remove(pd);
                }
                model.DocumentSet.Remove(model.DocumentSet.Find(id));
                model.SaveChanges();
                ShowTable();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Строка не выбрана");
            }
        }

        private void AddNewDoc_Click(object sender, EventArgs e)
        {
            FormAddNewDoc newForm=new FormAddNewDoc();
            newForm.ParentMainForm = this;
            newForm.Show();
            Hide();
        }

        private void DeleteDoc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Подтвердить удаление документа?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                deleteDocument();
            }
        }
    }
}
