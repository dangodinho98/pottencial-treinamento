using System;
using System.Collections.Generic;
using System.Linq;

namespace Pottencial.Invoices.Borders.Invoices.Entities
{
    public class Invoice
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount => Items.Sum(x => x.Amount);

        public string Customer { get; set; }

        public Status Status { get; set; }

        public IList<Item> Items { get; set; }
    }
}
