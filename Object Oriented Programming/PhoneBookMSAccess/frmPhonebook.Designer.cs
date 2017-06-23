namespace PhoneBook
{
    partial class frmPhonebook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhonebook));
            this.lbContacts = new System.Windows.Forms.ListBox();
            this.tsContacts = new System.Windows.Forms.ToolStrip();
            this.tsbtnContactsNew = new System.Windows.Forms.ToolStripButton();
            this.tsbtnContactsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnContactsDelete = new System.Windows.Forms.ToolStripButton();
            this.lbPhones = new System.Windows.Forms.ListBox();
            this.tsPhones = new System.Windows.Forms.ToolStrip();
            this.tsbtnPhonesNew = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPhonesEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPhonesDelete = new System.Windows.Forms.ToolStripButton();
            this.tsContacts.SuspendLayout();
            this.tsPhones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbContacts
            // 
            this.lbContacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbContacts.FormattingEnabled = true;
            this.lbContacts.Location = new System.Drawing.Point(0, 25);
            this.lbContacts.Name = "lbContacts";
            this.lbContacts.Size = new System.Drawing.Size(313, 199);
            this.lbContacts.TabIndex = 0;
            this.lbContacts.SelectedIndexChanged += new System.EventHandler(this.lbContacts_SelectedIndexChanged);
            // 
            // tsContacts
            // 
            this.tsContacts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnContactsNew,
            this.tsbtnContactsEdit,
            this.tsbtnContactsDelete});
            this.tsContacts.Location = new System.Drawing.Point(0, 0);
            this.tsContacts.Name = "tsContacts";
            this.tsContacts.Size = new System.Drawing.Size(313, 25);
            this.tsContacts.TabIndex = 1;
            this.tsContacts.Text = "toolStrip1";
            // 
            // tsbtnContactsNew
            // 
            this.tsbtnContactsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnContactsNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnContactsNew.Image")));
            this.tsbtnContactsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnContactsNew.Name = "tsbtnContactsNew";
            this.tsbtnContactsNew.Size = new System.Drawing.Size(32, 22);
            this.tsbtnContactsNew.Text = "New";
            this.tsbtnContactsNew.Click += new System.EventHandler(this.tsbtnContactsNew_Click);
            // 
            // tsbtnContactsEdit
            // 
            this.tsbtnContactsEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnContactsEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnContactsEdit.Image")));
            this.tsbtnContactsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnContactsEdit.Name = "tsbtnContactsEdit";
            this.tsbtnContactsEdit.Size = new System.Drawing.Size(29, 22);
            this.tsbtnContactsEdit.Text = "Edit";
            this.tsbtnContactsEdit.Click += new System.EventHandler(this.tsbtnContactsEdit_Click);
            // 
            // tsbtnContactsDelete
            // 
            this.tsbtnContactsDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnContactsDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnContactsDelete.Image")));
            this.tsbtnContactsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnContactsDelete.Name = "tsbtnContactsDelete";
            this.tsbtnContactsDelete.Size = new System.Drawing.Size(42, 22);
            this.tsbtnContactsDelete.Text = "Delete";
            this.tsbtnContactsDelete.Click += new System.EventHandler(this.tsbtnContactsDelete_Click);
            // 
            // lbPhones
            // 
            this.lbPhones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPhones.FormattingEnabled = true;
            this.lbPhones.Location = new System.Drawing.Point(0, 249);
            this.lbPhones.Name = "lbPhones";
            this.lbPhones.Size = new System.Drawing.Size(313, 264);
            this.lbPhones.TabIndex = 2;
            // 
            // tsPhones
            // 
            this.tsPhones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnPhonesNew,
            this.tsbtnPhonesEdit,
            this.tsbtnPhonesDelete});
            this.tsPhones.Location = new System.Drawing.Point(0, 224);
            this.tsPhones.Name = "tsPhones";
            this.tsPhones.Size = new System.Drawing.Size(313, 25);
            this.tsPhones.TabIndex = 3;
            this.tsPhones.Text = "toolStrip1";
            // 
            // tsbtnPhonesNew
            // 
            this.tsbtnPhonesNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnPhonesNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPhonesNew.Image")));
            this.tsbtnPhonesNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPhonesNew.Name = "tsbtnPhonesNew";
            this.tsbtnPhonesNew.Size = new System.Drawing.Size(32, 22);
            this.tsbtnPhonesNew.Text = "New";
            this.tsbtnPhonesNew.Click += new System.EventHandler(this.tsbtnPhonesNew_Click);
            // 
            // tsbtnPhonesEdit
            // 
            this.tsbtnPhonesEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnPhonesEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPhonesEdit.Image")));
            this.tsbtnPhonesEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPhonesEdit.Name = "tsbtnPhonesEdit";
            this.tsbtnPhonesEdit.Size = new System.Drawing.Size(29, 22);
            this.tsbtnPhonesEdit.Text = "Edit";
            this.tsbtnPhonesEdit.Click += new System.EventHandler(this.tsbtnPhonesEdit_Click);
            // 
            // tsbtnPhonesDelete
            // 
            this.tsbtnPhonesDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnPhonesDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPhonesDelete.Image")));
            this.tsbtnPhonesDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPhonesDelete.Name = "tsbtnPhonesDelete";
            this.tsbtnPhonesDelete.Size = new System.Drawing.Size(42, 22);
            this.tsbtnPhonesDelete.Text = "Delete";
            this.tsbtnPhonesDelete.Click += new System.EventHandler(this.tsbtnPhonesDelete_Click);
            // 
            // frmPhonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 521);
            this.Controls.Add(this.lbPhones);
            this.Controls.Add(this.tsPhones);
            this.Controls.Add(this.lbContacts);
            this.Controls.Add(this.tsContacts);
            this.Name = "frmPhonebook";
            this.Text = "Phone Book";
            this.Load += new System.EventHandler(this.frmPhonebook_Load);
            this.tsContacts.ResumeLayout(false);
            this.tsContacts.PerformLayout();
            this.tsPhones.ResumeLayout(false);
            this.tsPhones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbContacts;
        private System.Windows.Forms.ToolStrip tsContacts;
        private System.Windows.Forms.ListBox lbPhones;
        private System.Windows.Forms.ToolStrip tsPhones;
        private System.Windows.Forms.ToolStripButton tsbtnContactsNew;
        private System.Windows.Forms.ToolStripButton tsbtnContactsEdit;
        private System.Windows.Forms.ToolStripButton tsbtnContactsDelete;
        private System.Windows.Forms.ToolStripButton tsbtnPhonesNew;
        private System.Windows.Forms.ToolStripButton tsbtnPhonesEdit;
        private System.Windows.Forms.ToolStripButton tsbtnPhonesDelete;
    }
}

