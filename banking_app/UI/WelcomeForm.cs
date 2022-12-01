using banking_app.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking_app.UI
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        public void FillData(UserDTO userDTO)
        {
            txtName.Text = userDTO.FullName;
            txtEmail.Text = userDTO.Email;
            txtSIN.Text = userDTO.SIN.ToString();
            txtPhone.Text = userDTO.PhoneNumber;
            txtDate.Text = userDTO.RegistrationDate.ToString();
        }

        public void ChangeProperty()
        {
            if(txtName.ReadOnly == false)
            {
                txtName.ReadOnly = true;
            } else
            {
                txtName.ReadOnly = false;
            }

            if (txtEmail.ReadOnly == false)
            {
                txtEmail.ReadOnly = true;
            }
            else
            {
                txtEmail.ReadOnly = false;
            }

            if (txtSIN.ReadOnly == false)
            {
                txtSIN.ReadOnly = true;
            }
            else
            {
                txtSIN.ReadOnly = false;
            }

            if (txtPhone.ReadOnly == false)
            {
                txtPhone.ReadOnly = true;
            }
            else
            {
                txtPhone.ReadOnly = false;
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeProperty();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeProperty();
        }
    }
}
