using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WafiSalesOrder.Domain.Customers;
using WafiSalesOrder.Domain.SalesOrderDetails;

namespace WafiSalesOrder.Domain.SalesOrders
{
    public class SalesOrder
    {
        public int Id { get; set; }
        [Required]
        public string SalesOrderNumber { get; set; }
        public string ReferenceNumber { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Description { get; set; }
        public ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }

}
