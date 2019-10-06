using System;

namespace MVA_Class_Demo {
    interface ILoyaltyCardHolder {
        int TotalPoints { get; }
        int AddPoints(decimal transactionValue);
        void ResetPoints();
    }
    class Customer : ILoyaltyCardHolder {
        private int totalPoints;

        public int TotalPoints {
            get { return totalPoints; }
        }
        public int AddPoints(decimal transactionValue) {
            int points = Decimal.ToInt32(transactionValue);
            totalPoints += points;
            return totalPoints;
        }
        public void ResetPoints() {
            totalPoints = 0;
        }
    }
    class Program {
        static void Main(string[] args) {
            Customer cust = new Customer();
            cust.AddPoints(2);
            cust.AddPoints(3);
            Console.WriteLine(cust.TotalPoints);
            cust.ResetPoints();
            Console.WriteLine(cust.TotalPoints);
        }
    }
}