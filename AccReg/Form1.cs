using System;
using System.Windows.Forms;

namespace AccReg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            this.nxtBtn.Click += nxtBtn_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            if (prgmCMB.Items.Count == 0)
            {
                prgmCMB.Items.AddRange(new object[]
                {
                    "BS Computer Science",
                    "BS Information Technology",
                    "BS Information Systems",
                    "BS Computer Engineering",
                    "BS Software Engineering"
                });
            }
        }

        
        private void nxtBtn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(stdNo.Text))
            {
                MessageBox.Show("Student No. is required.");
                stdNo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(prgmCMB.Text))
            {
                MessageBox.Show("Program is required.");
                prgmCMB.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(lname.Text))
            {
                MessageBox.Show("Last Name is required.");
                lname.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                MessageBox.Show("First Name is required.");
                fname.Focus();
                return;
            }

            long parsedStudentNo;
            if (!long.TryParse(stdNo.Text.Trim(), out parsedStudentNo))
            {
                MessageBox.Show("Student No. must be numeric.");
                stdNo.Focus();
                return;
            }

            long parsedAge;
            long parsedContact;

            long.TryParse(age.Text.Trim(), out parsedAge);       
            long.TryParse(cntNo.Text.Trim(), out parsedContact); 

           
            StudentInfoClass.StudentNo = parsedStudentNo;
            StudentInfoClass.Program = prgmCMB.Text.Trim();
            StudentInfoClass.LastName = lname.Text.Trim();
            StudentInfoClass.FirstName = fname.Text.Trim();
            StudentInfoClass.MiddleName = textBox3.Text.Trim();
            StudentInfoClass.Age = parsedAge;
            StudentInfoClass.ContactNo = parsedContact;
            StudentInfoClass.Address = addressBox.Text.Trim();

           
            using (var frmConfirm = new Form2())
            {
                var result = frmConfirm.ShowDialog(this);

               
                if (result == DialogResult.OK)
                {
                    stdNo.Clear();
                    prgmCMB.SelectedIndex = -1;
                    lname.Clear();
                    fname.Clear();
                    textBox3.Clear();
                    age.Clear();
                    cntNo.Clear();
                    addressBox.Clear();
                    stdNo.Focus();
                }
            }
        }
    }
}
