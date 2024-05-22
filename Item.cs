using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace OrderManagementWinForms
{
  
        public class Item
        {
            public int ItemID { get; set; }
            public string ItemName { get; set; }
            public string Size { get; set; }
            public string Category { get; set; }
            public decimal Price { get; set; }
            public int StockQuantity { get; set; }
            public string Supplier { get; set; }
            public string Description { get; set; }
        }
    public class Agent
    {
        public int AgentID { get; set; }
        public string AgentName { get; set; }
        public string Address { get; set; }
    }
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int AgentID { get; set; }
    }

    public class OrderDetail
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitAmount { get; set; }
    }
  

public class ItemRepository
    {
        public List<Item> GetAllItems()
        {
            List<Item> items = new List<Item>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Item", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Item item = new Item
                    {
                        ItemID = reader.GetInt32(0),
                        ItemName = reader.GetString(1),
                        Size = reader.GetString(2),
                        Category = reader.GetString(3),
                        Price = reader.GetDecimal(4),
                        StockQuantity = reader.GetInt32(5),
                        Supplier = reader.GetString(6),
                        Description = reader.GetString(7)
                    };
                    items.Add(item);
                }
            }
            return items;
        }

        public void AddItem(Item item)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Item (ItemID, ItemName, Size, Category, Price, StockQuantity, Supplier, Description) VALUES (@ItemID, @ItemName, @Size, @Category, @Price, @StockQuantity, @Supplier, @Description)", conn);
                cmd.Parameters.AddWithValue("@ItemID", item.ItemID);
                cmd.Parameters.AddWithValue("@ItemName", item.ItemName);
                cmd.Parameters.AddWithValue("@Size", item.Size);
                cmd.Parameters.AddWithValue("@Category", item.Category);
                cmd.Parameters.AddWithValue("@Price", item.Price);
                cmd.Parameters.AddWithValue("@StockQuantity", item.StockQuantity);
                cmd.Parameters.AddWithValue("@Supplier", item.Supplier);
                cmd.Parameters.AddWithValue("@Description", item.Description);
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateItem(Item item)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Item SET ItemName = @ItemName, Size = @Size, Category = @Category, Price = @Price, StockQuantity = @StockQuantity, Supplier = @Supplier, Description = @Description WHERE ItemID = @ItemID", conn);
                cmd.Parameters.AddWithValue("@ItemID", item.ItemID);
                cmd.Parameters.AddWithValue("@ItemName", item.ItemName);
                cmd.Parameters.AddWithValue("@Size", item.Size);
                cmd.Parameters.AddWithValue("@Category", item.Category);
                cmd.Parameters.AddWithValue("@Price", item.Price);
                cmd.Parameters.AddWithValue("@StockQuantity", item.StockQuantity);
                cmd.Parameters.AddWithValue("@Supplier", item.Supplier);
                cmd.Parameters.AddWithValue("@Description", item.Description);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteItem(int itemID)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Item WHERE ItemID = @ItemID", conn);
                cmd.Parameters.AddWithValue("@ItemID", itemID);
                cmd.ExecuteNonQuery();
            }
        }
    }


public class AgentRepository
    {
        public List<Agent> GetAllAgents()
        {
            List<Agent> agents = new List<Agent>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Agent", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Agent agent = new Agent
                    {
                        AgentID = reader.GetInt32(0),
                        AgentName = reader.GetString(1),
                        Address = reader.GetString(2)
                    };
                    agents.Add(agent);
                }
            }
            return agents;
        }

        public void AddAgent(Agent agent)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Agent (AgentID, AgentName, Address) VALUES (@AgentID, @AgentName, @Address)", conn);
                cmd.Parameters.AddWithValue("@AgentID", agent.AgentID);
                cmd.Parameters.AddWithValue("@AgentName", agent.AgentName);
                cmd.Parameters.AddWithValue("@Address", agent.Address);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAgent(Agent agent)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Agent SET AgentName = @AgentName, Address = @Address WHERE AgentID = @AgentID", conn);
                cmd.Parameters.AddWithValue("@AgentID", agent.AgentID);
                cmd.Parameters.AddWithValue("@AgentName", agent.AgentName);
                cmd.Parameters.AddWithValue("@Address", agent.Address);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAgent(int agentID)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Agent WHERE AgentID = @AgentID", conn);
                cmd.Parameters.AddWithValue("@AgentID", agentID);
                cmd.ExecuteNonQuery();
            }
        }
    }


    public class OrderRepository
    {
        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Order]", conn);  // [Order] because ORDER is a reserved keyword in SQL
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Order order = new Order
                    {
                        OrderID = reader.GetInt32(0),
                        OrderDate = reader.GetDateTime(1),
                        AgentID = reader.GetInt32(2)
                    };
                    orders.Add(order);
                }
            }
            return orders;
        }

        public void AddOrder(Order order)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO [Order] (OrderID, OrderDate, AgentID) VALUES (@OrderID, @OrderDate, @AgentID)", conn);
                cmd.Parameters.AddWithValue("@OrderID", order.OrderID);
                cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                cmd.Parameters.AddWithValue("@AgentID", order.AgentID);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateOrder(Order order)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE [Order] SET OrderDate = @OrderDate, AgentID = @AgentID WHERE OrderID = @OrderID", conn);
                cmd.Parameters.AddWithValue("@OrderID", order.OrderID);
                cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                cmd.Parameters.AddWithValue("@AgentID", order.AgentID);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteOrder(int orderID)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [Order] WHERE OrderID = @OrderID", conn);
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                cmd.ExecuteNonQuery();
            }
        }
    }



    public class OrderDetailRepository
    {
        public List<OrderDetail> GetAllOrderDetails()
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM OrderDetail", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    OrderDetail orderDetail = new OrderDetail
                    {
                        ID = reader.GetInt32(0),
                        OrderID = reader.GetInt32(1),
                        ItemID = reader.GetInt32(2),
                        Quantity = reader.GetInt32(3),
                        UnitAmount = reader.GetDecimal(4)
                    };
                    orderDetails.Add(orderDetail);
                }
            }
            return orderDetails;
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO OrderDetail (ID, OrderID, ItemID, Quantity, UnitAmount) VALUES (@ID, @OrderID, @ItemID, @Quantity, @UnitAmount)", conn);
                cmd.Parameters.AddWithValue("@ID", orderDetail.ID);
                cmd.Parameters.AddWithValue("@OrderID", orderDetail.OrderID);
                cmd.Parameters.AddWithValue("@ItemID", orderDetail.ItemID);
                cmd.Parameters.AddWithValue("@Quantity", orderDetail.Quantity);
                cmd.Parameters.AddWithValue("@UnitAmount", orderDetail.UnitAmount);
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE OrderDetail SET OrderID = @OrderID, ItemID = @ItemID, Quantity = @Quantity, UnitAmount = @UnitAmount WHERE ID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", orderDetail.ID);
                cmd.Parameters.AddWithValue("@OrderID", orderDetail.OrderID);
                cmd.Parameters.AddWithValue("@ItemID", orderDetail.ItemID);
                cmd.Parameters.AddWithValue("@Quantity", orderDetail.Quantity);
                cmd.Parameters.AddWithValue("@UnitAmount", orderDetail.UnitAmount);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteOrderDetail(int orderDetailID)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM OrderDetail WHERE ID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", orderDetailID);
                cmd.ExecuteNonQuery();
            }
        }


    }





}
