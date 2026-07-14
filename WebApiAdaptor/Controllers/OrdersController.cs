using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAdaptor.Models;

namespace WebApiAdaptor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public object GetOrderData()
        {
            var data = OrdersDetails.GetAllRecords().ToList();
            return new { Items = data, Count = data.Count() };
        }

        // POST: api/Orders
        [HttpPost]
        /// <summary>
        /// Inserts a new data item into the data collection.
        /// </summary>
        /// <param name="newRecord">It holds new record detail which is need to be inserted.</param>
        /// <returns>Returns void</returns>
        public void Post([FromBody] OrdersDetails newRecord)
        {
            // Insert a new record into the OrdersDetails model.
            OrdersDetails.GetAllRecords().Insert(0, newRecord);
        }

        // PUT: api/Orders
        [HttpPut]
        /// <summary>
        /// Update a existing data item from the data collection.
        /// </summary>
        /// <param name="updatedOrder">It holds updated record detail which is need to be updated.</param>
        /// <returns>Returns void</returns>
        public void Put([FromBody] OrdersDetails updatedOrder)
        {
            // Find the existing order by ID
            var existingOrder = OrdersDetails.GetAllRecords().FirstOrDefault(o => o.OrderID == updatedOrder.OrderID);
            if (existingOrder != null)
            {
                // If the order exists, update its properties.
                existingOrder.OrderID = updatedOrder.OrderID;
                existingOrder.CustomerID = updatedOrder.CustomerID;
                existingOrder.EmployeeID = updatedOrder.EmployeeID;
                existingOrder.Freight = updatedOrder.Freight;
            }
        }

        // DELETE: api/5
        [HttpDelete("{key}")]
        /// <summary>
        /// Remove a specific data item from the data collection.
        /// </summary>
        /// <param name="key">It holds specific record detail id which is need to be removed.</param>
        /// <returns>Returns void</returns>
        public void Delete(int key)
        {
            // Find the order to remove by ID.
            var orderToRemove = OrdersDetails.GetAllRecords().FirstOrDefault(order => order.OrderID == key);
            // If the order exists, remove it.
            if (orderToRemove != null)
            {
                OrdersDetails.GetAllRecords().Remove(orderToRemove);
            }
        }
    }
}