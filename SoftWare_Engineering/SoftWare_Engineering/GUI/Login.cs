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
    public partial class Login : Form
    {
        MyContext context = new MyContext();
        public Login()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = context.Users.Where(p => p.Email == txtEmail.Text & p.Pass == txtpassword.Text).FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("Email or Password not ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Main form = new Main(user);
            this.Hide();
            form.ShowDialog();
           // this.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Hide();
            form.ShowDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
