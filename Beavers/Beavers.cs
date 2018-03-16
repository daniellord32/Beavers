using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beavers
{
    class Beavers
    {
        private int beaverID, capitation;
        private string forename, surname, street, town, county, postcode, allergens;
        private DateTime dob, dateStart, dateLeft;
        private char attened, paid;

        public Beavers()
        {
            this.beaverID = 0;
            this.forename = "";
            this.surname = "";
            this.street = "";
            this.town = "";
            this.county = "";
            this.postcode = "";
            this.dob = DateTime.Now;
            this.dateStart = DateTime.Now;
            this.dateLeft = DateTime.Now;
            this.capitation = 0;
            this.allergens = "";
            this.attened = ' ';
            this.paid = ' ';
        }

        public Beavers(int beaverID, string forename, string surname, string street, string town, string county, string postcode, DateTime dob, DateTime dateStart, DateTime dateLeft, int capitation, string allergens, char paid, char attened)
        {
            this.beaverID = beaverID;
            this.forename = forename;
            this.surname = surname;
            this.street = street;
            this.town = town;
            this.county = county;
            this.postcode = postcode;
            this.dob = dob;
            this.dateStart = dateStart;
            this.dateLeft = dateLeft;
            this.capitation = capitation;
            this.allergens = allergens;
            this.attened = attened;
            this.paid = paid;
        }

        public int BeaverID
        {
            get { return beaverID; }
            set { beaverID = value; }
            
        }

        public string Forename
        {
            get { return forename; }
            set
            {
                if (Validation.validLength(value, 2, 15) && Validation.validLetterWhitespace(value))
                {
                    forename = Validation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Forename must be 2-15 letters");
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if (Validation.validLength(value, 2, 15) && Validation.validLetterWhitespace(value))
                {
                    surname = Validation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Surname must be 2-15 letters");
            }
        }

        public string Street
        {
            get { return street; }
            set
            {
                if (Validation.validLength(value, 2, 50))
                {
                    street = Validation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Street must be 2-50 letters");
            }
        }

        public string Town
        {
            get { return town; }
            set
            {
                if (Validation.validLength(value, 2, 15) && Validation.validLetterWhitespace(value))
                {
                    town = Validation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Town must be 2-15 letters");
            }

        }

        public string County
        {
            get { return county; }
            set
            {
                if (Validation.validLength(value, 2, 25) && Validation.validLetterWhitespace(value))
                {
                    county = Validation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("County must be 2-25 letters");
            }
        }

        public string Postcode
        {
            get { return postcode; }
            set
            {
                if (Validation.validLength(value, 2, 7))
                {
                    postcode = Validation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Postcode must be greater then 1 and less then 7");
            }
        }

        public DateTime Dob
        {
            get { return dob; }
            set
            {
                DateTime today = DateTime.Now;
                int result = DateTime.Compare(value, today);

                if (result == 0)
                {
                    throw new MyException("DOB can't be todays date!");
                }
                else if (result > 0)
                {
                    throw new MyException("DOB cant be in the future!");
                }
                else
                    dob = value;
            }
        }

        public DateTime startDate
        {
            get { return dateStart; }
            set
            {
                DateTime today = DateTime.Now;
                int result = DateTime.Compare(today, value);

                if (result < 0)
                {
                    throw new MyException("Start Date can't be in the past!");
                }
                else if (result == 0)
                {
                    throw new MyException("Start Date cant be that day!");
                }
                else
                    dateStart = value;
            }
        }

        public DateTime DateLeft
        {
            get { return dateLeft; }
            set
            {
                DateTime today = DateTime.Now;
                int result = DateTime.Compare(today, value);

                if (result < 0)
                {
                    throw new MyException("Date left can't be in the past!");
                }
                else if (result > 1)
                {
                    throw new MyException("Date cant be that day!");
                }
                else
                    dateLeft = value;
            }
        }

        public int captiation
        {
            get { return capitation; }
            set { capitation = value; }
        }

        public string Allergens
        {
            get { return allergens; }
            set { allergens = value; }
        }

        public char Attened
        {
            get { return attened; }
            set { attened = value; }
        }

        public char Paid
        {
            get { return paid; }
            set { paid = value; }
        }

       
    }
}
