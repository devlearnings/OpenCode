using System.Windows.Forms;

namespace WinFormMVCDemo.Views
{
    public interface IView
    {
        Form MdiContainer { get; set; }

        void Display();
    }
}