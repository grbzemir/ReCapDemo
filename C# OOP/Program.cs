using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP
{
    // classların en önemli görevi gruplar ayırmada işe yaramasıdır
    // propları tutar
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "istanbul";
            customer.Id = 1;
            customer.FirstName = "Emir";
            customer.LastName = "Gürbüz";
            customer.Address = "Esenyurt";

            Customer customer2 = new Customer

            {

                Id = 2 ,
                City = "Ankara",
                FirstName = "Yetkin",
                LastName = "Gürbüz",
                Address = "Esenyurt"


            };

            Console.WriteLine(customer2.FirstName);



            Console.ReadLine();

        }
    }

}     