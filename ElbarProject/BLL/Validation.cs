using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;
namespace ElbarProject.BLL
{
 public    class Validation
    {
        public static bool IsHebrew(string st)
        {
            for (int i = 0; i < st.Length; i++)
            {
                if (!((st[i] >= 'א' && st[i] <= 'ת') || (st[i] == ' ')))
                    return false;
            }
            return true;

        }
        public static bool IsEnglish(string st)
        {
            for (int i = 0; i < st.Length; i++)
            {
                if (!((st[i] >= 'a' && st[i] <= 'z') || (st[i] == ' ')))
                    return false;
            }
            return true;
        }
        public static bool IsNumbers(string st)
        {
            bool flag = true;
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] >= '0' && st[i] <= '9')
                    flag = true;
                else
                    flag = false;
            }
            return flag;

        }
        public static bool IsMail(string st)
        {
            bool flag = true;
            int x = 0, y = 0;
            for (int i = 0; i < st.Length; i++)
            {
                if (((st[i] >= 'a' && st[i] <= 'z') || (st[i] >= '0' && st[i] <= '9')) || (((st[i] == '@') || (st[i] == '.'))))
                {
                    if (st[i] == '.')
                        x = i;
                    if (st[i] == '@')
                    {
                        if (i > 0)
                            flag = false;
                        y = i;
                    }
                }
            }
            if ((y < x) && (y > 0) && (x < st.Length) && (flag))
                return true;
            return false;


        }
        public static bool IsID(string st)
        {
            int y = 0;
            int x = 0;
            if (Validation.IsNumbers(st) == false)
                return false;
            while (st.Length < 9)
                st = "0" + st;
            for (int i = 0; i < 9; i++)
            {
                if (i % 2 == 0)
                    x += Convert.ToInt32(st[i].ToString());
                else
                {
                    y = Convert.ToInt32(st[i].ToString()) * 2;
                    if (y > 9)
                        y = y / 10 + y % 10;
                    x += y;
                }

            }

            if (x % 10 == 0)
                return true;
            return false;
        }
        public static bool Phone(string st)
        {
            if (st.Length == 9 || st.Length ==10)
                return true;
            return false;
        }
        public static bool IsPhone(string p)
        {
            if (p.Length == 10)
                return true;
            return false;
        }
        public static bool CarNumberCheck(string c)
        {
            if (c.Length == 7)
                return true;
            return false;
        }

    }
}
