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
        }

        private void AddNewDoc_Click(object sender, EventArgs e)
        {
            FormAddNewDoc newForm=new FormAddNewDoc();
            newForm.ParentMainForm = this;
            newForm.Show();
            Hide();
        }
    }
}
