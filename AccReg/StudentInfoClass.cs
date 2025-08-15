using System;

namespace AccReg
{
   
    public class StudentInfoClass
    {
        
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);

        
        public static string FirstName = "";
        public static string LastName = "";
        public static string MiddleName = "";
        public static string Address = "";
        public static string Program = "";
        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        
        public static string GetFirstName(string FirstNameParam)
        {
            FirstName = FirstNameParam;
            return FirstName;
        }
        public static string GetLastName(string LastNameParam)
        {
            LastName = LastNameParam;
            return LastName;
        }
        public static string GetMiddleName(string MiddleNameParam)
        {
            MiddleName = MiddleNameParam;
            return MiddleName;
        }
        public static string GetAddress(string AddressParam)
        {
            Address = AddressParam;
            return Address;
        }
        public static string GetProgram(string ProgramParam)
        {
            Program = ProgramParam;
            return Program;
        }
        public static long GetAge(long AgeParam)
        {
            Age = AgeParam;
            return Age;
        }
        public static long GetContactNo(long ContactNoParam)
        {
            ContactNo = ContactNoParam;
            return ContactNo;
        }
        public static long GetStudentNo(long StudentNoParam)
        {
            StudentNo = StudentNoParam;
            return StudentNo;
        }
    }
}