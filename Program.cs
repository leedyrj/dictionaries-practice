using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("TGT", "Target");
            stocks.Add("KR", "Kroger");
            stocks.Add("CLF", "Cleveland-Cliffs");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>() {
            ("GM", 100, 23.21),
            ("CAT", 24, 9.31),
            ("TGT", 132, 17.92),
            ("KR", 59, 32.51),
            ("CLF", 250, 35.84),
        };

            Dictionary<string, double> portfolio = new Dictionary<string, double>();


            foreach ((string ticker, int shares, double price) purchase in purchases)

            {
                // Does the company name key already exist in the report dictionary?
                if (portfolio.ContainsKey(stocks[purchase.ticker]))
                {
                    // If it does, update the total valuation
                    portfolio[stocks[purchase.ticker]] += purchase.shares * purchase.price;
                }
                else
                {
                    // If not, add the new key and set its value
                    portfolio[stocks[purchase.ticker]] = purchase.shares * purchase.price;
                }
            }

            foreach (KeyValuePair<string, double> stock in portfolio)
            {
                Console.WriteLine($"I have {stock.Value.ToString("C")} of {stock.Key}");
            }
        }
    }
}
