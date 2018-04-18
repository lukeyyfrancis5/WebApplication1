using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Model
{
    public class Coin
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        

        public int LedgerId { get; set; }
        public virtual Ledger Ledger { get; set; }
        

        public Coin(string coinSymbol, string coinName, string coinPrice)
        {
            try
            {
                this.Symbol = coinSymbol;
                this.Name = coinName;
                this.Price = Double.Parse(coinPrice,NumberStyles.Currency);
            }
            catch (Exception e)
            {
                Console.WriteLine("Coin Data Parsing Error:\n" + e);
                throw;
            }
        }
    }
}
