using OOPConcepts.Logic;

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


            try
            {
                var year = Convert.ToInt32(txtYear.Text);
                var month = Convert.ToInt32(txtMonth.Text);
                var day = Convert.ToInt32(txtDay.Text);

                var date = new Date(year, month, day);

                MessageBox.Show($"Congratulations the Date: {date} is Valid.", "Confirm");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Something wrong was occurred: {ex.Message}", "Error");
            }

        }
    }
}