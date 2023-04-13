namespace Names
{
    public partial class Names : Form
    {
        public Names()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (!string.IsNullOrWhiteSpace(name) && !namesListBox.Items.Contains(name))
            {
                namesListBox.Items.Add(name);
            }
        }
    }
}