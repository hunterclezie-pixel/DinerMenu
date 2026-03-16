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

        private void SoupButton_Click(object sender, EventArgs e)
        {
            DinerMenuLabel.Text = "Soup of the Day: Chicken Noodle Soup";
        }

        private void ChefSpecialButton_Click(object sender, EventArgs e)
        {
            DinerMenuLabel.Text = "Chef's Special: Chicken Fried Steak with Mashed Potatoes and Gravy";
        }

        private void DailyFishButton_Click(object sender, EventArgs e)
        {
            DinerMenuLabel.Text = "Daily Fish: Fried Catfish with Hush Puppies and Coleslaw";
        }
    }
}
