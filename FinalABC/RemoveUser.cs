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
    public partial class RemoveUser : MetroFramework.Forms.MetroForm
    {
        public RemoveUser()
        {
            InitializeComponent();
            materialLabel7.Text = DateTime.Today.ToLongDateString();
        }
    }
}
