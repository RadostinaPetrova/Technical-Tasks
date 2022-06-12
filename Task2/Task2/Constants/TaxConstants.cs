using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Constants
{
    public static class TaxConstants
    {
        public const decimal IncomeТaxPercentage = 0.10M;
        public const decimal SocialContributionsTaxPercentage = 0.15M;

        public const decimal MinimumNotTaxableSalary = 1000;
        public const decimal MaximumTaxableIncomeForSocialContribution = 3000;
    }
}
