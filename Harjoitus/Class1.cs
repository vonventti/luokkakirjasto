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
        public static bool OverDueOrNot(DateTime aloitusPvm, double aikaArvio)
        {
            bool timeCheck;
            TimeSpan arvioituOpiskeluAika = TimeSpan.FromDays(aikaArvio);
            if (DateTime.Now > (aloitusPvm + arvioituOpiskeluAika))
            {
                return timeCheck = true;
            }
            else if (DateTime.Now < (aloitusPvm + arvioituOpiskeluAika))
            {
                return timeCheck = false;
            }
            else
            {
                return timeCheck = true;
            }
        }



        // Metodi, joka kertoo opiskelun aloitusajan ja arvioidun opiskeluajan perusteella onko opiskelu myöhässä vai ei.
    }
}
