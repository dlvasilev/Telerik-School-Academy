using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _02.WebCalculator.ViewModels;

namespace _02.WebCalculator.Controllers
{
    public class Query
    {
        public double Quantity { get; set; }
        public int Kilo { get; set; }
        public string Type { get; set; }
    }

    public class HomeController : Controller
    {

        public static List<TypeSize> Items = new List<TypeSize>() 
            { 
                  new TypeSize {Value="b", Name="bit - b"},
                  new TypeSize {Value="B", Name="Byte - B"},
                  new TypeSize {Value="Kb", Name="Kilobit - Kb"},
                  new TypeSize {Value="KB", Name="Kilobyte - KB"},
                  new TypeSize {Value="Mb", Name="Megabit - Mb"},
                  new TypeSize {Value="MB", Name="Megabyte - MB"},
                  new TypeSize {Value="Gb", Name="Gigabit - Gb"},
                  new TypeSize {Value="GB", Name="Gigabyte - GB"},
                  new TypeSize {Value="Tb", Name="Terabit - Tb"},
                  new TypeSize {Value="TB", Name="Terabyte - TB"},
                  new TypeSize {Value="Pb", Name="Petabit - Pb"},
                  new TypeSize {Value="PB", Name="Petabyte - PB"},
                  new TypeSize {Value="Eb", Name="Exabit - Eb"},
                  new TypeSize {Value="EB", Name="Exabyte - EB"},
                  new TypeSize {Value="Zb", Name="Zettabit - Zb"},
                  new TypeSize {Value="ZB", Name="Zettabyte - ZB"},
                  new TypeSize {Value="Yb", Name="Yottabit - Yb"},
                  new TypeSize {Value="YB", Name="Yottabyte - YB"},
            };

        public ActionResult Index()
        {

            var dropDownItems = Items.Select(t => new SelectListItem { Text = t.Name, Value = t.Value }).ToList();


            return View(dropDownItems);
        }

        public ActionResult CalculateResult(Query query)
        {
            int kilo = query.Kilo;
            double yotaBytes = 0;

            if (query.Quantity != 0)
            {
                switch (query.Type)
                {
                    case "b": yotaBytes = query.Quantity / (8 * Math.Pow(kilo, 2));
                        break;
                    case "B": yotaBytes = query.Quantity / (Math.Pow(kilo, 8));
                        break;
                    case "Kb": yotaBytes = query.Quantity / (8 * Math.Pow(kilo, 7));
                        break;
                    case "KB": yotaBytes = query.Quantity / Math.Pow(kilo, 7);
                        break;
                    case "Mb": yotaBytes = query.Quantity / (8 * Math.Pow(kilo, 6));
                        break;
                    case "MB": yotaBytes = query.Quantity / Math.Pow(kilo, 6);
                        break;
                    case "Gb": yotaBytes = query.Quantity / (8 * Math.Pow(kilo, 5));
                        break;
                    case "GB": yotaBytes = query.Quantity / Math.Pow(kilo, 5);
                        break;
                    case "Tb": yotaBytes = query.Quantity / (8 * Math.Pow(kilo, 4));
                        break;
                    case "TB": yotaBytes = query.Quantity / Math.Pow(kilo, 4);
                        break;
                    case "Pb": yotaBytes = query.Quantity / (8 * Math.Pow(kilo, 3));
                        break;
                    case "PB": yotaBytes = query.Quantity / Math.Pow(kilo, 3);
                        break;
                    case "Eb": yotaBytes = query.Quantity / (8 * Math.Pow(kilo, 2));
                        break;
                    case "EB": yotaBytes = query.Quantity / Math.Pow(kilo, 2);
                        break;
                    case "Zb": yotaBytes = query.Quantity / (8 * kilo);
                        break;
                    case "ZB": yotaBytes = query.Quantity / kilo;
                        break;
                    case "Yb": yotaBytes = query.Quantity / 8;
                        break;
                    case "YB": yotaBytes = query.Quantity / 1;
                        break;
                    default:
                        break;
                }
            }
            return PartialView("_CalculateResult", GetResults(yotaBytes, kilo));
        }

        private List<TypeSize> GetResults(double yotaBytes, int kilo)
        {
            var result = new List<TypeSize>();
            var multiplicator = -1;
            for (int i = Items.Count - 1; i >= 0; i--)
            {
                int bitParam = 1;
                if (i % 2 == 0)
                {
                    bitParam = 8;
                }
                else
                {
                    multiplicator++;
                }

                double sizeResult = yotaBytes * bitParam * Math.Pow(kilo, multiplicator);

                result.Add(new TypeSize
                {
                    Name = Items[i].Name,
                    Size = sizeResult
                });
            }

            return result;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}