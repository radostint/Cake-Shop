using CakeFactory_DP_CourseProject.Decorators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeFactory_DP_CourseProject
{
    public partial class MainScreen : Form
    {

        public MainScreen()
        {
            InitializeComponent();
            SelectedPanel.Height = buttonHome.Height;
            SelectedPanel.Top = buttonHome.Top;
            homeControl.BringToFront();

        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            SelectedPanel.Height = buttonHome.Height;
            SelectedPanel.Top = buttonHome.Top;
            homeControl.BringToFront();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            SelectedPanel.Height = buttonProducts.Height;
            SelectedPanel.Top = buttonProducts.Top;
            productsControl.BringToFront();
        }
    }
}
