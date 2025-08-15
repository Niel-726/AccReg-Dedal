using System;
using System.Windows.Forms;

namespace AccReg
{  
    public partial class Form2 : Form
    {
       
        private StudentInfoClass.DelegateText DelProgram;
        private StudentInfoClass.DelegateText DelLastName;
        private StudentInfoClass.DelegateText DelFirstName;
        private StudentInfoClass.DelegateText DelMiddleName;
        private StudentInfoClass.DelegateText DelAddress;

        
        private StudentInfoClass.DelegateNumber DelNumAge;
        private StudentInfoClass.DelegateNumber DelNumContactNo;
        private StudentInfoClass.DelegateNumber DelStudNo;

        public Form2()
        {
            InitializeComponent();

            
            DelProgram       = StudentInfoClass.GetProgram;
            DelLastName      = StudentInfoClass.GetLastName;
            DelFirstName     = StudentInfoClass.GetFirstName;
            DelMiddleName    = StudentInfoClass.GetMiddleName;
            DelAddress       = StudentInfoClass.GetAddress;

            DelNumAge        = StudentInfoClass.GetAge;
            DelNumContactNo  = StudentInfoClass.GetContactNo;
            DelStudNo        = StudentInfoClass.GetStudentNo;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            getStd.Text      = DelStudNo(StudentInfoClass.StudentNo).ToString();
            getprg.Text      = DelProgram(StudentInfoClass.Program);
            getlname.Text    = DelLastName(StudentInfoClass.LastName);
            getfname.Text    = DelFirstName(StudentInfoClass.FirstName);
            getmname.Text    = DelMiddleName(StudentInfoClass.MiddleName);
            getage.Text      = DelNumAge(StudentInfoClass.Age).ToString();
            getcnt.Text      = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            getaddress.Text  = DelAddress(StudentInfoClass.Address);
        }
    }
}
