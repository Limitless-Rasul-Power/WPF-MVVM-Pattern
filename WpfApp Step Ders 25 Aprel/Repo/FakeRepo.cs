using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp_Step_Ders_25_Aprel.Models;

namespace WpfApp_Step_Ders_25_Aprel.Repo
{
    public class FakeRepo
    {
        public List<Printer> GetAll()
        {
            return new List<Printer>
            {
                new Printer
                {
                    Model = "Aaa",
                    Vendor = "BB",
                    Color = "Yellow"
                },

                new Printer
                {
                    Model = "hello",
                    Vendor = "world",
                    Color = "green"
                },

                new Printer
                {
                    Model = "hi",
                    Vendor = "new york",
                    Color = "blue"
                },


                new Printer
                {
                    Model = "Egypt",
                    Vendor = "Prince of Persia",
                    Color = "Secret Sword"
                }

            };
        }
    }
}
