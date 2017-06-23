using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Linq;

using PhoneBook.Classes;

namespace PhoneBook
{
    public partial class frmPhonebook : Form
    {
        #region Members

        private OleDbConnection conn = null;

        #endregion

        #region Constructors

        public frmPhonebook()
        {
            // http://connectionstrings.com
            InitializeComponent();

            this.conn = new OleDbConnection();
            this.conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.mdb;";
        }

        #endregion

        #region Functional Methods

        private void AdjustControlsAvailability()
        {
            this.tsbtnContactsNew.Enabled = true;
            this.tsbtnContactsEdit.Enabled = this.lbContacts.SelectedItem != null;
            this.tsbtnContactsDelete.Enabled = this.lbContacts.SelectedItem != null;

            this.tsbtnPhonesNew.Enabled = this.lbContacts.SelectedItem != null;
            this.tsbtnPhonesEdit.Enabled = this.lbPhones.SelectedItem != null;
            this.tsbtnPhonesDelete.Enabled = this.lbPhones.SelectedItem != null;
        }

        private List<Contact> GetContacts()
        {
            List<Contact> resultSet = new List<Contact>();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = this.conn;
            cmd.CommandText = @"
SELECT
  id,
  first_name,
  last_name
FROM
  contacts
";
            try
            {
                this.conn.Open();

                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Contact c = new Contact();
                    c.ID = Convert.ToInt32(reader["id"]);
                    c.FirstName = Convert.ToString(reader["first_name"]);
                    c.LastName = Convert.ToString(reader["last_name"]);
                    c.Phones = new List<Phone>();

                    resultSet.Add(c);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Database operation Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1);
            }
            finally
            {
                this.conn.Close();
            }

            //Initialize phones
            List<Phone> phones = this.GetPhones();
            foreach (Contact contact in resultSet)
            {
                IEnumerable<Phone> result = from p in phones
                                            where p.ContactID == contact.ID
                                            select p;

                contact.Phones.AddRange(result);
            }

            return resultSet;
        }
        private List<Phone> GetPhones()
        {
            List<Phone> resultSet = new List<Phone>();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = this.conn;
            cmd.CommandText = @"
SELECT
  id,
  contact_id,
  phone
FROM
  contact_phones
";
            try
            {
                this.conn.Open();

                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    resultSet.Add(new Phone()
                    {
                        ID = Convert.ToInt32(reader["id"]),
                        ContactID = Convert.ToInt32(reader["contact_id"]),
                        PhoneNumber = Convert.ToString(reader["phone"])
                    });

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Database operation Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1);
            }
            finally
            {
                this.conn.Close();
            }

            return resultSet;
        }

        private void PersistContact(Contact contact)
        {
            OleDbCommand cmd = new OleDbCommand();
            if (contact.ID > 0)
            {
                cmd.CommandText = @"
UPDATE contacts SET
  first_name = @first_name,
  last_name = @last_name
WHERE
  id = @id
";
                OleDbParameter param = cmd.CreateParameter();
                param.ParameterName = "@first_name";
                param.Value = contact.FirstName;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@last_name";
                param.Value = contact.LastName;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@id";
                param.Value = contact.ID;
                cmd.Parameters.Add(param);
            }
            else
            {
                cmd.CommandText = @"
INSERT INTO contacts (
  first_name,
  last_name
)
VALUES (
  @first_name,
  @last_name
)
";
                OleDbParameter param = cmd.CreateParameter();
                param.ParameterName = "@first_name";
                param.Value = contact.FirstName;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@last_name";
                param.Value = contact.LastName;
                cmd.Parameters.Add(param);
            }

            try
            {
                this.conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Contact was NOT persisted correctly." + Environment.NewLine + ex.Message, "Persistance failed!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                this.conn.Close();
            }
        }
        private void DeleteContact(Contact contact)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = @"
DELETE FROM contacts
WHERE
  id = @id
