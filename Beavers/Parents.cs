using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beavers
{
    class Parents
    {
        int parentID;
        string forename, surname, telNo, email;
        char volunteer;

        public Parents()
        {
            parentID = 0;
            forename = "";
            surname = "";
            telNo = "";
            email = "";
            volunteer = ' ';
        }

        public Parents(int parentID, string surname, string forename, string telNo, string email,char volunteer)
        {
            this.parentID = parentID;
            this.forename = forename;
            this.surname = surname;
            this.telNo = telNo;
            this.email = email;
            this.volunteer = volunteer;
        }

        public int ParentID
        {
            get { return parentID; }
            set { parentID = value; }
        }

        public string Forename
        {
            get { return forename; }
            set
            {
                if (Validation.validLength(value, 2, 15))
                {
                    forename = Validation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Forename must be 2-15 characters long");
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if (Validation.validLength(value, 2, 15))
                {
                    surname = Validation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Surname must be 2-15 characters long");
            }
        }

        public string TelNo
        {
            get { return telNo; }
            set 
            {
                if (Validation.validNumber(value))
                {
                    telNo = value;
                }
                else
                    throw new MyException("Telephone Number must be 2-11 letters");
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }

        public char Volunteer
        {
            get {return volunteer; }
            set { volunteer = value;}
        }

        
    }
}
