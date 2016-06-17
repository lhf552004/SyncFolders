namespace SyncFolders
{
    partial class Filters
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
            this.NewFilterLabel = new MaterialSkin.Controls.MaterialLabel();
            this.NewFilterText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AddButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.DeleteButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.FilterListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // NewFilterLabel
            // 
            this.NewFilterLabel.AutoSize = true;
            this.NewFilterLabel.Depth = 0;
            this.NewFilterLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.NewFilterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NewFilterLabel.Location = new System.Drawing.Point(27, 90);
            this.NewFilterLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NewFilterLabel.Name = "NewFilterLabel";
            this.NewFilterLabel.Size = new System.Drawing.Size(85, 19);
            this.NewFilterLabel.TabIndex = 1;
            this.NewFilterLabel.Text = "New Filter: ";
            // 
            // NewFilterText
            // 
            this.NewFilterText.Depth = 0;
            this.NewFilterText.Hint = "";
            this.NewFilterText.Location = new System.Drawing.Point(133, 90);
            this.NewFilterText.MaxLength = 32767;
            this.NewFilterText.MouseState = MaterialSkin.MouseState.HOVER;
            this.NewFilterText.Name = "NewFilterText";
            this.NewFilterText.PasswordChar = '\0';
            this.NewFilterText.SelectedText = "";
            this.NewFilterText.SelectionLength = 0;
            this.NewFilterText.SelectionStart = 0;
            this.NewFilterText.Size = new System.Drawing.Size(186, 23);
            this.NewFilterText.TabIndex = 2;
            this.NewFilterText.TabStop = false;
            this.NewFilterText.Text = "*.";
            this.NewFilterText.UseSystemPasswordChar = false;
            this.NewFilterText.Enter += new System.EventHandler(this.NewFilterText_Enter);
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Depth = 0;
            this.AddButton.Location = new System.Drawing.Point(342, 82);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddButton.Name = "AddButton";
            this.AddButton.Primary = false;
            this.AddButton.Size = new System.Drawing.Size(39, 36);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Depth = 0;
            this.DeleteButton.Location = new System.Drawing.Point(342, 150);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Primary = false;
            this.DeleteButton.Size = new System.Drawing.Size(60, 36);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FilterListView
            // 
            this.FilterListView.Location = new System.Drawing.Point(27, 133);
            this.FilterListView.Name = "FilterListView";
            this.FilterListView.Size = new System.Drawing.Size(292, 291);
            this.FilterListView.TabIndex = 5;
            this.FilterListView.UseCompatibleStateImageBehavior = false;
            // 
            // Filters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 455);
            this.Controls.Add(this.FilterListView);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NewFilterText);
            this.Controls.Add(this.NewFilterLabel);
            this.Name = "Filters";
            this.Text = "Filters";
            this.Load += new System.EventHandler(this.Filters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel NewFilterLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField NewFilterText;
        private MaterialSkin.Controls.MaterialFlatButton AddButton;
        private MaterialSkin.Controls.MaterialFlatButton DeleteButton;
        private System.Windows.Forms.ListView FilterListView;
    }
}