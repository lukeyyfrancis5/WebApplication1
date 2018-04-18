using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Model;

namespace WebApplication1.Models
{
    public class Ledger
    {
        public int LedgerId  { get; set; }
        public string Name { get; set; }
      /*public string LastName { get; set; }
        public string Password { get; set; }
        public string Register { get; set; }
      */
        public virtual List<Coin> Coins { get; set; }
    }
}