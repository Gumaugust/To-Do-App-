
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private List<TaskItem> tasks;


        public Form1()
        {
            InitializeComponent();
            tasks = new List<TaskItem>();
            InitializeDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitializeDataGridView()
        {
            dataGridView.Columns.Clear();


            // Cấu hình cột Task Description (cột thứ nhất)
            DataGridViewTextBoxColumn taskColumn = new DataGridViewTextBoxColumn();
            taskColumn.Name = "TaskDescription";
            taskColumn.HeaderText = "Task Description";
            taskColumn.Width = 350;
            dataGridView.Columns.Add(taskColumn);

            // Cấu hình cột Status (cột thứ hai)
            DataGridViewCheckBoxColumn statusColumn = new DataGridViewCheckBoxColumn();
            statusColumn.Name = "Status";
            statusColumn.HeaderText = "Status";
            statusColumn.Width = 70;
            dataGridView.Columns.Add(statusColumn);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string taskDescription = TextBox.Text.Trim();
            if (!string.IsNullOrEmpty(taskDescription))
            {
                TaskItem task = new TaskItem(taskDescription);
                tasks.Add(task);
                TextBox.Clear();
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Hãy nhập một công việc.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void Done_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedCells[0].RowIndex;
                DataGridViewCellCollection cells = dataGridView.Rows[selectedRowIndex].Cells;

                if (cells["TaskDescription"].Value != null)
                {
                    string taskDescription = cells["TaskDescription"].Value.ToString();

                    // Hiển thị MessageBox để người dùng nhập thông tin mới
                    string editedDescription = Interaction.InputBox("Enter the new task description:", "Edit Task", taskDescription);

                    // Cập nhật nếu người dùng đã nhập thông tin mới
                    if (!string.IsNullOrEmpty(editedDescription))
                    {
                        tasks[selectedRowIndex].Description = editedDescription;
                        UpdateDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid task to edit.", "Invalid Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a task to edit.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void UpdateDataGridView()
        {
            dataGridView.Rows.Clear();
            foreach (var task in tasks)
            {
                DataGridViewRow row = new DataGridViewRow();

                // Cột Task Description
                DataGridViewTextBoxCell taskCell = new DataGridViewTextBoxCell();
                taskCell.Value = task.Description;
                row.Cells.Add(taskCell);

                // Cột chọn để xoá
                DataGridViewCheckBoxCell deleteCell = new DataGridViewCheckBoxCell();
                deleteCell.Value = false; // Mặc định không được chọn để xoá
                row.Cells.Add(deleteCell);

               

                dataGridView.Rows.Add(row);
            }
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            List<TaskItem> tasksToDelete = new List<TaskItem>();

            try
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataGridViewCheckBoxCell checkBoxCell = row.Cells["Status"] as DataGridViewCheckBoxCell;
                        if  (checkBoxCell != null &&  Convert.ToBoolean(checkBoxCell.Value))
                        {
                            int rowIndex = row.Index;
                            // Kiểm tra xem rowIndex có hợp lệ không trước khi xoá
                            if (rowIndex >= 0 && rowIndex < tasks.Count)
                            {
                                tasksToDelete.Add(tasks[rowIndex]);
                            }
                        }
                    }
                }
                foreach (var task in tasksToDelete)
                {
                    tasks.Remove(task);
                }

                UpdateDataGridView();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("An error occurred while deleting tasks. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void Sort_Click_1(object sender, EventArgs e)
        {
         /*   tasks.Sort();
            UpdateDataGridView();*/
        }

        
        public class TaskItem
        {
            public string Description { get; set; }

            public TaskItem(string description)
            {
                Description = description;
            }
        }
    }


}