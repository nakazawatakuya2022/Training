using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umineko
{
    public partial class FormReturn : Form
    {
        private int _bookId;
        public FormReturn(int bookId)
        {
            InitializeComponent();
            _bookId = bookId;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
