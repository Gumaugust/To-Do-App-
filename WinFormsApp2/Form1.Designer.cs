namespace WinFormsApp2
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
            TextBox = new TextBox();
            Add = new Button();
            Delete = new Button();
            dataGridView = new DataGridView();
            Done = new Button();
            Sort = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // TextBox
            // 
            TextBox.BackColor = SystemColors.HighlightText;
            TextBox.BorderStyle = BorderStyle.FixedSingle;
            TextBox.Location = new Point(12, 12);
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(476, 58);
            TextBox.TabIndex = 0;
            // 
            // Add
            // 
            Add.Location = new Point(494, 23);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 1;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(694, 23);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 2;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click_1;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 76);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(776, 373);
            dataGridView.TabIndex = 3;
            dataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Done
            // 
            Done.Location = new Point(594, 23);
            Done.Name = "Done";
            Done.Size = new Size(94, 29);
            Done.TabIndex = 4;
            Done.Text = "Edit";
            Done.UseVisualStyleBackColor = true;
            Done.Click += Done_Click;
            // 
            // Sort
            // 
            Sort.Font = new Font("Vinhan", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sort.Location = new Point(756, 58);
            Sort.Name = "Sort";
            Sort.Size = new Size(32, 32);
            Sort.TabIndex = 5;
            Sort.Text = "v";
            Sort.UseVisualStyleBackColor = true;
            Sort.Click += Sort_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Sort);
            Controls.Add(Done);
            Controls.Add(dataGridView);
            Controls.Add(Delete);
            Controls.Add(Add);
            Controls.Add(TextBox);
            Name = "Form1";
            Text = "TO DO LIST";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBox;
        private Button Add;
        private Button Delete;
        private DataGridView dataGridView;
        private Button Done;
        private Button Sort;
    }
}
