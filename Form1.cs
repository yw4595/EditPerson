using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set default selection of GendergroupBox
            ThemradioButton.Checked = true;

            // Wire up event handler for PersonTypecomboBox
            PersonTypecomboBox.SelectedIndexChanged += PersonTypecomboBox_SelectedIndexChanged;

            // Wire up event handlers for ClassGroupBox
            FreshmanradioButton.CheckedChanged += ClassRadioButton_CheckedChanged;
            SophomoreradioButton.CheckedChanged += ClassRadioButton_CheckedChanged;
            JuniorradioButton.CheckedChanged += ClassRadioButton_CheckedChanged;
            SeniorradioButton.CheckedChanged += ClassRadioButton_CheckedChanged;

            // Set the gradient background color of the form
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))); // light blue
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); // close the form when Cancel button is clicked
        }

        private void PersonTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check Senior radio button if Student is selected
            if (PersonTypecomboBox.SelectedItem.ToString() == "Student")
            {
                SeniorradioButton.Checked = true;
                ClassgroupBox.Enabled = true;
                ClassgroupBox.Visible = true;
            }
            // Uncheck Senior radio button if Teacher is selected
            else if (PersonTypecomboBox.SelectedItem.ToString() == "Teacher")
            {
                SeniorradioButton.Checked = false;
                ClassgroupBox.Enabled = false;
                ClassgroupBox.Visible = false;
            }
        }

        private void ClassRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set ClassOfTextbox text based on selected radio button
            if (FreshmanradioButton.Checked)
            {
                ClassOfTextbox.Text = "Class of 2023";
            }
            else if (SophomoreradioButton.Checked)
            {
                ClassOfTextbox.Text = "Class of 2022";
            }
            else if (JuniorradioButton.Checked)
            {
                ClassOfTextbox.Text = "Class of 2021";
            }
            else if (SeniorradioButton.Checked)
            {
                ClassOfTextbox.Text = "Class of 2020";
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            // Get the selected gender
            string gender = "";
            if (HimradioButton.Checked)
            {
                gender = "Male";
            }
            else if (HerradioButton.Checked)
            {
                gender = "Female";
            }
            else if (ThemradioButton.Checked)
            {
                gender = "Other";
            }
            else
            {
                gender = "Prefer not to say";
            }

            // Get the selected person type
            string personType = PersonTypecomboBox.SelectedItem.ToString();

            // Initialize class and classOf variables
            string selectedClass = "";
            string classOf = "";

            // Get the selected class and classOf based on the selected person type
            if (personType == "Student")
            {
                if (FreshmanradioButton.Checked)
                {
                    selectedClass = "Freshman";
                    classOf = "Class of 2023";
                }
                else if (SophomoreradioButton.Checked)
                {
                    selectedClass = "Sophomore";
                    classOf = "Class of 2022";
                }
               
                else if (JuniorradioButton.Checked)
                    {
                        selectedClass = "Junior";
                        classOf = "Class of 2021";
                    }
                    else if (SeniorradioButton.Checked)
                    {
                        selectedClass = "Senior";
                        classOf = "Class of 2020";
                    }
                    else
                    {
                        selectedClass = "N/A";
                        classOf = "N/A";
                    }
                }
                else
                {
                    selectedClass = "N/A";
                    classOf = "N/A";
                }

                // Get the entered email
                string email = EmailtextBox.Text;

                // Get the entered GPA
                string gpa = GPAtextBox.Text;

                // Get the entered license ID
                string licenseID = LicenceIDtextBox.Text;

                // Display the input data in a message box
                string message = string.Format("Gender: {0}\nPerson Type: {1}\nClass: {2}\nClass Of: {3}\nEmail: {4}\nGPA: {5}\nLicense ID: {6}", gender, personType, selectedClass, classOf, email, gpa, licenseID);
                MessageBox.Show(message, "Input Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        // Set the background color of the form to a gradient
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rect = ClientRectangle;
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(rect, Color.WhiteSmoke, Color.DarkGray, 45))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }
    }
}
