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
            SoupButton = new Button();
            ChefSpecialButton = new Button();
            DailyFishButton = new Button();
            ExitButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // SoupButton
            // 
            SoupButton.Location = new Point(12, 382);
            SoupButton.Name = "SoupButton";
            SoupButton.Size = new Size(150, 56);
            SoupButton.TabIndex = 0;
            SoupButton.Text = "Soup of The Day";
            SoupButton.UseVisualStyleBackColor = true;
            // 
            // ChefSpecialButton
            // 
            ChefSpecialButton.Location = new Point(168, 382);
            ChefSpecialButton.Name = "ChefSpecialButton";
            ChefSpecialButton.Size = new Size(150, 56);
            ChefSpecialButton.TabIndex = 1;
            ChefSpecialButton.Text = "Chef's Special";
            ChefSpecialButton.UseVisualStyleBackColor = true;
            // 
            // DailyFishButton
            // 
            DailyFishButton.Location = new Point(324, 382);
            DailyFishButton.Name = "DailyFishButton";
            DailyFishButton.Size = new Size(150, 56);
            DailyFishButton.TabIndex = 2;
            DailyFishButton.Text = "Daily Fish";
            DailyFishButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(671, 382);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(117, 56);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // DinerMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
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
        private Label label1;
    }
}
