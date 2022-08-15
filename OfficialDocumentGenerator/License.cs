namespace OfficialDocumentGenerator
{
    public partial class License : Form
    {
        public License()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            var form = new DetailType();
            form.Show(); this.Visible = false; //Show DetailType Form & Close Now Form.
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // Exit Program if user don't apply.
        }
    }
}