using System;
namespace ConsoleApp1.buoi2.Lab2
{
    public class MainLab2
    {
        public static void Main(string[] ary)
        {
            Product product = new Product();
            int chose = 0;
            int id;
            string name;
            double price;
            int qty;
            string image;
            string desc;
            do
            {
                Console.WriteLine("1. Addproduct");
                Console.WriteLine("2. GetInfo");
                Console.WriteLine("3. CheckStock");
                Console.WriteLine("4. Add gallery");
                Console.WriteLine("5. Remove gallery");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Chose:");
                chose = Convert.ToInt32(Console.ReadLine());
                switch (chose)
                {
                    case 1:
                        Console.WriteLine("Enter id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name: ");
                        name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter price: ");
                        price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter qty: ");
                        qty = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter image: ");
                        image = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter desc: ");
                        desc = Convert.ToString(Console.ReadLine()); 
                        break;
                        
                    case 2:
                        product.showInf();
                        break;
                    case 3:
                        product.stock();
                        break;
                    case 4:
                        product.addGallery();
                        break;
                    case 5: 
                        product.removeGallery();
                        break;
                    case 6: 
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong choice please choice 1-6!");
                        break;
                }
            }
            while (chose != 5) ;
        }
    }
}