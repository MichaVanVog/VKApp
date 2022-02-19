namespace VKApp
{
    partial class Vkontakte
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
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.MakeRequestButton = new System.Windows.Forms.Button();
            this.ResponseRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.GroupNameLabel = new System.Windows.Forms.Label();
            this.UserDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTextBox.Location = new System.Drawing.Point(12, 12);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(1063, 27);
            this.IdTextBox.TabIndex = 0;
            this.IdTextBox.Text = "pivnayakorowa";
            // 
            // MakeRequestButton
            // 
            this.MakeRequestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeRequestButton.Location = new System.Drawing.Point(1080, 12);
            this.MakeRequestButton.Name = "MakeRequestButton";
            this.MakeRequestButton.Size = new System.Drawing.Size(169, 27);
            this.MakeRequestButton.TabIndex = 1;
            this.MakeRequestButton.Text = "Сделать запрос";
            this.MakeRequestButton.UseVisualStyleBackColor = true;
            this.MakeRequestButton.Click += new System.EventHandler(this.MakeRequestButton_Click);
            // 
            // ResponseRichTextBox
            // 
            this.ResponseRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResponseRichTextBox.Location = new System.Drawing.Point(646, 76);
            this.ResponseRichTextBox.Name = "ResponseRichTextBox";
            this.ResponseRichTextBox.Size = new System.Drawing.Size(603, 472);
            this.ResponseRichTextBox.TabIndex = 2;
            this.ResponseRichTextBox.Text = "";
            // 
            // AvatarPictureBox
            // 
            this.AvatarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvatarPictureBox.Location = new System.Drawing.Point(12, 76);
            this.AvatarPictureBox.Name = "AvatarPictureBox";
            this.AvatarPictureBox.Size = new System.Drawing.Size(628, 472);
            this.AvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AvatarPictureBox.TabIndex = 3;
            this.AvatarPictureBox.TabStop = false;
            // 
            // GroupNameLabel
            // 
            this.GroupNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupNameLabel.AutoSize = true;
            this.GroupNameLabel.Location = new System.Drawing.Point(12, 48);
            this.GroupNameLabel.Name = "GroupNameLabel";
            this.GroupNameLabel.Size = new System.Drawing.Size(126, 20);
            this.GroupNameLabel.TabIndex = 4;
            this.GroupNameLabel.Text = "GroupNameLabel";
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGridView.Location = new System.Drawing.Point(12, 554);
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.RowHeadersWidth = 51;
            this.UserDataGridView.RowTemplate.Height = 29;
            this.UserDataGridView.Size = new System.Drawing.Size(628, 446);
            this.UserDataGridView.TabIndex = 5;
            // 
            // Vkontakte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 1012);
            this.Controls.Add(this.UserDataGridView);
            this.Controls.Add(this.GroupNameLabel);
            this.Controls.Add(this.AvatarPictureBox);
            this.Controls.Add(this.ResponseRichTextBox);
            this.Controls.Add(this.MakeRequestButton);
            this.Controls.Add(this.IdTextBox);
            this.Name = "Vkontakte";
            this.Text = "ВКонтакте";
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox IdTextBox;
        private Button MakeRequestButton;
        private RichTextBox ResponseRichTextBox;
        private PictureBox AvatarPictureBox;
        private Label GroupNameLabel;
        private DataGridView UserDataGridView;
    }
}