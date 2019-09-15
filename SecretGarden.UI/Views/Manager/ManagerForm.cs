using SecretGarden.BLL.Service;
using System;
using System.Windows.Forms;


namespace SecretGarden.UI.Views.Manager
{
    public partial class ManagerForm : Form
    {
        private readonly DataService service = new DataService();

        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            var forRent = service.UnitOfWork.Stores.Get(x => x.IsItHired == false);
            foreach (var item in forRent)
            {
                LbNotHired.Items.Add(item);
            }
            var notForRent = service.UnitOfWork.Stores.Get(x => x.IsItHired == true);
            foreach (var item in notForRent)
            {
                LbHired.Items.Add(item);
            }
        }

        private void BtnNewHired_Click(object sender, EventArgs e)
        {
            var NewStore = (Models.Entities.Store)LbNotHired.SelectedItem;

                NewStore.IsItHired = true;
                NewStore.Name = TxtNewHired.Text;
                service.UnitOfWork.Stores.Update(NewStore);
                LbNotHired.Items.Remove(NewStore);
                LbHired.Items.Add(NewStore);
                service.UnitOfWork.Save();

            TxtNewHired.Clear();
        }

        private void BtnNotHired_Click(object sender, EventArgs e)
        {
            var store = (Models.Entities.Store)LbHired.SelectedItem;
            
                store.IsItHired = false;
                store.Name = TxtNotHired.Text;
                service.UnitOfWork.Stores.Update(store);
                LbHired.Items.Remove(store);
                 LbNotHired.Items.Add(store);
                 service.UnitOfWork.Save();

            TxtNotHired.Clear();
            
        }

        private void BtnSingOut_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
