namespace Notes__ {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SavePanel = new System.Windows.Forms.Panel();
            this.SaveAsHashConfirmButton = new System.Windows.Forms.Button();
            this.SaveConfirmButton = new System.Windows.Forms.Button();
            this.SaveInputTextBox = new System.Windows.Forms.TextBox();
            this.SavePanelLabel1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.NewWindowButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.TextArea = new System.Windows.Forms.RichTextBox();
            this.OpenPanel = new System.Windows.Forms.Panel();
            this.OpenHashConfirmButton = new System.Windows.Forms.Button();
            this.OpenConfirmButton = new System.Windows.Forms.Button();
            this.OpenInputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SavePanel.SuspendLayout();
            this.OpenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.OpenPanel);
            this.MainPanel.Controls.Add(this.ExitButton);
            this.MainPanel.Controls.Add(this.SavePanel);
            this.MainPanel.Controls.Add(this.SaveButton);
            this.MainPanel.Controls.Add(this.OpenButton);
            this.MainPanel.Controls.Add(this.NewWindowButton);
            this.MainPanel.Controls.Add(this.NewButton);
            this.MainPanel.Controls.Add(this.TextArea);
            this.MainPanel.Location = new System.Drawing.Point(1, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(799, 447);
            this.MainPanel.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(424, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(98, 33);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SavePanel
            // 
            this.SavePanel.Controls.Add(this.SaveAsHashConfirmButton);
            this.SavePanel.Controls.Add(this.SaveConfirmButton);
            this.SavePanel.Controls.Add(this.SaveInputTextBox);
            this.SavePanel.Controls.Add(this.SavePanelLabel1);
            this.SavePanel.Location = new System.Drawing.Point(191, 133);
            this.SavePanel.Name = "SavePanel";
            this.SavePanel.Size = new System.Drawing.Size(415, 192);
            this.SavePanel.TabIndex = 5;
            // 
            // SaveAsHashConfirmButton
            // 
            this.SaveAsHashConfirmButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveAsHashConfirmButton.Location = new System.Drawing.Point(230, 118);
            this.SaveAsHashConfirmButton.Name = "SaveAsHashConfirmButton";
            this.SaveAsHashConfirmButton.Size = new System.Drawing.Size(112, 42);
            this.SaveAsHashConfirmButton.TabIndex = 3;
            this.SaveAsHashConfirmButton.Text = "SAVE AS HASHED TEXT";
            this.SaveAsHashConfirmButton.UseVisualStyleBackColor = true;
            this.SaveAsHashConfirmButton.Click += new System.EventHandler(this.SaveAsHashConfirmButton_Click);
            // 
            // SaveConfirmButton
            // 
            this.SaveConfirmButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveConfirmButton.Location = new System.Drawing.Point(72, 118);
            this.SaveConfirmButton.Name = "SaveConfirmButton";
            this.SaveConfirmButton.Size = new System.Drawing.Size(112, 42);
            this.SaveConfirmButton.TabIndex = 2;
            this.SaveConfirmButton.Text = "SAVE";
            this.SaveConfirmButton.UseVisualStyleBackColor = true;
            this.SaveConfirmButton.Click += new System.EventHandler(this.SaveConfirmButton_Click);
            // 
            // SaveInputTextBox
            // 
            this.SaveInputTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SaveInputTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveInputTextBox.ForeColor = System.Drawing.Color.Black;
            this.SaveInputTextBox.Location = new System.Drawing.Point(21, 56);
            this.SaveInputTextBox.Multiline = true;
            this.SaveInputTextBox.Name = "SaveInputTextBox";
            this.SaveInputTextBox.Size = new System.Drawing.Size(375, 36);
            this.SaveInputTextBox.TabIndex = 1;
            // 
            // SavePanelLabel1
            // 
            this.SavePanelLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SavePanelLabel1.Location = new System.Drawing.Point(18, 16);
            this.SavePanelLabel1.Name = "SavePanelLabel1";
            this.SavePanelLabel1.Size = new System.Drawing.Size(186, 37);
            this.SavePanelLabel1.TabIndex = 0;
            this.SavePanelLabel1.Text = "Name of the note:";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.Location = new System.Drawing.Point(216, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(98, 33);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenButton.Location = new System.Drawing.Point(320, 3);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(98, 33);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // NewWindowButton
            // 
            this.NewWindowButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewWindowButton.Location = new System.Drawing.Point(112, 3);
            this.NewWindowButton.Name = "NewWindowButton";
            this.NewWindowButton.Size = new System.Drawing.Size(98, 33);
            this.NewWindowButton.TabIndex = 2;
            this.NewWindowButton.Text = "New Window";
            this.NewWindowButton.UseVisualStyleBackColor = true;
            this.NewWindowButton.Click += new System.EventHandler(this.NewWindowButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewButton.Location = new System.Drawing.Point(8, 3);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(98, 33);
            this.NewButton.TabIndex = 1;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // TextArea
            // 
            this.TextArea.BackColor = System.Drawing.SystemColors.Menu;
            this.TextArea.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TextArea.Location = new System.Drawing.Point(8, 42);
            this.TextArea.Name = "TextArea";
            this.TextArea.Size = new System.Drawing.Size(779, 394);
            this.TextArea.TabIndex = 0;
            this.TextArea.Text = "";
            // 
            // OpenPanel
            // 
            this.OpenPanel.Controls.Add(this.OpenHashConfirmButton);
            this.OpenPanel.Controls.Add(this.OpenConfirmButton);
            this.OpenPanel.Controls.Add(this.OpenInputTextBox);
            this.OpenPanel.Controls.Add(this.label1);
            this.OpenPanel.Location = new System.Drawing.Point(191, 133);
            this.OpenPanel.Name = "OpenPanel";
            this.OpenPanel.Size = new System.Drawing.Size(415, 192);
            this.OpenPanel.TabIndex = 7;
            // 
            // OpenHashConfirmButton
            // 
            this.OpenHashConfirmButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenHashConfirmButton.Location = new System.Drawing.Point(230, 118);
            this.OpenHashConfirmButton.Name = "OpenHashConfirmButton";
            this.OpenHashConfirmButton.Size = new System.Drawing.Size(112, 42);
            this.OpenHashConfirmButton.TabIndex = 3;
            this.OpenHashConfirmButton.Text = "OPEN HASHED TEXT";
            this.OpenHashConfirmButton.UseVisualStyleBackColor = true;
            this.OpenHashConfirmButton.Click += new System.EventHandler(this.OpenHashConfirmButton_Click);
            // 
            // OpenConfirmButton
            // 
            this.OpenConfirmButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenConfirmButton.Location = new System.Drawing.Point(72, 118);
            this.OpenConfirmButton.Name = "OpenConfirmButton";
            this.OpenConfirmButton.Size = new System.Drawing.Size(112, 42);
            this.OpenConfirmButton.TabIndex = 2;
            this.OpenConfirmButton.Text = "OPEN";
            this.OpenConfirmButton.UseVisualStyleBackColor = true;
            this.OpenConfirmButton.Click += new System.EventHandler(this.OpenConfirmButton_Click);
            // 
            // OpenInputTextBox
            // 
            this.OpenInputTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.OpenInputTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenInputTextBox.ForeColor = System.Drawing.Color.Black;
            this.OpenInputTextBox.Location = new System.Drawing.Point(21, 56);
            this.OpenInputTextBox.Multiline = true;
            this.OpenInputTextBox.Name = "OpenInputTextBox";
            this.OpenInputTextBox.Size = new System.Drawing.Size(375, 36);
            this.OpenInputTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the note:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notes++";
            this.MainPanel.ResumeLayout(false);
            this.SavePanel.ResumeLayout(false);
            this.SavePanel.PerformLayout();
            this.OpenPanel.ResumeLayout(false);
            this.OpenPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private RichTextBox TextArea;
        private Button NewButton;
        private Button SaveButton;
        private Button OpenButton;
        private Button NewWindowButton;
        private Panel SavePanel;
        private Label SavePanelLabel1;
        private TextBox SaveInputTextBox;
        private Button SaveConfirmButton;
        private Button ExitButton;
        private Button SaveAsHashConfirmButton;
        private Panel OpenPanel;
        private Button OpenHashConfirmButton;
        private Button OpenConfirmButton;
        private TextBox OpenInputTextBox;
        private Label label1;
    }
}