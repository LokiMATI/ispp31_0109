using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class ReplaceForm : Form
    {
        public Action<string, string> ReplaceText;

        public ReplaceForm()
        {
            InitializeComponent();
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            ReplaceText?.Invoke(SearchTextBox.Text, ReplaceTextBox.Text);
        }
    }
}
