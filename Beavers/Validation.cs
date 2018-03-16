using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beavers
{
    public class Validation
    {

        public static bool validLength(Control txt, ErrorProvider errP, int min, int max)
        {
            bool ok = true;
            TextBox txtB = (TextBox)txt;

            if (String.IsNullOrEmpty(txtB.Text))
            {
                ok = false;
                errP.SetError(txtB, "Must enter Information here!!");
            }
            else if (txtB.Text.Length < min || txtB.Text.Length > max)
            {
                ok = false;
                errP.SetError(txtB, " You must enter between " + min + " and " + max);
            }
            return ok;
        }

        public static bool validLength(String txt, int min, int max)
        {
            bool ok = true;

            if (String.IsNullOrEmpty(txt))
            {
                ok = false;
            }
            else if (txt.Length < min || txt.Length > max)
            {
                ok = false;
            }
            return ok;
        }

        private static bool validNumbers(Control txt, ErrorProvider errP)
        {
            bool ok = true;
            TextBox txtB = (TextBox)txt;

            for (int x = 0; x < txtB.Text[x]; x++)
            {
                if (!(char.IsNumber(txtB.Text[x])))
                {
                    errP.SetError(txtB, "Tel No must be Numeric");
                    ok = false;
                }
            }
            return ok;
        }

        public static bool validNumber(String txt)
        {
            bool ok = true;

            for (int x = 0; x < txt.Length; x++)
            {
                if (!(Char.IsNumber(txt[x])))
                {
                    ok = false;
                }
            }
            return ok;
        }

        private bool validLetters1(Control txt, ErrorProvider errP)
        {
            bool ok = true;
            TextBox txtB = (TextBox)txt;

            for (int x = 0; x < txtB.Text.Length; x++)
            {
                if (!(char.IsLetter(txtB.Text[x])))
                {
                    errP.SetError(txtB, " Invalid!! Information must me AlphaNumeric");
                    ok = false;
                }
            }
            return ok;
        }

        public static bool validLetterWhitespace(Control txt, ErrorProvider errP)
        {
            bool ok = true;
            TextBox txtB = (TextBox)txt;

            if (txtB.Text.Trim().Length == 0)
            {
                errP.SetError(txtB, " Invalid please enter a value!");
                ok = false;
            }
            else
            {
                for (int x = 0; x < txtB.Text.Length; x++)
                {
                    if (!(Char.IsLetter(txt.Text[x])) && !(Char.IsWhiteSpace(txt.Text[x])))
                    {
                        errP.SetError(txtB, " Invalid! Inout must be alhanumeric or space!");
                        ok = false;
                    }
                }
            }
            return ok;
        }

        public static bool validLetterWhitespace(String txt)
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(Char.IsLetter(txt[x])) && !(Char.IsWhiteSpace(txt[x])))
                    {
                        ok = false;
                    }
                }
            }
            return ok;
        }

        public static bool validLetterNumberWhitespace(String txt)
        {
            bool ok = false;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(Char.IsLetter(txt[x])) && !(Char.IsWhiteSpace(txt[x])) && !(Char.IsNumber(txt[x])))
                    {
                        ok = false;
                    }
                }
            }
            return ok;
        }

        private bool validLetters2(Control txt, ErrorProvider errP)
        {
            bool ok = true;
            TextBox txtB = (TextBox)txt;

            if (txtB.Text.Trim().Length == 0)
            {
                errP.SetError(txtB, " Invalid!! Information must me AlphaNumeric");
                ok = false;
            }
            else
            {
                for (int x = 0; x < txtB.Text.Length; x++)
                {
                    if (!(char.IsLetter(txtB.Text[x])) && !(char.IsWhiteSpace(txtB.Text[x])) && !(Char.IsNumber(txtB.Text[x])))
                    {
                        errP.SetError(txtB, " Invalid!! Information must me AlphaNumeric");
                        ok = false;
                    }
                }
            }
            return ok;
        }

        public static String firstLetterEachWordToUpper(String word)
        {
            Char[] array = word.ToCharArray();

            if (Char.IsLower(array[0]))
            {
                array[0] = Char.ToUpper(array[0]);
            }

            for (int x = 1; x < array.Length; x++)
            {
                if (array[x - 1] == ' ')
                {

                    if (Char.IsLower(array[x]))
                    {
                        array[x] = Char.ToUpper(array[x]);
                    }
                }
                else
                    array[x] = Char.ToLower(array[x]);
            }
            return new String(array);
        }
     
    }
}
