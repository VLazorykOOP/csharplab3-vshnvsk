using System;

namespace Task1
{
    class Money
    {
        private int nominal;
        private int num;

        public Money(int nominal, int num)
        {
            this.nominal = nominal;
            this.num = num;
        }

        public void Print() { Console.WriteLine($"Nominal: {nominal}, \tNum: {num}"); }

        public bool BuyGoods(double amount) { return amount <= nominal * num; }

        public int CalcQuantity(double amount) { return (int)(TotalAmount / amount); }

        public int Nominal
        {
            get { return nominal; } 
            set { nominal = value; }
        }

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public double TotalAmount
        {
            get { return nominal * num; }
        }

        static void Main(string[] args)
        {
            Money[] wallet = new Money[]
            {
                new Money(1, 10),
                new Money(2, 5),
                new Money(5, 3),
                new Money(10, 7),
                new Money(20, 2)
            };

            Console.WriteLine("Your money: ");
            foreach (Money money in wallet)
            {
                money.Print();
            }

            Console.WriteLine("\nEnter a price of goods: ");
            double price = Convert.ToDouble(Console.ReadLine());
            foreach (Money money in wallet)
            {
                Console.WriteLine($"Nominal: {money.Nominal}, \tNum: {money.Num}, \tBuy possibility: {money.BuyGoods(price)}");
            }

            Console.WriteLine("\nEnter a price of goods for quantity search: ");
            double price2 = Convert.ToDouble(Console.ReadLine());
            foreach (Money money in wallet)
            {
                Console.WriteLine($"Nominal: {money.Nominal}, \tNum: {money.Num}, \tQuantity possibility: {money.CalcQuantity(price2)}");
            }
        }
    }
}