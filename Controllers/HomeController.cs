﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using HtmlAgilityPack;
using WebApplication1.Model;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            using (var db = new LedgerContext())
            {

            }




                var url = "https://coinmarketcap.com/";

                var htmlWeb = new HtmlWeb();

                var htmlDocument = new HtmlDocument();
                htmlDocument = htmlWeb.Load(url);

                HtmlNodeCollection allRows = htmlDocument.DocumentNode.SelectNodes("//table[1]/tbody[1]/tr[*]");
                //var rowNumber = 0;
                List<Coin> currencyDataList = new List<Coin>();
            
                foreach (var row in allRows)
                {
                   // Console.WriteLine("Attempting to process row: " + rowNumber++);

                    try
                    {
                        var CoinSymbol = row.ChildNodes[3].ChildNodes[3].InnerText;
                        var CoinName = row.ChildNodes[3].ChildNodes[5].InnerText;
                        var CoinPrice = row.ChildNodes[7].InnerText;

                        Coin coin = new Coin(CoinSymbol, CoinName, CoinPrice);
                        currencyDataList.Add(coin);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Failed to Find Value at Specified Co-ordinates");
                        Console.WriteLine(e);
                        throw;
                    }
                

                Console.WriteLine("Process done");
            }


            return View(currencyDataList);
        }
    }
}