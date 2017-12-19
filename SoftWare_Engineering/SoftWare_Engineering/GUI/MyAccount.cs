using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftWare_Engineering.Data;

namespace SoftWare_Engineering.GUI
{
    public partial class MyAccount : Form
    {
        MyContext context = new MyContext();
        User user = new User();
        public MyAccount(User u)
        {
            user = u;
            InitializeComponent();
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            txtEmail.Enabled = false;
            txtEmail.Text = user.Email;
            txtpassword.Text = user.Pass;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do you want edit your Account?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dr)
                {
                    User myAcc = context.Users.Find(txtEmail.Text);
                    myAcc.Pass = txtpassword.Text;
                    context.SaveChanges();
                    MessageBox.Show("Done");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Main main = new Main(user);
            //main.Show();
        }
    }
}
