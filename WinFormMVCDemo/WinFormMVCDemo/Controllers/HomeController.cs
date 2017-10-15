using Autofac;
using WinFormMVCDemo.Views;

namespace WinFormMVCDemo.Controllers
{
    public class HomeController : IHomeController
    {
        public IView AllPersonView()
        {
            return new FrmPersonList(DependencyContainer.Container.Resolve<IPersonController>());
        }
    }
}