";
            OleDbParameter param = cmd.CreateParameter();
            param.ParameterName = "@id";
            param.Value = contact.ID;
            cmd.Parameters.Add(param);

            try
            {
                this.conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Contact was NOT deleted correctly." + Environment.NewLine + ex.Message, "Delete failed!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                this.conn.Close();
            }
        }

        private void PersistPhone(Phone phone)
        {
            OleDbCommand cmd = new OleDbCommand();
            if (phone.ID > 0)
            {
                cmd.CommandText = @"
UPDATE contact_phones SET
  phone = @phone
WHERE
  id = @id
";
                OleDbParameter param = cmd.CreateParameter();
                param.ParameterName = "@phone";
                param.Value = phone.PhoneNumber;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@id";
                param.Value = phone.ID;
                cmd.Parameters.Add(param);
            }
            else
            {
                cmd.CommandText = @"
INSERT INTO contact_phones (
  contact_id,
  phone
)
VALUES (
  @contact_id,
  @phone
)
";
                OleDbParameter param = cmd.CreateParameter();
                param.ParameterName = "@contact_id";
                param.Value = phone.ContactID;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@phone";
                param.Value = phone.PhoneNumber;
                cmd.Parameters.Add(param);
            }

            try
            {
                this.conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phone was NOT persisted correctly." + Environment.NewLine + ex.Message, "Persistance failed!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                this.conn.Close();
            }
        }
        private void DeletePhone(Phone phone)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = @"
DELETE FROM contact_phones
WHERE
  id = @id
";
            OleDbParameter param = cmd.CreateParameter();
            param.ParameterName = "@id";
            param.Value = phone.ID;
            cmd.Parameters.Add(param);

            try
            {
                this.conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phone was NOT deleted correctly." + Environment.NewLine + ex.Message, "Delete failed!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                this.conn.Close();
            }
        }

        private void BindControls()
        {
            lbContacts.Items.Clear();
            lbPhones.Items.Clear();

            foreach (Contact contact in this.GetContacts())
                this.lbContacts.Items.Add(contact);

            if (this.lbContacts.Items.Count > 0)
                this.lbContacts.SelectedIndex = 0;

            this.AdjustControlsAvailability();
        }

        #endregion

        #region Event Handlers

        private void frmPhonebook_Load(object sender, EventArgs e)
        {
            this.BindControls();
        }

        private void lbContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbContacts.SelectedItem == null)
                return;

            this.lbPhones.Items.Clear();

            Contact contact = (Contact)this.lbContacts.SelectedItem;
            foreach (Phone phone in contact.Phones)
                this.lbPhones.Items.Add(phone);

            if (lbPhones.Items.Count > 0)
                this.lbPhones.SelectedIndex = 0;

            this.AdjustControlsAvailability();
        }

        private void tsbtnContactsNew_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            frmEditContact frmEditContact = new frmEditContact(contact);
            if (frmEditContact.ShowDialog() == DialogResult.OK)
            {
                this.PersistContact(contact);
                this.BindControls();
            }
        }
        private void tsbtnContactsEdit_Click(object sender, EventArgs e)
        {
            if (this.lbContacts.SelectedItem == null)
                return;

            Contact contact = (Contact)this.lbContacts.SelectedItem;
            frmEditContact frmEditContact = new frmEditContact(contact);
            if (frmEditContact.ShowDialog() == DialogResult.OK)
            {
                this.PersistContact(contact);
                this.BindControls();
            }
        }
        private void tsbtnContactsDelete_Click(object sender, EventArgs e)
        {
            if (this.lbContacts.SelectedItem == null)
                return;

            Contact contact = (Contact)this.lbContacts.SelectedItem;
            if (MessageBox.Show("Delete contact?", "Delete contact", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.DeleteContact(contact);
                this.BindControls();
            }
        }

        private void tsbtnPhonesNew_Click(object sender, EventArgs e)
        {
            Contact contact = (Contact)lbContacts.SelectedItem;

            Phone phone = new Phone();
            phone.ContactID = contact.ID;

            frmEditPhone frmEditPhone = new frmEditPhone(phone);
            if (frmEditPhone.ShowDialog() == DialogResult.OK)
            {
                this.PersistPhone(phone);
                this.BindControls();
            }
        }
        private void tsbtnPhonesEdit_Click(object sender, EventArgs e)
        {
            if (this.lbPhones.SelectedItem == null)
                return;

            Phone phone = (Phone)this.lbPhones.SelectedItem;
            frmEditPhone frmEditPhone = new frmEditPhone(phone);
            if (frmEditPhone.ShowDialog() == DialogResult.OK)
            {
                this.PersistPhone(phone);
                this.BindControls();
            }
        }
        private void tsbtnPhonesDelete_Click(object sender, EventArgs e)
        {
            if (this.lbPhones.SelectedItem == null)
                return;

            Phone phone = (Phone)this.lbPhones.SelectedItem;
            if (MessageBox.Show("Delete phone?", "Delete phone", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.DeletePhone(phone);
                this.BindControls();
            }
        }

        #endregion
    }
}
