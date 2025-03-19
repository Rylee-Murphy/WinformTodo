namespace WinformTodo
{
    public partial class Form1 : Form
    {
        private List<Todo> TaskList {  get; set; }

        public Form1()
        {
            InitializeComponent();
            TaskList = new List<Todo>();
        }

        private void SubmitForm(object sender, EventArgs e)
        {
            //
            //
            //
            if (Validators.IsEmptyText(txtTaskDescription))
            {
                MessageBox.Show("Description is empty, please provide a description.");
                return;
            }

            if (Validators.IsTextNull(txtTaskDescription))
            {
                MessageBox.Show("Description needs to be created.");
                return;
            }

            if (Validators.IsEmptyText(txtDueDate))
            {
                MessageBox.Show("Missing a due date");
                return;
            }

            if (!Validators.IsValidDate(txtDueDate))
            {
                MessageBox.Show("Date is incorrectly formatted, please resubmit.");
            }




            //
            Todo myTodo = new Todo(txtTaskDescription.Text, DateTime.Parse(txtDueDate.Text));

            //
            TaskList.Add(myTodo);

            UpdateListBox();

            ClearForm();
        }

        public void UpdateListBox()
        {
            //
            //

            //
            var list = TaskList
            .OrderBy(t => t.DueDate)
            .ToList();


            //
            for (int i = 0; i < list.Count; i++)
            {
            }

            //
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SubmitForm(sender, e);
            ClearForm();
        }
 
        private void lbTask_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            MessageBox.Show("Form Cleared");
        }
        private void ClearForm()
        {
            txtTaskDescription.Clear();
            txtDueDate.Clear();
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SubmitForm(sender, e);
            }
        }
    }
}
