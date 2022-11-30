namespace LambdaPracticeingProblembs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problems Statement Using REGEX");
            //User FirstName
            Console.WriteLine("Enter the firstname: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine(UserValidations.CheckFirstName(FirstName));
            //User LastName
            Console.WriteLine("Enter the lastname: ");
            string lastname = Console.ReadLine();
            Console.WriteLine(UserValidations.CheckLastName(lastname));
            //User Email
            Console.WriteLine("Enter the email: ");
            string email = Console.ReadLine();
            Console.WriteLine(UserValidations.checkEmail(email));
            //User PhoneNumber
            Console.WriteLine("Enter the phonenumber: ");
            string phonenumber = Console.ReadLine();
            Console.WriteLine(UserValidations.checkMobileNumber(phonenumber));
            //User Password
            Console.WriteLine("Enter the password: ");
            string password = Console.ReadLine();
            Console.WriteLine(UserValidations.checkPassword(password));
        }
    }
}