using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beavers
{
    class Classes
    {
        public Int32 classID, maxNo = 18;
        DateTime cTime;
        String day;

        public Classes()
        {
            this.classID = 0;
            this.day = "";
            this.maxNo = 18;
            this.cTime = DateTime.Now;
        }

        public Classes(int classID, int maxNo, DateTime cTIme, string day)
        {
            this.classID = classID;
            this.maxNo = maxNo;
            this.cTime = cTIme;
            this.day = day;
        }

        public int ClassID
        {
            get { return classID; }
            set { classID = value; }
        }

        public DateTime CTime
        {
            get { return cTime; }
            set
            {
                DateTime today = DateTime.Now;
                int result = DateTime.Compare(today, cTime);

                if (result == 0)
                {
                    throw new MyException("DOB can't be todays date!");
                }
                else if (result > 0)
                {
                    throw new MyException("DOB cant be in the future!");
                }
                else
                    cTime = value;
            }
        }

        public String Day
        {
            get { return day; }
            set { day = value; }
        }

    }
}
