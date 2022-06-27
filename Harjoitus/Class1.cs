using System;

namespace Harjoitus
{
    public class Class1
    {
     public static bool DateTimeCheck(DateTime a)
        {
            bool timeCheck;
            if (DateTime.Now > a)
            {
                return timeCheck = false;
                
            }
            else if (DateTime.Now < a)
            {
                return timeCheck = true;
                
            }
            else
            {
                return timeCheck = true;
            }
        }
        public static bool OverDueOrNot(DateTime a)
    }
}
