using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhoneBook.Classes;

namespace PhoneBook
{
    public partial class frmEditContact : Form
    {
        #region Members

        private Contact contact = null;

        #endregion

        #region Constructors

        public frmEditContact(Contact contact)
        {
            InitializeComponent();

            this.contact = contact;
        }

        #endregion

        #region Event Handlers

        private void frmEditContact_Load(object sender, EventArgs e)
        {
            this.Text = String.Format(this.Text, this.contact.ID > 0 ? "Edit" : "New");

            this.tbFirstName.Text = this.contact.FirstName;
            this.tbLastName.Text = this.contact.LastName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.contact.FirstName = this.tbFirstName.Text;
            this.contact.LastName = this.tbLastName.Text;

            this.DialogResult = DialogResult.OK;
        }

        #endregion

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
