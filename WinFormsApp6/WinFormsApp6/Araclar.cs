using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp6
{
    internal class Vehicle
    {
        public override string ToString()
        {
            return $"{Brands}|{Models}|{Km}|{Year}|{DailyRentalPrice}";
        }
        public string Brands { get; set; }
        public string Models { get; set; }
        public string Km { get; set; }
        public string Year { get; set; }
        public int DailyRentalPrice  { get; set; }
        public bool IsRent { get; set; }
        public string ImagePath { get; set; }
    }
    public class Rent
    {
        public override string ToString()
        {
            return $"{FullName}|{IdentifyNumber}|{StartDate}|{FinishDate}|{DownPayment}";
        }
        public string FullName { get; set; }
        public string IdentifyNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int DownPayment { get; set; }
    }
}
