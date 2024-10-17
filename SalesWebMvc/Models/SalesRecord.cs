using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public double Amount {  get; set; }        
        public SalesStatus Status { get; set; }

        public Seller Seller { get; set; }

        public SalesRecord()
        {
            
        }

        public SalesRecord(int iD, DateTime date, double amount, SalesStatus status, Seller seller)
        {
            ID = iD;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
