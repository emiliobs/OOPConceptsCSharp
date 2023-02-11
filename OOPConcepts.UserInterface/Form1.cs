namespace OOPConcepts.UserInterface
{
    public partial class frmDate : Form
    {
        public frmDate()
        {
            InitializeComponent();
        }


        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (txtYear.Text.Length == 0)
            {
                MessageBox.Show("You must enter a Year.", "Error");

                return;
            }

            if (txtMonth.Text.Length == 0)
            {
                MessageBox.Show("You must enter a Month.", "Error");

                return;
            }

            if (txtDay.Text.Length == 0)
            {
                MessageBox.Show("You must enter a Day", "Error");

                return;
            }


        }
    }
}