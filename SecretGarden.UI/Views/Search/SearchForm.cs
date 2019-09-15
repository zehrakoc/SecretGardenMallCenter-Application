using SecretGarden.BLL.Service;
using SecretGarden.UI.Views.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretGarden.UI.Views.Search
{
    public partial class SearchForm : Form
    {
        private readonly DataService service = new DataService();
        public SearchForm()
        {
            InitializeComponent();
        }

        private void BtnManager_Click(object sender, EventArgs e)
        {
            var f1 = new SignInForm();
            
            f1.Show();

        }
        
        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            //var Filter = service.UnitOfWork.Stores.Get(x => x.Name == this.Text);
            //foreach (var item in Filter)
            //{
            //    LbStores.Items.Add(item);
            //}
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
           
        }
    }
}
