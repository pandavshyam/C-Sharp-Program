using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    /*
        Create a reference type called Person. Populate the Person class with the following members. 

 

    Properties to store the following information: 

    First name  

    Last name  

    Email address  

    Date of birth  

 

    Add constructors that accept the following parameter lists: 

    All four parameters  

    First, Last, Email  

    First, Last, Date of birth 

 

    Add read-only properties that return the following computed information: 

    Adult - whether or not the person is over 18  

    Sun sign - the traditional western sun sign of this person  

    Birthday - whether or not today is the person's birthday  

    Screen name - a default screen name that you might see being offered to a first time user of AOL or Yahoo 
    (e.g. John Doe born on February 25th, 1980 might be jdoe225 or johndoe022580)  
    */
    public class FutureBornException : Exception
    {
        public FutureBornException()
        {

        }
        public FutureBornException(string message)
            : base(message)
        {

        }
    }

    class InvalidEmailException : Exception
    {
        public InvalidEmailException()
        {

        }
        public InvalidEmailException(string message)
            : base(message)
        {

        }
    }

    class TooOldException : Exception
    {
        public TooOldException()
        {

        }
        public TooOldException(string message)
            : base(message)
        {

        }
    }

    class Person
    {
        string firstName;
        string lastName;
        string email;
        DateTime dob;

        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (!value.Contains('@') || !value.Contains('.'))
                {

                    throw new InvalidEmailException(value);
                }
                else
                {
                    email = value;
                }
            }
        }

        public DateTime DateO
        {
            get { return dob; }
            set
            {
                if (DateTime.Now.Year - value.Year <= 0)
                {

                    throw new FutureBornException(value.ToString());

                }
                else if (DateTime.Now.Year - value.Year >= 135)
                {

                    throw new TooOldException(value.ToString());

                }
                else
                    dob = value;
            }
        }


        // Field with only read option

        bool adult;
        string shortName;
        string sunSign;
        bool birthDay;

        public string ShortName
        {
            get
            {
                this.shortName = firstName.Substring(0, 3) + lastName.Substring(0, 3) + dob.Month + dob.Day + dob.Year;
                return shortName;
            }
        }

        public string SunSign
        {
            get
            {
                this.sunSign = zodiac(dob.Day, dob.Month);
                return sunSign;
            }

        }

        public bool Adult
        {
            get
            {
                int age = calAge(dob.Year, dob.Month, dob.Day);
                this.adult = age > 18 ? true : false;
                return adult;
            }

        }

        public bool BirthDay
        {
            get
            {
                DateTime today = DateTime.Today;
                if (today.Month == dob.Month && today.Day == dob.Day)
                    this.birthDay = true;
                else
                    this.birthDay = false;
                return birthDay;
            }

        }

        // All constructors
        public Person(string fName, string lName, string email, DateTime date)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.email = email;
            this.dob = date;
        }

        public Person(string fName, string lName, string email)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.email = email;
        }

        public Person(string fName, string lName, DateTime date)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.dob = date;
        }

        static int calAge(int year, int month, int day)
        {
            var today = DateTime.Today;
            int age = today.Year - year;
            return age;
        }

        static string zodiac(int day, int month)
        {
            string zodiac_sign = "";

            if (month == 12)
            {
                if (day < 22)
                    zodiac_sign = "Sagittarius";
                else
                    zodiac_sign = "capricorn";
            }

            else if (month == 1)
            {
                if (day < 20)
                    zodiac_sign = "Capricorn";
                else
                    zodiac_sign = "aquarius";
            }

            else if (month == 2)
            {
                if (day < 19)
                    zodiac_sign = "Aquarius";
                else
                    zodiac_sign = "pisces";
            }

            else if (month == 3)
            {
                if (day < 21)
                    zodiac_sign = "Pisces";
                else
                    zodiac_sign = "aries";
            }

            else if (month == 4)
            {
                if (day < 20)
                    zodiac_sign = "Aries";
                else
                    zodiac_sign = "taurus";
            }

            else if (month == 5)
            {
                if (day < 21)
                    zodiac_sign = "Taurus";
                else
                    zodiac_sign = "gemini";
            }

            else if (month == 6)
            {
                if (day < 21)
                    zodiac_sign = "Gemini";
                else
                    zodiac_sign = "cancer";
            }

            else if (month == 7)
            {
                if (day < 23)
                    zodiac_sign = "Cancer";
                else
                    zodiac_sign = "leo";
            }

            else if (month == 8)
            {
                if (day < 23)
                    zodiac_sign = "Leo";
                else
                    zodiac_sign = "virgo";
            }

            else if (month == 9)
            {
                if (day < 23)
                    zodiac_sign = "Virgo";
                else
                    zodiac_sign = "libra";
            }

            else if (month == 10)
            {
                if (day < 23)
                    zodiac_sign = "Libra";
                else
                    zodiac_sign = "scorpio";
            }

            else if (month == 11)
            {
                if (day < 22)
                    zodiac_sign = "scorpio";
                else
                    zodiac_sign = "sagittarius";
            }

            return (zodiac_sign);
        }

    }

    class Problem1
    {
        static void Main(string[] args)
        {
            DateTime dob = new DateTime(1998, 7, 25);
            Person personObj = new Person("Shyam", "Pandav", "shyam_pandav@persistent.com", dob);
            Console.WriteLine(personObj.ShortName);
        }
    }
}
