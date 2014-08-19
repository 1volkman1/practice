using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PattyPlaner
{
    class DinnerParty: Party
    {
        const int CostOfFoodPerPerson = 25;
        private int numberOfPeople;
        public int NumberOfPeople {
            get
            {
                return numberOfPeople;
            }
            set
            { 
               numberOfPeople = value ;
               CalculateCostOfDecorations(fancyDecorations);
            }

        }

        private bool fancyDecorations;

        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;
        
       

        public DinnerParty(int numberOfPeople, bool healthyOptions, bool fancyDecorations): base(numberOfPeople,fancyDecorations)
        {
            //NumberOfPeople = numberOfPeople;
            //this.fancyDecorations = fancyDecorations;
            SetHealthyOption(healthyOptions);
            CalculateCostOfDecorations(fancyDecorations);
        }

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.5M) + 30M;
            }
        }

        public decimal CalculateCost(bool healthyOptions)
        {
            decimal totalCost = base.CalculateCost() + (CostOfBeveragesPerPerson * NumberOfPeople);
            
            if (healthyOptions)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }
        }
        public void SetPartyOptions(int people, bool fancy)
        {
            NumberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }

        public int GetNumberOfPeople()
        {
            return NumberOfPeople;
        }
    }
}
