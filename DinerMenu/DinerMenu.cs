/*
Hunter Clezie 
Spring 2026
RCET2265
DinerMenu
github url: https://github.com/hunterclezie-pixel/DinerMenu.git
*/
namespace DinerMenu
{
    /* Todo List:
         * [x] A label at the top with your diner's name
         * [x] Buttons to display: Soup of the Day, Chef's Special, Daily Fish
         * [x] A label to display the appropriate special depending on the button pressed
         * [x] Properly named controls (e.g., SoupButton, SaladButton, FishButton, ExitButton, DinerNameLabel, DisplaySpecialLabel)
         * [x] Exit button to close the application */

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
            DinerMenuLabel.Text = "";
        }

        //Event Handlers below here --------------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SoupButton_Click(object sender, EventArgs e)
        {
            //This button displays the soup of the day.
            DinerMenuLabel.Text = "Soup of the Day: Lobster Bisque – " + "\n" +
                "\n A velvety, slow-simmered classic crafted from roasted lobster shells, " +
                "aromatic vegetables, and a touch of cream. " +
                "Finished with tender lobster pieces and delicate herbs for a rich, " +
                "buttery bowl of coastal comfort.";
        }

        private void ChefSpecialButton_Click(object sender, EventArgs e)
        {
            //This button displays the chef's special.
            DinerMenuLabel.Text = "Chef's Special: Fire-Seared Garlic Butter Steak -" + "\n" +
                "\nA perfectly seared steak basted in garlic herb butter, " +
                "served alongside roasted seasonal vegetables and creamy mashed potatoes. " +
                "Finished with a light red wine reduction for a rich and satisfying entrée.";
        }

        private void DailyFishButton_Click(object sender, EventArgs e)
        {
            //This button displays the daily fish.
            DinerMenuLabel.Text = "Daily Fish: Fresh Grilled Swordfish – " + "\n" +
                "\nThick-cut swordfish steak, expertly grilled and finished with lemon herb butter. " +
                "Served tender and flaky with " +
                "bright citrus notes that highlight the fish’s naturally bold flavor.";
        }
    }
}
