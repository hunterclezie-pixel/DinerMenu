namespace DinerMenu
{
    partial class DinerMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SoupButton = new Button();
            ChefSpecialButton = new Button();
            DailyFishButton = new Button();
            ExitButton = new Button();
            RestaurantNameLabel = new Label();
            DinerMenuLabel = new Label();
            MainToolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // SoupButton
            // 
            SoupButton.Location = new Point(12, 382);
            SoupButton.Name = "SoupButton";
            SoupButton.Size = new Size(150, 56);
            SoupButton.TabIndex = 0;
            SoupButton.Text = "Soup of The Day";
            MainToolTip.SetToolTip(SoupButton, "Soup Button");
            SoupButton.UseVisualStyleBackColor = true;
            SoupButton.Click += SoupButton_Click;
            // 
            // ChefSpecialButton
            // 
            ChefSpecialButton.Location = new Point(168, 382);
            ChefSpecialButton.Name = "ChefSpecialButton";
            ChefSpecialButton.Size = new Size(150, 56);
            ChefSpecialButton.TabIndex = 1;
            ChefSpecialButton.Text = "Chef's Special";
            MainToolTip.SetToolTip(ChefSpecialButton, "Chef's Special Button");
            ChefSpecialButton.UseVisualStyleBackColor = true;
            ChefSpecialButton.Click += ChefSpecialButton_Click;
            // 
            // DailyFishButton
            // 
            DailyFishButton.Location = new Point(324, 382);
            DailyFishButton.Name = "DailyFishButton";
            DailyFishButton.Size = new Size(150, 56);
            DailyFishButton.TabIndex = 2;
            DailyFishButton.Text = "Daily Fish";
            MainToolTip.SetToolTip(DailyFishButton, "Fresh Fish Button");
            DailyFishButton.UseVisualStyleBackColor = true;
            DailyFishButton.Click += DailyFishButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(638, 382);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(150, 56);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            MainToolTip.SetToolTip(ExitButton, "Exit Button");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // RestaurantNameLabel
            // 
            RestaurantNameLabel.AutoSize = true;
            RestaurantNameLabel.Font = new Font("Magneto", 25.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            RestaurantNameLabel.Location = new Point(180, 9);
            RestaurantNameLabel.Name = "RestaurantNameLabel";
            RestaurantNameLabel.Size = new Size(442, 53);
            RestaurantNameLabel.TabIndex = 4;
            RestaurantNameLabel.Text = "The Digital Diner";
            // 
            // DinerMenuLabel
            // 
            DinerMenuLabel.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            DinerMenuLabel.Location = new Point(180, 91);
            DinerMenuLabel.Name = "DinerMenuLabel";
            DinerMenuLabel.Size = new Size(442, 249);
            DinerMenuLabel.TabIndex = 5;
            DinerMenuLabel.Text = "label1";
            // 
            // DinerMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DinerMenuLabel);
            Controls.Add(RestaurantNameLabel);
            Controls.Add(ExitButton);
            Controls.Add(DailyFishButton);
            Controls.Add(ChefSpecialButton);
            Controls.Add(SoupButton);
            Name = "DinerMenuForm";
            Text = "Diner Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SoupButton;
        private Button ChefSpecialButton;
        private Button DailyFishButton;
        private Button ExitButton;
        private Label RestaurantNameLabel;
        private Label DinerMenuLabel;
        private ToolTip MainToolTip;
    }
}
