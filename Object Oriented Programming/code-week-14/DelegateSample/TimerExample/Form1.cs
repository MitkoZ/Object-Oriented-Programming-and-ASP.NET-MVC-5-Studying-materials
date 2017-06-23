using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerExample
{
    public partial class Form1 : Form
    {
        UserCollection users = new UserCollection();
        public Form1()
        {
            InitializeComponent();
            users.UserAdded += new Action<User>(UserAdded);
        }

        public void UserAdded(User user)
        {
            MessageBox.Show(user.Username + " was added!");
        }

        public void ShowMessage()
        {
            MessageBox.Show("You called?!");
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)sender).Name);

            //ShowMessage();
            MyDelegate dlg = new MyDelegate(ShowMessage);
            dlg();

            CalculateInts calc = new CalculateInts(Sum);
            int result = calc(10, 5);
            MessageBox.Show(result.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Username = textBox1.Text,
                Password = textBox2.Text
            };

            users.Add(user);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
