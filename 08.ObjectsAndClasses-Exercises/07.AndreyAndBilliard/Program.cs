using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');

                Product product = products.FirstOrDefault(p => p.Name == input[0]);

                if(product == null)
                {
                    products.Add(new Product(input[0], decimal.Parse(input[1])));
                }
                else
                {
                    product.Price = decimal.Parse(input[1]);
                }
            }
            List<Customer> customers = new List<Customer>();
            while (true)
            {
                string[] order = Console.ReadLine().Split("-,".ToCharArray());

                if (order[0] == "end of clients")
                {
                    break;
                }

                if (products.Any(p => p.Name == order[1]) == false)
                {
                    continue;
                }
                FillCustomersList(customers, order);
            }
            decimal total = 0;
            foreach (Customer item in customers.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{item.Name}");
                decimal bill = 0;
                foreach (KeyValuePair<string,int> order in item.Order)
                {
                    Console.WriteLine($"-- {order.Key} - {order.Value}");

                    bill += (products.First(p => p.Name == order.Key).Price * order.Value);
                }
                Console.WriteLine($"Bill: {bill:f2}");
                total += bill;

            }
            Console.WriteLine($"Total bill: {total:f2}");
        }

        private static void FillCustomersList(List<Customer> customers, string[] order)
        {
            Customer customer = customers.FirstOrDefault(c => c.Name == order[0]);
            
            if (customer==null)
            {
                Customer newCustomer = new Customer(order[0]);
                newCustomer.Order.Add(order[1], int.Parse(order[2]));
                customers.Add(newCustomer);
            }
            else
            {
                if (!customer.Order.ContainsKey(order[1]))
                {
                    customer.Order.Add(order[1], int.Parse(order[2]));
                }
                else
                {
                    customer.Order[order[1]] += int.Parse(order[2]);
                }
            }
        }
    }

}
