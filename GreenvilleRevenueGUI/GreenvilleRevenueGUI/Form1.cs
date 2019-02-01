//Arik Parenteau
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class GreenvilleRevenueGUI : Form
    {
        public GreenvilleRevenueGUI()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double ENTRY_FEE = 25;
            int numThisYear = Convert.ToInt32(thisYearTextBox.Text), 
                numLastYear = Convert.ToInt32(lastYearTextBox.Text);
            double revenue = ENTRY_FEE * numThisYear;
            bool moreContestantsThisYear = numThisYear > numLastYear;

            outputThisYearRevenue.Visible = true;
            outputThisYearRevenue.Text = String.Format("This Year's Expected Revenue: {0}",
                revenue.ToString("C"));
            outputMoreContestants.Visible = true;
            outputMoreContestants.Text = "There are more Contestants this year: " +
                moreContestantsThisYear;
        }
    }
}
