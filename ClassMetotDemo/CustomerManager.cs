using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class CustomerManager 
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Kullanıcı Eklendi: " + customer.FirstName +" "+ customer.LastName);
        } 

        public void Update(Customer customer)
        {
            Console.WriteLine("Kullanıcı Güncellendi: " + customer.FirstName + " " + customer.LastName);


        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Kullanıcı Silindi: " + customer.FirstName + " " + customer.LastName);

        }

        public void List(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName);            
        }




    }
}
