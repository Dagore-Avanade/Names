namespace Names
{
    partial class Names
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
            addBtn = new Button();
            txtName = new TextBox();
            namesListBox = new ListBox();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(140, 65);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(100, 23);
            addBtn.TabIndex = 0;
            addBtn.Text = "Add Name";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(140, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // namesListBox
            // 
            namesListBox.FormattingEnabled = true;
            namesListBox.ItemHeight = 15;
            namesListBox.Location = new Point(12, 35);
            namesListBox.Name = "namesListBox";
            namesListBox.Size = new Size(120, 94);
            namesListBox.TabIndex = 2;
            // 
            // Names
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 141);
            Controls.Add(namesListBox);
            Controls.Add(txtName);
            Controls.Add(addBtn);
            Name = "Names";
            Text = "Names";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private TextBox txtName;
        private ListBox namesListBox;
    }
}