using System;
using System.Collections.Generic;

namespace Conversions
{
    public static class Weight
    {
        static string NL = Environment.NewLine;
        static string Tab = "	";

        public static OperationResult GramsToLBSandOZ(double grams)
        {
            var output = new OperationResult();

            const double gInLbs = 453.59237;

            var a = grams / gInLbs;

            int lbs = Convert.ToInt32(grams) / Convert.ToInt32(gInLbs);

            var oz = (a - lbs) * 16;
            output.Doubles = new List<double>() { a, oz };
            output.Int = lbs;
            output.String = "grams:" + Tab + grams + NL +
                "Lbs: " + Tab + a + NL +
                "Lbs/Oz:" + Tab + lbs + " lbs " + oz + " oz";

            return output;

        }
    }
}
