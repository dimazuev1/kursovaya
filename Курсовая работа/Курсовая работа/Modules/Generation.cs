using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая_работа.Classes;

namespace Курсовая_работа.Modules
{
    class Generation
    {
        public TextBox tb;
        private bool _isActive = false;
        public SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Desktop\\Курсач димаса\\Курсовая работа\\Курсовая работа\\DB.mdf;Integrated Security=True");
        public Generation(TextBox t)
        {

            tb = t;
            conn.Open();
        }
        public void Start()
        {
            _isActive = true;
            Task.Run(() => Generate());
            Task.Run(() => GenerateClients());
            Task.Run(() => GenerateProduct());
        }
        public void Stop()
        {
            _isActive = false;
        }
        private void Generate()
        {
            while (_isActive)
            {
                Client c = PickClient();
                Order order = GenerateOrder(c);
                Checkout(order);
                Thread.Sleep(1000);
            }
        }
        public List<Client> clients = new List<Client>();
        public List<Order> orders = new List<Order>();
        public List<Product> products = new List<Product>();
        public Buy buy = new Buy();
        public List<string> clientNames = new List<string> { "Олег", "Арбуз", "Буржун"};
        public List<string> productMaterial = new List<string> { "готика", "фэнтези", "историческое/дамасская", "мозаичная", "тигельная" };
        public List<string> productTypes = new List<string> { "холодное оружие", "ворота", "скульптуры", "средневековая броня", "броня эпохи возрождение" };


        public void GenerateClients()
        {
            while (_isActive)
            {
                Client c = new Client();
                Random random = new Random();
                c.Name = clientNames[random.Next(0, clientNames.Count)];
                clients.Add(c);
                Thread.Sleep(1000);
            }
        }
        public void GenerateProduct()
        {
            while (_isActive)
            {
                Product p = new Product();
                Random random = new Random();
                p.Name = productMaterial[random.Next(0, productTypes.Count)];
                p.Object = productTypes[random.Next(0, productMaterial.Count)];
                if (p.Name == "готика") p.Price = random.Next(1, 999) + 10000;
                if (p.Name == "фэнтези") p.Price = random.Next(1, 999) + 10000;
                if (p.Name == "историческое/дамасская") p.Price = random.Next(1, 999) + 10000;
                if (p.Name == "мозаичная") p.Price = random.Next(1, 999) + 5000;
                if (p.Name == "тигельная") p.Price = random.Next(1, 999) + 5000;
                products.Add(p);
                Thread.Sleep(1000);
            }
        }
        public Client PickClient()
        {
            if (clients.Count > 0)
            {
                Random random = new Random();
                return clients[random.Next(0, clients.Count)];
            }
            return null;
        }

        public Order GenerateOrder(Client c)
        {
            if (c == null) return null;
            if (products.Count <= 0) return null;
            Random random = new Random();
            Product p = products[random.Next(0, products.Count)];
            Order order = new Order() { Client = c, Product = p, Date = DateTime.Now };
            return order;
        }

        public void Checkout(Order o)
        {
            if (o == null) return;
            orders.Add(o);
            buy.Account += o.Product.Price;
            tb.Invoke(new Action(() => tb.Text = $"{o.Client.Name} заказал стиль: {o.Product.Name} за {o.Product.Price} руб. Предмет: {o.Product.Object}.  Дата заказа: {o.Date.ToString("yyyy.MM.dd")}"));
            Insert(o);
            Thread.Sleep(500);
        }
        public void Insert(Order o)
        {
            string query = "INSERT INTO [Order] (clientName, productType, productMaterial, date, price) VALUES (@clientName, @productType, @productMaterial, @date, @price)";
            SqlCommand com = new SqlCommand(query, conn);
            com.Parameters.Add("@clientName", System.Data.SqlDbType.NVarChar);
            com.Parameters.Add("@productType", System.Data.SqlDbType.NVarChar);
            com.Parameters.Add("@productMaterial", System.Data.SqlDbType.NVarChar);
            com.Parameters.Add("@date", System.Data.SqlDbType.Date);
            com.Parameters.Add("@price", System.Data.SqlDbType.Decimal);
            com.Parameters["@clientName"].Value = o.Client.Name;
            com.Parameters["@productType"].Value = o.Product.Name;
            com.Parameters["@productMaterial"].Value = o.Product.Object;
            com.Parameters["@date"].Value = o.Date;
            com.Parameters["@price"].Value = o.Product.Price;
            com.ExecuteNonQuery();
        }
    }
}
