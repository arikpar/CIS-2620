using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleAdvertisement
{
    public partial class GreenvilleAdvertisement : Form
    {
        public GreenvilleAdvertisement()
        {
            InitializeComponent();
        }

        private void detailsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (detailsCheckBox.Checked)
            {
                GreenvilleEntryDetailsForm detailsForm = new GreenvilleEntryDetailsForm();
                detailsForm.ShowDialog();
                detailsCheckBox.CheckState = CheckState.Unchecked;
            }
        }
    }
}
