using System;
using System.Windows.Forms;
using Autofac;
using WinFormMVCDemo.Controllers;

namespace WinFormMVCDemo.Views
{
    public partial class FrmHome : Form
    {
        private readonly IHomeController _homeController;

        public FrmHome()
        {
            _homeController = DependencyContainer.Container.Resolve<IHomeController>();
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            var view = _homeController.AllPersonView();
            view.MdiContainer = this;
            view.Display();
        }
    }
}
