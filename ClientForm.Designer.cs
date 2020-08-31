namespace Raiden
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorList = new System.Windows.Forms.ComboBox();
            this.TaskButton = new System.Windows.Forms.Button();
            this.ImpostorsLabel = new System.Windows.Forms.Label();
            this.CanMoveCheckBox = new System.Windows.Forms.CheckBox();
            this.CooldownCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(15, 259);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputTextBox.Size = new System.Drawing.Size(465, 59);
            this.OutputTextBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Raiden.Properties.Resources.icon;
            this.pictureBox1.Image = global::Raiden.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(189, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Distribution of this software without permission from the developer is prohibited" +
    ".";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ColorList
            // 
            this.ColorList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorList.FormattingEnabled = true;
            this.ColorList.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Pink",
            "Orange",
            "Yellow",
            "Black",
            "White",
            "Purple",
            "Brown",
            "Cyan",
            "Lime"});
            this.ColorList.Location = new System.Drawing.Point(15, 145);
            this.ColorList.Name = "ColorList";
            this.ColorList.Size = new System.Drawing.Size(121, 21);
            this.ColorList.TabIndex = 3;
            // 
            // TaskButton
            // 
            this.TaskButton.Location = new System.Drawing.Point(142, 145);
            this.TaskButton.Name = "TaskButton";
            this.TaskButton.Size = new System.Drawing.Size(91, 23);
            this.TaskButton.TabIndex = 4;
            this.TaskButton.Text = "Complete Tasks";
            this.TaskButton.UseVisualStyleBackColor = true;
            this.TaskButton.Click += new System.EventHandler(this.TaskButton_Click);
            // 
            // ImpostorsLabel
            // 
            this.ImpostorsLabel.AutoSize = true;
            this.ImpostorsLabel.Location = new System.Drawing.Point(12, 243);
            this.ImpostorsLabel.Name = "ImpostorsLabel";
            this.ImpostorsLabel.Size = new System.Drawing.Size(118, 13);
            this.ImpostorsLabel.TabIndex = 5;
            this.ImpostorsLabel.Text = "There are no impostors.";
            this.ImpostorsLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // CanMoveCheckBox
            // 
            this.CanMoveCheckBox.AutoSize = true;
            this.CanMoveCheckBox.Checked = true;
            this.CanMoveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CanMoveCheckBox.Location = new System.Drawing.Point(15, 174);
            this.CanMoveCheckBox.Name = "CanMoveCheckBox";
            this.CanMoveCheckBox.Size = new System.Drawing.Size(248, 17);
            this.CanMoveCheckBox.TabIndex = 7;
            this.CanMoveCheckBox.Text = "Keep movement restricted in menus/minigames";
            this.CanMoveCheckBox.UseVisualStyleBackColor = true;
            this.CanMoveCheckBox.CheckedChanged += new System.EventHandler(this.CanMoveCheckBox_CheckedChanged);
            // 
            // CooldownCheckBox
            // 
            this.CooldownCheckBox.AutoSize = true;
            this.CooldownCheckBox.Checked = true;
            this.CooldownCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CooldownCheckBox.Location = new System.Drawing.Point(15, 197);
            this.CooldownCheckBox.Name = "CooldownCheckBox";
            this.CooldownCheckBox.Size = new System.Drawing.Size(130, 17);
            this.CooldownCheckBox.TabIndex = 8;
            this.CooldownCheckBox.Text = "Keep kill cooldown on";
            this.CooldownCheckBox.UseVisualStyleBackColor = true;
            this.CooldownCheckBox.CheckedChanged += new System.EventHandler(this.CooldownCheckBox_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(276, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 52);
            this.label2.TabIndex = 9;
            this.label2.Text = "Activating hacks while not being in-game may result in a crash.";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(499, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CooldownCheckBox);
            this.Controls.Add(this.CanMoveCheckBox);
            this.Controls.Add(this.ImpostorsLabel);
            this.Controls.Add(this.TaskButton);
            this.Controls.Add(this.ColorList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OutputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientForm";
            this.Text = "Raiden";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ColorList;
        private System.Windows.Forms.Button TaskButton;
        private System.Windows.Forms.Label ImpostorsLabel;
        private System.Windows.Forms.CheckBox CanMoveCheckBox;
        private System.Windows.Forms.CheckBox CooldownCheckBox;
        private System.Windows.Forms.Label label2;
    }
}

