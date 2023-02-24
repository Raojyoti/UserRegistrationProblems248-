using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            while (check)
            {
                Console.Clear();
                Pattern pattern= new Pattern();
                Console.WriteLine("Please choose any options");
                Console.WriteLine("1.Check Validation for First Name\n" +
                    "2.Check Validation for Last Name\n" +
                    "3.Check validation for Email Id\n" +
                    "4.Check validation for Mobile Number\n" +
                    "5.Check validation for Password Rule1\n" +
                    "6.Check validation for Password Rule2\n" +
                    "7.Check validation for Password Rule3\n" +
                    "8.Check validation for Password Rule4\n" +
                    "9.Check validation for All email id\n" +
                    "10.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        //UC1-First name starts with Cap and has minimum 3 characters
                        string firstNamePattern = "^[A-Z]{1}[a-z]{2,}$";//Jyoti
                        Console.WriteLine("Enter first name want to check for validation:");
                        string firstNameInputs = Console.ReadLine();
                        Console.WriteLine("\nAfter check validation result is:\n-------------------------------------");
                        pattern.ValidateUserEntry(firstNameInputs, firstNamePattern);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        //UC2-Last name starts with Cap and has minimum 3 characters
                        string lastNamePattern = "^[A-Z]{1}[a-z]{2,}$";//Rao
                        Console.WriteLine("Enter last name want to check for validation:");
                        string lastNameInputs = Console.ReadLine();
                        Console.WriteLine("\nAfter check validation result is:\n-------------------------------------");
                        pattern.ValidateUserEntry(lastNameInputs, lastNamePattern);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        //UC3-Email has 3 mandatory parts (abc, bl & co) and 2 optional(xyz & in) with precise @ and.positions
                        string emailIdPattern = @"^([abc]+)(\.[a-z0-9_\+\-]+)?@([bl]+)\.([co]{2,4})(\.[a-z]{2,})?$";//abc.xyz@bl.co.in
                        Console.WriteLine("Enter email id want to check for validation:");
                        string emailIdInputs = Console.ReadLine();
                        Console.WriteLine("\nList of valid and Invalid Email Id:\n-------------------------------------");
                        pattern.ValidateUserEntry(emailIdInputs, emailIdPattern);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.Clear();
                        //UC4-Country code follow by space and 10 digit number.
                        string mobileNumberPattern = "^[1-9]{2}?([ ])[0-9]{10}$";//91 9919819801
                        Console.WriteLine("Enter mobile number want to check for validation:");
                        string mobileNumberInputs = Console.ReadLine();
                        Console.WriteLine("\nAfter check validation result is:\n-------------------------------------");
                         pattern.ValidateUserEntry(mobileNumberInputs, mobileNumberPattern);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Clear();
                        //UC5-Password Rule1– minimum 8 Characters.
                        string passwordRule1Pattern = "^[a-zA-Z0-9]{8,}$";
                        Console.WriteLine("Enter password want to check for minimum 8 Characters.:");
                        string passwordRule1Inputs = Console.ReadLine();
                        Console.WriteLine("\nAfter check validation result is:\n-------------------------------------");
                         pattern.ValidateUserEntry(passwordRule1Inputs, passwordRule1Pattern);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.Clear();
                        //UC6-Password Rule2– Should have at least 1 Upper Case.
                        string passwordRule2Pattern = "^(?=.*[A-Z])[A-Za-z0-9]{8,}$";
                        Console.WriteLine("Enter password want to check at least 1 Upper Case:");
                        string passwordRule2Inputs = Console.ReadLine();
                        Console.WriteLine("\nAfter check validation result is:\n-------------------------------------"); ;
                        pattern.ValidateUserEntry(passwordRule2Inputs, passwordRule2Pattern);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.Clear();
                        //UC7-Password Rule3– Should  have at least 1 numeric number.
                        string passwordRule3Pattern = "^(?=.*[A-Z])(?=.*[0-9]).{8,}$";
                        Console.WriteLine("Enter password want to check at least 1 numeric number.:");
                        string passwordRule3Inputs = Console.ReadLine();
                        Console.WriteLine("\nAfter check validation result is:\n-------------------------------------");
                        pattern.ValidateUserEntry(passwordRule3Inputs, passwordRule3Pattern);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.Clear();
                        //UC8-Password Rule3– Has  atleast 1 Special Characters.
                        string passwordRule4Pattern = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
                        Console.WriteLine("Enter password want to check for atleast 1 special character validation:");
                        string passwordRule4Inputs = Console.ReadLine();
                        Console.WriteLine("\nAfter check validation result is:\n-------------------------------------");
                        pattern.ValidateUserEntry(passwordRule4Inputs, passwordRule4Pattern);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 9:
                        Console.Clear();
                        //UC9-Sample Emails to Test
                        string testEmailIdPattern = @"^([a-z0-9\.\-]+)?@([a-z0-9]+)\.([a-z\,\.]+)$";
                        Console.WriteLine("Enter Sample Email id want to Test:");
                        string emailIdInput1 = Console.ReadLine();
                        Console.WriteLine("\nAfter check validation result is:\n-------------------------------------");
                        pattern.ValidateUserEntry(emailIdInput1, testEmailIdPattern);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 10:
                        Console.Clear();
                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Select only valid options");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
