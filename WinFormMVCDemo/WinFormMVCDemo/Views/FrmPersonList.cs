using System;
using System.Windows.Forms;
using WinFormMVCDemo.Controllers;

namespace WinFormMVCDemo.Views
{
    public partial class FrmPersonList : Form, IView
    {
        public Form MdiContainer { get; set; }
        private readonly IPersonController _personController;

        public FrmPersonList(IPersonController personController)
        {
            _personController = personController;

            InitializeComponent();
            RefreshData();
        }

        public void Display()
        {
            MdiParent = MdiContainer;
            Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IView view = _personController.AddPersonView();
            view.MdiContainer = MdiParent;
            view.Display();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            var personController = new PersonController();
            var personList = personController.GetPersons();

            personListView.Items.Clear();

            //ListViewItem[] itm = _personList.Select(x => new {x.Ref, x.Name, x.Age, x.Phone}).ToArray<ListViewItem>();

            foreach (var item in personList)
            {
                ListViewItem record = new ListViewItem(item.ID.ToString());
                record.SubItems.Add(item.Name);
                record.SubItems.Add(item.Age.ToString());
                record.SubItems.Add(item.Phone);
                personListView.Items.Add(record);
            }
        }
    }
}
