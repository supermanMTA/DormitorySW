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
using System.Text.RegularExpressions;

namespace SoftWare_Engineering.GUI
{
    public partial class Regis : Form
    {
        MyContext context = new MyContext();
        public Regis()
        {
            InitializeComponent();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (txtEmail.Text=="" || txtPassConfirm.Text=="" || txtpassword.Text=="")
            {
                MessageBox.Show("You have not entered enough information yet");

            }
            else if (txtpassword.Text.Length < 6)
            {
                MessageBox.Show("Password is not secure");
            }
            else if(Regex.Match(txtEmail.Text, @"(^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$)").Success == false)
            {
                MessageBox.Show("Invalid email");
            }
            else if (txtpassword.Text != txtPassConfirm.Text) { MessageBox.Show("Password incorrect"); }
            else
            {
                var u = context.Users.Find(txtEmail.Text);
                if (u != null)
                {
                    MessageBox.Show("Account already exists");
                }
                else
                {
                    user.Email = txtEmail.Text;
                    user.Pass = txtpassword.Text;
                    user.Object = 2;                        
                    context.Users.Add(user);
                    context.SaveChanges();
                    MessageBox.Show("Done!");
                    this.Hide();
                    Main main = new Main();
                    main.Show();

                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Main main = new Main();            
            this.Hide();
            main.ShowDialog();           
        }
    }
}
