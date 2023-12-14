namespace AmogusProgram
{
    partial class Form1
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
            picture = new PictureBox();
            button = new Button();
            lower = new Button();
            faster = new Button();
            upgrade = new Button();
            creditsGK = new Label();
            creditsPoke = new Label();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // picture
            // 
            picture.Image = Properties.Resources.Rainbow1;
            picture.Location = new Point(186, 111);
            picture.Name = "picture";
            picture.Size = new Size(400, 400);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.TabIndex = 0;
            picture.TabStop = false;
            // 
            // button
            // 
            button.Location = new Point(186, 82);
            button.Name = "button";
            button.Size = new Size(125, 23);
            button.TabIndex = 1;
            button.Text = "Play";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // lower
            // 
            lower.FlatStyle = FlatStyle.Popup;
            lower.Location = new Point(317, 82);
            lower.Name = "lower";
            lower.Size = new Size(23, 23);
            lower.TabIndex = 2;
            lower.Text = "<";
            lower.UseVisualStyleBackColor = true;
            lower.Click += lower_Click;
            // 
            // faster
            // 
            faster.FlatStyle = FlatStyle.Popup;
            faster.Location = new Point(431, 82);
            faster.Name = "faster";
            faster.Size = new Size(23, 23);
            faster.TabIndex = 3;
            faster.Text = ">";
            faster.UseVisualStyleBackColor = true;
            faster.Click += faster_Click;
            // 
            // upgrade
            // 
            upgrade.Location = new Point(460, 82);
            upgrade.Name = "upgrade";
            upgrade.Size = new Size(125, 23);
            upgrade.TabIndex = 4;
            upgrade.Text = "Rave Mode";
            upgrade.UseVisualStyleBackColor = true;
            upgrade.Click += upgrade_Click;
            // 
            // creditsGK
            // 
            creditsGK.AutoSize = true;
            creditsGK.Location = new Point(331, 555);
            creditsGK.Name = "creditsGK";
            creditsGK.Size = new Size(112, 15);
            creditsGK.TabIndex = 5;
            creditsGK.Text = "Coded by Growl Kat";
            // 
            // creditsPoke
            // 
            creditsPoke.AutoSize = true;
            creditsPoke.Location = new Point(301, 579);
            creditsPoke.Name = "creditsPoke";
            creditsPoke.Size = new Size(176, 15);
            creditsPoke.TabIndex = 6;
            creditsPoke.Text = "Sprites by Pokeloid the Pyrscout";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 638);
            Controls.Add(creditsPoke);
            Controls.Add(creditsGK);
            Controls.Add(upgrade);
            Controls.Add(faster);
            Controls.Add(lower);
            Controls.Add(button);
            Controls.Add(picture);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picture;
        private Button button;
        private Button lower;
        private Button faster;
        private Button upgrade;
        private Label creditsGK;
        private Label creditsPoke;
    }
}