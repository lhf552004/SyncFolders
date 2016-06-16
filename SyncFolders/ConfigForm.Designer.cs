namespace SyncFolders
{
    partial class ConfigForm
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
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.TargetfolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SourcefolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SelectTargetFolderbutton = new System.Windows.Forms.Button();
            this.SelectSourceFolderButton = new System.Windows.Forms.Button();
            this.AddPairButton = new System.Windows.Forms.Button();
            this.TargetPathLabel = new System.Windows.Forms.Label();
            this.SourcePathLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PathPairlistView = new System.Windows.Forms.ListView();
            this.SourcePathColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TargetPathColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(328, 302);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(96, 59);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SelectTargetFolderbutton
            // 
            this.SelectTargetFolderbutton.Location = new System.Drawing.Point(84, 92);
            this.SelectTargetFolderbutton.Name = "SelectTargetFolderbutton";
            this.SelectTargetFolderbutton.Size = new System.Drawing.Size(129, 36);
            this.SelectTargetFolderbutton.TabIndex = 1;
            this.SelectTargetFolderbutton.Text = "Select Target Folder";
            this.SelectTargetFolderbutton.UseVisualStyleBackColor = true;
            this.SelectTargetFolderbutton.Click += new System.EventHandler(this.SelectTargetFolderbutton_Click);
            // 
            // SelectSourceFolderButton
            // 
            this.SelectSourceFolderButton.Location = new System.Drawing.Point(84, 12);
            this.SelectSourceFolderButton.Name = "SelectSourceFolderButton";
            this.SelectSourceFolderButton.Size = new System.Drawing.Size(129, 36);
            this.SelectSourceFolderButton.TabIndex = 1;
            this.SelectSourceFolderButton.Text = "Select Source Folder";
            this.SelectSourceFolderButton.UseVisualStyleBackColor = true;
            this.SelectSourceFolderButton.Click += new System.EventHandler(this.SelectSourceFolderButton_Click);
            // 
            // AddPairButton
            // 
            this.AddPairButton.Location = new System.Drawing.Point(84, 176);
            this.AddPairButton.Name = "AddPairButton";
            this.AddPairButton.Size = new System.Drawing.Size(129, 36);
            this.AddPairButton.TabIndex = 2;
            this.AddPairButton.Text = "Add";
            this.AddPairButton.UseVisualStyleBackColor = true;
            this.AddPairButton.Click += new System.EventHandler(this.AddPairButton_Click);
            // 
            // TargetPathLabel
            // 
            this.TargetPathLabel.AutoSize = true;
            this.TargetPathLabel.Location = new System.Drawing.Point(81, 131);
            this.TargetPathLabel.Name = "TargetPathLabel";
            this.TargetPathLabel.Size = new System.Drawing.Size(0, 13);
            this.TargetPathLabel.TabIndex = 3;
            // 
            // SourcePathLabel
            // 
            this.SourcePathLabel.AutoSize = true;
            this.SourcePathLabel.Location = new System.Drawing.Point(81, 51);
            this.SourcePathLabel.Name = "SourcePathLabel";
            this.SourcePathLabel.Size = new System.Drawing.Size(0, 13);
            this.SourcePathLabel.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PathPairlistView
            // 
            this.PathPairlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SourcePathColumnHeader,
            this.TargetPathColumnHeader});
            this.PathPairlistView.FullRowSelect = true;
            this.PathPairlistView.Location = new System.Drawing.Point(230, 12);
            this.PathPairlistView.Name = "PathPairlistView";
            this.PathPairlistView.Size = new System.Drawing.Size(353, 242);
            this.PathPairlistView.TabIndex = 4;
            this.PathPairlistView.UseCompatibleStateImageBehavior = false;
            this.PathPairlistView.View = System.Windows.Forms.View.Details;
            this.PathPairlistView.SelectedIndexChanged += new System.EventHandler(this.PathPairlistView_SelectedIndexChanged);
            // 
            // SourcePathColumnHeader
            // 
            this.SourcePathColumnHeader.Text = "SourcePath";
            this.SourcePathColumnHeader.Width = 166;
            // 
            // TargetPathColumnHeader
            // 
            this.TargetPathColumnHeader.Text = "TargetPath";
            this.TargetPathColumnHeader.Width = 166;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(619, 119);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 36);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 385);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.PathPairlistView);
            this.Controls.Add(this.SourcePathLabel);
            this.Controls.Add(this.TargetPathLabel);
            this.Controls.Add(this.AddPairButton);
            this.Controls.Add(this.SelectSourceFolderButton);
            this.Controls.Add(this.SelectTargetFolderbutton);
            this.Controls.Add(this.StartButton);
            this.Name = "ConfigForm";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.FolderBrowserDialog TargetfolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog SourcefolderBrowserDialog;
        private System.Windows.Forms.Button SelectTargetFolderbutton;
        private System.Windows.Forms.Button SelectSourceFolderButton;
        private System.Windows.Forms.Button AddPairButton;
        private System.Windows.Forms.Label TargetPathLabel;
        private System.Windows.Forms.Label SourcePathLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView PathPairlistView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ColumnHeader SourcePathColumnHeader;
        private System.Windows.Forms.ColumnHeader TargetPathColumnHeader;
    }
}

