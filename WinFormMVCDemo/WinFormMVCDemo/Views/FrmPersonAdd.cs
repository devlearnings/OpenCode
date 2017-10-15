using System;
using System.ComponentModel;
using System.Windows.Forms;
using WinFormMVCDemo.Controllers;
using WinFormMVCDemo.Models;

namespace WinFormMVCDemo.Views
{
    public partial class FrmPersonAdd : Form, IView
    {
        public Form MdiContainer { get; set; }

        private readonly IPersonController _personController;
        private Person _person { get; }

        public FrmPersonAdd(IPersonController personController, Person person)
        {
            _person = person;
            _personController = personController;

            InitializeComponent();
            btnSave.Enabled = ValidateAll();
        }

        public void Display()
        {
            MdiParent = MdiContainer;
            Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _personController.AddPerson(_person);
            Close();
        }

        #region Control Validtion
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateName())
                _person.Name = textBox1.Text;

            btnSave.Enabled = ValidateAll();
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {

            if (ValidateAge())
                _person.Age = Int16.Parse(textBox2.Text);

            btnSave.Enabled = ValidateAll();
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (ValidatePhone())
                _person.Phone = textBox3.Text;

            btnSave.Enabled = ValidateAll();
        }
        #endregion

        #region Model Validation
        private bool ValidateAll()
        {
            if (!ValidateName())
                return false;

            if (!ValidateAge())
                return false;

            if (!ValidatePhone())
                return false;

            return true;
        }

        private bool ValidateName()
        {
            return textBox1.Text.Length != 0;
        }

        private bool ValidateAge()
        {
            return int.TryParse(textBox2.Text, out _);
        }

        private bool ValidatePhone()
        {
            return textBox3.Text.Length != 0;
        }
        #endregion

        #region Custom Events

        #endregion
    }
}
