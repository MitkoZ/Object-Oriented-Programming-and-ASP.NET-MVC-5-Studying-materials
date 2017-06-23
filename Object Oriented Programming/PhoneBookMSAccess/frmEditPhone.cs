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
    public partial class frmEditPhone : Form
    {
        #region Members

        private Phone phone = null;

        #endregion

        #region Constructors

        public frmEditPhone(Phone phone)
        {
            InitializeComponent();

            this.phone = phone;
        }

        #endregion

        #region Event Handlers

        private void frmEditPhone_Load(object sender, EventArgs e)
        {
            this.Text = String.Format(this.Text, this.phone.ID > 0 ? "Edit" : "New");

            this.tbPhone.Text = this.phone.PhoneNumber;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.phone.PhoneNumber = this.tbPhone.Text;

            this.DialogResult = DialogResult.OK;
        }

        #endregion
    }
}
