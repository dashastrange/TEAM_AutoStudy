using System;
namespace OOP_SqareCircle
{
    public class Validation
    {
       double entered;
       public double Validate()
        {
            var entered = Console.ReadLine();
            bool validated = double.TryParse(entered, out double validatedVal);
            if (validated && validatedVal > 0)
            {
                return Math.Round(validatedVal, 2);
            }

            if (!entered)
            {
                Console.WriteLine($"Entered value is not number.");
            }

            if (entered && validatedVal <= 0)
            {
                Console.WriteLine($"Entered value is negative or zero.");
            }

        }

    }
}
