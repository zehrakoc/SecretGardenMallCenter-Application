using SecretGarden.BLL.Service;
using System;
using System.Windows.Forms;

namespace SecretGarden.UI.Views.Manager
{
    public partial class SignInForm : Form
    {
        private readonly DataService service = new DataService();

        public SignInForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var user = TxtUserName.Text;
            var pwd = TxtPassword.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pwd))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş geçilemez ");
            }
            else if (service.UnitOfWork.Managers.CheckUserNameAndPassword(user, pwd))
            {
                var managerForm = new ManagerForm();
                managerForm.Show();
                this.Close();
            }
            else
                MessageBox.Show("Kullanıcı adı veya şifre yanlış ");
        }
    }
}
