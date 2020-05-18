using System;

namespace IndianNumberSpeller
{
    public class NumberSpeller
    {
        public NumberSpeller()
        {
        }

        public string SpellANumber(int input)
        {
            if (input < 0)
                throw new ArgumentException("Given Number should be a whole number");

            return string.Empty;
        }
    }
}