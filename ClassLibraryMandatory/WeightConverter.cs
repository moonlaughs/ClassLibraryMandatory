using System;

namespace ClassLibraryMandatory
{
    public class WeightConverter
    {
        public double GramToOunces(double gram)
        {
            double ounceValue = gram * 0.03527396195;

            return ounceValue;
        }

        public double OuncesToGram(double ounces)
        {
            double gramValue = ounces * 28.34952;
            return gramValue;
        }
    }
}
