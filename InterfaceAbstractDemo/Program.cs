using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer {DateOfBirth=new DateTime(1997,1,1), FirstName="Nasuh Onur",LastName="Yaşa",NationalityId="55099316952" });
            Console.ReadLine();
        }
    }
}
