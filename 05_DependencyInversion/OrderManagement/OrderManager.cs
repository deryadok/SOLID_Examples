namespace _05_DependencyInversion.OrderManagement
{
    internal class OrderManager
    {
        FileLogger fileLogger;
        DBLogger dbLogger;

        public OrderManager()
        {
            fileLogger = new FileLogger();
            dbLogger = new DBLogger();
        }

        public void Add(Order order)
        {
            // Add the order
            fileLogger.Log($"Order {order.Id} added.");
            dbLogger.Log($"Order {order.Id} added.");
        }

        public void Update(Order order)
        {
            // Update the order
            fileLogger.Log($"Order {order.Id} updated.");
            dbLogger.Log($"Order {order.Id} updated.");
        }

        public void Delete(Order order)
        {
            // Delete the order
            fileLogger.Log($"Order {order.Id} deleted.");
            dbLogger.Log($"Order {order.Id} deleted.");
        }
    }
}
