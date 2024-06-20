using System;
using System.Windows.Forms;

namespace SlidelyFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnViewSubmissions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void btnCreateSubmission_Click(object sender, EventArgs e)
        {
            CreateSubmissionForm createForm = new CreateSubmissionForm();
            createForm.Show();
        }

        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateSubmission = new System.Windows.Forms.Button();
            this.btnViewSubmissions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Bibek modak - Slidely App";
            // 
            // btnCreateSubmission
            // 
            this.btnCreateSubmission.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreateSubmission.BackColor = System.Drawing.Color.Cyan;
            this.btnCreateSubmission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateSubmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSubmission.Location = new System.Drawing.Point(116, 275);
            this.btnCreateSubmission.Name = "btnCreateSubmission";
            this.btnCreateSubmission.Size = new System.Drawing.Size(336, 47);
            this.btnCreateSubmission.TabIndex = 17;
            this.btnCreateSubmission.Text = "Create submission";
            this.btnCreateSubmission.UseVisualStyleBackColor = false;
            this.btnCreateSubmission.Click += new System.EventHandler(this.btnCreateSubmission_Click);
            // 
            // btnViewSubmissions
            // 
            this.btnViewSubmissions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewSubmissions.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnViewSubmissions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewSubmissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSubmissions.Location = new System.Drawing.Point(116, 134);
            this.btnViewSubmissions.Name = "btnViewSubmissions";
            this.btnViewSubmissions.Size = new System.Drawing.Size(336, 47);
            this.btnViewSubmissions.TabIndex = 19;
            this.btnViewSubmissions.Text = "Create submission";
            this.btnViewSubmissions.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(623, 472);
            this.Controls.Add(this.btnViewSubmissions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreateSubmission);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
    }
}
