/*
Hunter Clezie 
Spring 2026
RCET2265
DinerMenu
github url: https://github.com/hunterclezie-pixel/DinerMenu.git
*/
namespace DinerMenu
{
    public partial class DinerMenuForm : Form
    {
        public DinerMenuForm()
        {
            InitializeComponent();
            SetDefaults();
        }

        //Custom Methids below here --------------------------------------------------------------

        void SetDefaults()
        {

        }

        //Event Handlers below here --------------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
