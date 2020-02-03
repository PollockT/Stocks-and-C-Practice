using System;

namespace Homework1Console
{
    class Program
    {
        private static decimal profit;
        private static decimal purchaseShare;
        private static decimal purchaseCommission;
        private static decimal salePriceShare;
        private static decimal saleCommission;

        private static int shareNumber;

        public decimal Profit { get => profit; set => profit = value; }
        public static decimal PurchaseShare { get => purchaseShare; set => purchaseShare = value; }
        public static decimal PurchaseCommission { get => purchaseCommission; set => purchaseCommission = value; }
        public static decimal SalePriceShare { get => salePriceShare; set => salePriceShare = value; }
        public static decimal SaleCommission { get => saleCommission; set => saleCommission = value; }
        public static int ShareNumber { get => shareNumber; set => shareNumber = value; }

        static void Main(string[] args)
        {
            Console.Write("How many shares did you buy and then sell? ");
            string buffer = Console.ReadLine();
            shareNumber = int.Parse(buffer);

            Console.Write("What price did you pay for the stock per share?  ");
            buffer = Console.ReadLine();
            purchaseShare = decimal.Parse(buffer);

            Console.Write("What was the purchase commission? ");
            buffer = Console.ReadLine();
            purchaseCommission = decimal.Parse(buffer);

            Console.Write("What was the sale price per share? ");
            buffer = Console.ReadLine();
            salePriceShare = decimal.Parse(buffer);

            Console.Write("What was the sales commission? ");
            buffer = Console.ReadLine();
            saleCommission = decimal.Parse(buffer);
            
            Calculate(shareNumber, purchaseShare, purchaseCommission,
            salePriceShare, saleCommission);

            Console.Write("The profit from this sale of stock is $" + profit);

           // Console.WriteLine(shareNumber + " " + purchaseShare + " " + purchaseCommission + " " +
           //     + salePriceShare + " " + saleCommission);

            Console.ReadLine();

        }

        private static decimal Calculate(int shareNumber, decimal purchaseShare, decimal purchaseCommission,
            decimal salePriceShare, decimal saleCommission)
        {
            profit = ((shareNumber * salePriceShare) - (shareNumber * purchaseShare) + purchaseCommission);
            return profit;
        }
    }
}
