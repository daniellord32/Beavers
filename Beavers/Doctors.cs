using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beavers
{
    class Doctors
    {
        Int32 doctorID;
        string forename, surname, street, town, county, postcode, telNo;

        public Doctors()
        {
            this.doctorID = 0;
            this.forename = "";
            this.surname = "";
            this.street = "";
            this.town = "";
            this.county = "";
            this.postcode = "";
            this.telNo = "";
        }

        public Doctors(int doctorID, string forename, string street, string town, string county, string postcode, string telNo)
        {
            this.doctorID = doctorID;
            this.forename = forename;
            this.street = street;
            this.town = town;
            this.county = county;
            this.postcode = postcode;
            this.telNo = telNo;
        }

        public int DoctorID
        {
            get { return doctorID; }
            set { doctorID = value; }
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

        public string Street
        {
            get { return street; }
            set
            {
                if (Validation.validLength(value, 2, 15))
                {
                    street = value;
                }
                else
                    throw new MyException("Street must be 2-15 letters");
            }
        }

        public string Town
        {
            get { return town; }
            set
            {
                if (Validation.validLength(value, 2, 15))
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
                if (Validation.validLength(value, 2, 15))
                {
                    county = Validation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("County must be 2-15 letters");
            }
        }

        public string Postcode
        {
            get { return postcode; }
            set
            {
                if (Validation.validLength(value, 2, 7))
                {
                    postcode = value;
                }
                else
                    throw new MyException("Postcode must be 2-7 characters");
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

    }
}
