using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalABC
{
    public partial class AdminHome : MetroFramework.Forms.MetroForm
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAccount ca = new CreateAccount();
            ca.Show();
        }

        private void searchUpdateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCustomer uc = new UpdateCustomer();
            uc.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAccount ca = new CloseAccount();
            ca.Show();
        }

        private void allUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void createUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateUser cu = new CreateUser();
            cu.Show();
        }
    }
}
