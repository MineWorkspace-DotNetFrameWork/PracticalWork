using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork
{
    class Goods
    {
        // 36 задание
        public string Name { get; set; }
        public DateTime DateRegistration { get; set; }
        public decimal Price { get; set; }
        public int QuantityGoods { get; set; }
        public string InvoiceNumber { get; set; }
        public void ChangePrice(decimal price)
        {
            Price = price;
        }
        public void ChangeQuantityGoods(int quantityGoods)
        {
            QuantityGoods = quantityGoods;
        }
        public decimal CalcPrice(int numberGoods)
        {
            return Price * numberGoods;
        }
        public override string ToString()
        {
            return $"\n> Price: {Price} $";
        }
        // 29 задание
        public Date Date { get; set; }
        public void ShelfLife() // Срок хранения товара
        {
            DateTime dateTime = new DateTime();

            int date1 = Date.DateFormat.year + Date.DateFormat.month + Date.DateFormat.day;
            int date2 = dateTime.Year + dateTime.Month + dateTime.Day;

            int shelfLife = date2 - date1;
            if (shelfLife > 7)
                Console.WriteLine("Срок хранения товара > 7 дней");
            if (shelfLife > 10)
                Console.WriteLine("Срок хранения товара > 10 дней");
            if (shelfLife > 20)
                Console.WriteLine("Срок хранения товара > 20 дней");
            if (shelfLife > 30)
                Console.WriteLine("Срок хранения товара > 30 дней");
        }
    }
}
