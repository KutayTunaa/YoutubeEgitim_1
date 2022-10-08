// See https://aka.ms/new-console-template for more information
using System;

namespace YoutubeEgitim
{
    class Program
    {
        static void Main(String[] args)
        {
            /* int[] sayilar1 = new[] { 1, 2, 3 };
            int[] sayilar2 = new[] { 10, 20, 30 };

            sayilar1 = sayilar2;

            sayilar2[0] = 1000;

            Console.WriteLine(sayilar1[0]); */

            /* CreditManager creditManager = new CreditManager();
            creditManager.Calculate();
            creditManager.Save();

            Customer customer = new Customer(); //instace creation
            customer.Id = 1;
            //customer.FirstName = "Kutay";
            //customer.LastName = "Eslek";
            //customer.NationalIdentity = "12345";
            customer.City = "Ankara";

            CustomerManager customerManager = new CustomerManager(customer);
            customerManager.Save();
            customerManager.Delete();

            Company company = new Company();
            company.TaxNumber = "1000000";
            company.CompanyName = "Apple";
            company.Id = 100;

            //farklı değişkenler atamak için:
            CustomerManager customerManager1 = new CustomerManager(new Person());


            CustomerManager customerManager2 = new CustomerManager(new Company());

            Person person = new Person();
            person.FirstName = "Tuna";
            person.NationalIdentity = "1231241242131";

            Customer customer1 = new Customer();
            Customer customer2 = new Person();
            Customer customer3 = new Company(); */


            CustomerManager customerManager = new CustomerManager(new Customer(), new MilitaryCreditManager());
            customerManager.GiveCredit();

            Console.ReadLine();
        }

        class Person : Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string NationalIdentity { get; set; }
        }
        class Company : Customer
        {
            public string CompanyName { get; set; }
            public string TaxNumber { get; set; }
        }

        abstract class BaseCreditManager : ICreditManager
        {
            public abstract void Calculate();


            public virtual void save()
            {
                Console.WriteLine("Base krediye Kaydedildi...");
            }
        }



        class CreditManager
        {
            public void Calculate()
            {
                Console.WriteLine("hesaplandı...");
            }

            public void Save()
            {
                Console.WriteLine("Kredi verildi...");
            }
        }


        interface ICreditManager
        {
            void Calculate();
            void save();
        }


        class TeacherCreditManager : BaseCreditManager, ICreditManager
        {
            public override void Calculate()
            {
                Console.WriteLine("Öğretmen kredisi hesaplandı");
            }




            /* public void save()
             {
                 throw new NotImplementedException();
             } */
        }

        class MilitaryCreditManager : BaseCreditManager, ICreditManager
        {
            public override void Calculate()
            {
                Console.WriteLine("Asker kredisi hesaplandı");
            }

            /* public void save()
            {
                throw new NotImplementedException();
            } */
        }





        class Customer
        {
            public Customer()
            {
                Console.WriteLine("Müşteri nesnesi başlatıldı...");
            }
            public int Id { get; set; }
            public string City { get; set; }
            //public string FirstName { get; set; }
            //public string LastName { get; set; }
            //public string NationalIdentity { get; set; }
            //public string TaxNumber { get; set; }


        }

        class CustomerManager
        {

            private Customer _customer;

            private ICreditManager _creditManager;

            public CustomerManager(Customer customer, ICreditManager creditManager)
            {
                _customer = customer;

                _creditManager = creditManager;
            }
            public void Save()
            {
                Console.WriteLine("müşteri kaydedildi : ");
            }
            public void Delete()
            {
                Console.WriteLine("Müşteri silindi : ");
            }

            public void GiveCredit()
            {
                _creditManager.Calculate();

                Console.WriteLine("kredi verildi...");
            }


        }
    }
}


   

    
    


