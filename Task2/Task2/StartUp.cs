using static Task2.Constants.TaxConstants;

namespace Task2
{
    public class StartUp
    {
        static void Main()
        {
            /* All constants are in Constants folder -> TaxConstants class.
             * If needed - TaxConstants can be separated in different classes 
             * for example - a class only for tax persentages.
             * 
             * New taxes could be added to the system with adding another method
             * If the methods become too many, next step would be to refactor them in classes
             */

            Console.WriteLine("*If you want to exit the program, plese type 'End' instead a value*");
            Console.WriteLine();
            Console.WriteLine("Please insert your salary as a gross value: ");

            string input = Console.ReadLine();

            while (input != "End")
            {
                decimal salaryGross = 0;

                try
                {
                    salaryGross = decimal.Parse(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }

                decimal salaryNet = 0;
                decimal tax = 0;

                if (salaryGross <= MinimumNotTaxableSalary)
                {
                    salaryNet = salaryGross;
                }
                else
                {
                    tax = ApplyIncomeTax(salaryGross);
                    tax += ApplySocialContributionTax(salaryGross);

                    salaryNet = salaryGross - tax;
                }

                Console.WriteLine("Your salary after taxes:");
                Console.WriteLine(salaryNet);

                Console.WriteLine();
                Console.WriteLine("Please insert your salary as a gross value: ");
                input = Console.ReadLine();
            }

        }
        public static decimal ApplyIncomeTax(decimal salaryGross)
        {
            decimal salaryToApplyIncomeTaxOn = salaryGross - MinimumNotTaxableSalary;
            decimal result = salaryToApplyIncomeTaxOn * IncomeТaxPercentage;
            return result;
        }

        public static decimal ApplySocialContributionTax(decimal salaryGross)
        {
            if(salaryGross > MaximumTaxableIncomeForSocialContribution)
            {
                salaryGross = MaximumTaxableIncomeForSocialContribution;
            }

            decimal salaryToApplySocialContributionTaxOn = salaryGross - MinimumNotTaxableSalary;

            decimal result = salaryToApplySocialContributionTaxOn * SocialContributionsTaxPercentage;
            return result;
        }
    }
}



