/*
                                    ******** RESTAURANT OTOMASYONU *********
 * Toplam 5 masa olacak. Masalarda kişi sınırlaması YOK. Her masa kendinden önceki masa dolu ise müşteri oturtulacak
 * Çorbalar:Mercimek:40, Yayla: 45, Ezogelin:54.5 gibi 5 menü yazılacak.
 * Merhaba hoşgeldiniz ifadesi kaç müşteri olduğunu öğrenilecek. Her grupdaki müşterilere ayrı ayrı menüler listelenecek ve seçim sonrası başka arzunuz var mı? sorusu sorulacak. 
    * Evet ise yeniden menüler listlenecek ve seçim istenecek. 
    * Hayır cevabı alınırsa diğer müşteriye geçilecek.
 * Sipariş alma işlemi bittiğinde yeni müşteri var mı? veya Hesap Al
  
 *** Z Raporu
 *** En Fazla Tercih Edilen Ürün
 */

namespace Restaurand
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] Soups = { "Mercimek", "Yayla", "Ezogelin", "Tarator", "Şehriye" };
            double[] SoupsPrice = { 54, 70, 32.5, 150, 40 };
            string[] Maincourse = { "İskender", "Tavuk Döner", "Et Dönmez", "Tavuk üstü pilav", "Kokoreç" };
            double[] MaincoursePrice = { 350, 70, 120, 100, 200 };
            string[] Desserts = { "Baklava", "Künefe", "Kadayıf", "Tulumba", "Soğuk Baklava" };
            double[] DessertsPrice = { 133, 322, 255, 132, 207 };
            string[] Drinks = { "ColaTurka", "Ayran", "Çay", "SarıyerCola", "Kahve" };
            double[] DrinksPrice = { 20, 10, 13, 20, 30 };
            string[] Appetizer = { "Sigara Böreği", "Kısır", "Mücver", "Köfte", "Patates Kızartması" };
            double[] AppetizerPrice = { 20, 10, 13, 20, 30 };

            List<Customer> Masa1 = new List<Customer>();
            List<Customer> Masa2 = new List<Customer>();
            List<Customer> Masa3 = new List<Customer>();
            List<Customer> Masa4 = new List<Customer>();
            List<Customer> Masa5 = new List<Customer>();
            Restaurant a = new Restaurant();

            while (true)
            {
                if (Masa1.Count == 0)
                {
                    a.TakeOrders(Masa1, Soups, SoupsPrice, Maincourse, MaincoursePrice, Desserts,
                                DessertsPrice, Drinks, DrinksPrice, Appetizer, AppetizerPrice);

                    Console.WriteLine("Siparişiniz alınmıştır Masa 1 e geçebilirsiniz ");

                }
                else if (Masa2.Count == 0)
                {
                    a.TakeOrders(Masa2, Soups, SoupsPrice, Maincourse, MaincoursePrice, Desserts,
                                DessertsPrice, Drinks, DrinksPrice, Appetizer, AppetizerPrice);

                    Console.WriteLine("Siparişiniz alınmıştır Masa 2 ye geçebilirsiniz ");
                }
                else if (Masa3.Count == 0)
                {
                    a.TakeOrders(Masa3, Soups, SoupsPrice, Maincourse, MaincoursePrice, Desserts,
                               DessertsPrice, Drinks, DrinksPrice, Appetizer, AppetizerPrice);

                    Console.WriteLine("Siparişiniz alınmıştır Masa 3 e geçebilirsiniz ");
                }
                else if (Masa4.Count == 0)
                {
                    a.TakeOrders(Masa4, Soups, SoupsPrice, Maincourse, MaincoursePrice, Desserts,
                               DessertsPrice, Drinks, DrinksPrice, Appetizer, AppetizerPrice);

                    Console.WriteLine("Siparişiniz alınmıştır Masa 4 e geçebilirsiniz ");
                }
                else if (Masa5.Count == 0)
                {
                    a.TakeOrders(Masa5, Soups, SoupsPrice, Maincourse, MaincoursePrice, Desserts,
                               DessertsPrice, Drinks, DrinksPrice, Appetizer, AppetizerPrice);

                    Console.WriteLine("Siparişiniz alınmıştır Masa 5 e geçebilirsiniz ");
                }
                else
                {
                    Console.WriteLine(" Masalarımızın hepsi doludur. Daha sonra yine bekleriz ");
                }
 
                Thread.Sleep(3000);
                Console.Clear();
            }

        }
    }

    public class Customer
    {
        public string name;
        public List<Order> Orders { get; set; }
        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer CustomerAddition()
        {
            Console.WriteLine("İsim :");
            name = Console.ReadLine();
            return this;

        }
        public void Menu(string[] a, double[] b)
        {

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{a[i]} : {b[i]}TL ");
            }

        }



    }
    public class Order
    {
        public string ItemName { get; set; }
        public double Price { get; set; }

        public Order(string itemName, double price)
        {
            ItemName = itemName;
            Price = price;
        }
    }
    public class Restaurant
    {
        public void TakeOrders(List<Customer> masa, string[] Soups, double[] SoupsPrice,
                                        string[] Maincourse, double[] MaincoursePrice,
                                        string[] Desserts, double[] DessertsPrice,
                                        string[] Drinks, double[] DrinksPrice,
                                        string[] Appetizer, double[] AppetizerPrice)
        {
            Console.Write(" AHMAYTI Mutfağına hoşgeldiniz\n Lütfen kişi sayısını yazınız :  ");
            int personcount = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < personcount; i++)
            {
                Customer a = new Customer();


                masa.Add(a.CustomerAddition());

                while (true)
                {
                    Console.WriteLine($"{a.name} Hangi tür yemek istersin \n 1-Çorbalar \n 2-Ana yemekler \n 3-Tatlılar \n 4-İçecekler \n 5-Ara sıcaklar ");
                    int secim = Convert.ToInt32(Console.ReadLine());

                    if (secim == 1)
                    {
                        a.Menu(Soups, SoupsPrice);
                        Console.WriteLine(" Seçim yapınız ");
                        int secimcorba = Convert.ToInt32(Console.ReadLine()) - 1;
                        a.Orders.Add(new Order(Soups[secimcorba], SoupsPrice[secimcorba]));

                    }
                    else if (secim == 2)
                    {
                        a.Menu(Maincourse, MaincoursePrice);
                        Console.WriteLine(" Seçim yapınız ");
                        int secimcorba = Convert.ToInt32(Console.ReadLine()) - 1;
                        a.Orders.Add(new Order(Maincourse[secimcorba], MaincoursePrice[secimcorba]));
                    }
                    else if (secim == 3)
                    {
                        a.Menu(Desserts, DessertsPrice);
                        Console.WriteLine(" Seçim yapınız ");
                        int secimcorba = Convert.ToInt32(Console.ReadLine()) - 1;
                        a.Orders.Add(new Order(Desserts[secimcorba], DessertsPrice[secimcorba]));
                    }
                    else if (secim == 4)
                    {
                        a.Menu(Drinks, DrinksPrice);
                        Console.WriteLine(" Seçim yapınız ");
                        int secimcorba = Convert.ToInt32(Console.ReadLine()) - 1;
                        a.Orders.Add(new Order(Drinks[secimcorba], DrinksPrice[secimcorba]));
                    }
                    else if (secim == 5)
                    {
                        a.Menu(Appetizer, AppetizerPrice);
                        Console.WriteLine(" Seçim yapınız ");
                        int secimcorba = Convert.ToInt32(Console.ReadLine()) - 1;
                        a.Orders.Add(new Order(Appetizer[secimcorba], AppetizerPrice[secimcorba]));
                    }
                    else
                    {
                        Console.WriteLine(" Yanlış seçim ");
                        continue;
                    }



                    Console.WriteLine(" Başka bir arzunuz varmı? (E/H)");
                    string sec = Console.ReadLine();

                    if (sec == "E" || sec == "e")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }


    }




}
