using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WafiSalesOrder.Domain.Customers;
using WafiSalesOrder.Domain.Products;
using WafiSalesOrder.Domain.SalesOrders;

namespace WafiSalesOrder.Domain.SalesOrderDetails
{
    public class SalesOrderDetail
    {
        public int Id { get; set; }
        [Required]
        public int SalesOrderId { get; set; }
        public SalesOrder SalesOrder { get; set; }
        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public float Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ItemDiscount { get; set; }
    }
}
