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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contactBindingSource.DataSource = ContactServices.GetAll();
        }

        private void creerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormAddEditAndContact frm = new FormAddEditAndContact(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    contactBindingSource.DataSource = ContactServices.GetAll();              
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contactBindingSource.Current == null)
                return;
            using (FormAddEditAndContact frm = new FormAddEditAndContact(contactBindingSource.Current as Contact))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    contactBindingSource.DataSource = ContactServices.GetAll();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contactBindingSource.Current == null)
                return;
            if (MessageBox.Show("Voulez vous vraiment supprimer ce contact ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                ContactServices.Delete(contactBindingSource.Current as Contact);
                contactBindingSource.RemoveCurrent();
            }
        }
    }
}
