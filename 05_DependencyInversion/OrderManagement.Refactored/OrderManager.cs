namespace _05_DependencyInversion.OrderManagement.Refactored
{
    internal class OrderManager
    {
        public ILogger _logger;

        public OrderManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add(Order order)
        {
            // Add the order
            _logger.Log($"Order {order.Id} added.");
        }

        public void Update(Order order)
        {
            // Update the order
            _logger.Log($"Order {order.Id} updated.");
        }

        public void Delete(Order order)
        {
            // Delete the order
            _logger.Log($"Order {order.Id} deleted.");
        }
    }
}
