using PartBusinessLayer;
using PartModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Multi_Layer
{
    public partial class FormAddEditAndContact : Form
    {
        bool IsNew;

        public FormAddEditAndContact(Contact obj)
        {
            InitializeComponent();
            if(obj==null)
            {
                contactBindingSource.DataSource = new Contact();
                IsNew = true;
            }
            else
            {
                contactBindingSource.DataSource = obj;
                IsNew = false;
            }
        }

        private void FormAddEditAndContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult==DialogResult.OK)
            {
                if(string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Veuillez entrez le nom de votre contact !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Focus();
                    e.Cancel = true;
                    return;
                }
                if(IsNew)
                {
                    ContactServices.Insert(contactBindingSource.Current as Contact);
                }
                else
                {
                    ContactServices.Update(contactBindingSource.Current as Contact);
                }
            }
        }
    }
}
