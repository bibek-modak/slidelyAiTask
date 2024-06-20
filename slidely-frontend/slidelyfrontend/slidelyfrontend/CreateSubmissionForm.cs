using System;
using System.Windows.Forms;

namespace SlidelyFormApp
{
    public partial class CreateSubmissionForm : Form
    {
        private bool stopwatchRunning = false;
        private TimeSpan elapsedTime;

        public CreateSubmissionForm()
        {
            InitializeComponent();
        }

        private void btnToggleStopwatch_Click(object sender, EventArgs e)
        {
            if (stopwatchRunning)
            {
                // Stop the stopwatch
                timer1.Stop();
                stopwatchRunning = false;
                btnToggleStopwatch.Text = "Start Stopwatch"; // Change button text to "Start Stopwatch"
            }
            else
            {
                // Start the stopwatch
                timer1.Start();
                stopwatchRunning = true;
                btnToggleStopwatch.Text = "Stop Stopwatch"; // Change button text to "Stop Stopwatch"
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));
            txtStopwatchTime.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Handle submission logic here
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string githubLink = txtGithubLink.Text;

            // Example: Output to console for demonstration
            Console.WriteLine($"Name: {name}, Email: {email}, Phone: {phone}, Github Link: {githubLink}, Elapsed Time: {elapsedTime}");

            // Reset stopwatch
            timer1.Stop();
            stopwatchRunning = false;
            elapsedTime = TimeSpan.Zero;
            txtStopwatchTime.Text = string.Empty;
            btnToggleStopwatch.Text = "Start Stopwatch";

            // Clear form fields (optional)
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtGithubLink.Text = string.Empty;
        }
    }
}
