namespace WinformTodo
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
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnAdd = new Button();
            lblDueDate = new Label();
            txtDueDate = new TextBox();
            lblTaskBox = new Label();
            txtTaskDescription = new TextBox();
            gbTaskList = new GroupBox();
            lbTask = new ListBox();
            groupBox1.SuspendLayout();
            gbTaskList.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(lblDueDate);
            groupBox1.Controls.Add(txtDueDate);
            groupBox1.Controls.Add(lblTaskBox);
            groupBox1.Controls.Add(txtTaskDescription);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 110);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task Form";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(230, 74);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(311, 74);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add ToDo";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(6, 48);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(55, 15);
            lblDueDate.TabIndex = 3;
            lblDueDate.Text = "Due Date";
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(70, 45);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.PlaceholderText = "0000-00-00";
            txtDueDate.Size = new Size(316, 23);
            txtDueDate.TabIndex = 2;
            // 
            // lblTaskBox
            // 
            lblTaskBox.AutoSize = true;
            lblTaskBox.Location = new Point(6, 19);
            lblTaskBox.Name = "lblTaskBox";
            lblTaskBox.Size = new Size(30, 15);
            lblTaskBox.TabIndex = 1;
            lblTaskBox.Text = "Task";
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(70, 16);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(316, 23);
            txtTaskDescription.TabIndex = 0;
            // 
            // gbTaskList
            // 
            gbTaskList.Controls.Add(lbTask);
            gbTaskList.Location = new Point(12, 128);
            gbTaskList.Name = "gbTaskList";
            gbTaskList.Size = new Size(392, 405);
            gbTaskList.TabIndex = 1;
            gbTaskList.TabStop = false;
            gbTaskList.Text = "Task List";
            // 
            // lbTask
            // 
            lbTask.FormattingEnabled = true;
            lbTask.Location = new Point(6, 20);
            lbTask.Name = "lbTask";
            lbTask.Size = new Size(380, 379);
            lbTask.TabIndex = 0;
            lbTask.SelectedIndexChanged += lbTask_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 545);
            Controls.Add(gbTaskList);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "ToDo App";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbTaskList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTaskDescription;
        private Button btnAdd;
        private Label lblDueDate;
        private TextBox txtDueDate;
        private Label lblTaskBox;
        private Button btnClear;
        private GroupBox gbTaskList;
        private ListBox lbTask;
    }
}
