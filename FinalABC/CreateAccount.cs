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
    public partial class CreateAccount : MetroFramework.Forms.MetroForm
    {
        public CreateAccount()
        {
            InitializeComponent();
            materialLabel1.Text = DateTime.Today.ToLongDateString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
