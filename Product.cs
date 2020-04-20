using System;
using System.Collections.Generic;

namespace ConsoleApp1.buoi2.Lab2
{
    public class Product
    {
        public int id;
        public string name;
        public int price;
        public int qty;
        public string img;
        public string desc;
        public List<string> gallery;
        public List<Product> productList = new List<Product>();

        public Product()
        {
        }

        public Product(int id, string name, int price, int qty, string img, string desc, List<string> gallery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.img = img;
            this.desc = desc;
            this.gallery = gallery;
        }

        public void showInf()
        {
            Console.WriteLine("ID: " + id + " | " + "Name: " + name + " | " + "Price: " + price + " | " + "Qty: " +
                              qty + " | " + "Image: " + img + " | " + "Desc: " + desc);
        }

        public void addProduct(Product product)
        {
            productList.Add(product);
        }

        public void stock()
        {
            string name;
            Console.WriteLine("enter product name to check:");
            name = Convert.ToString(Console.ReadLine());
            foreach (Product p in productList)
            {
                if (name.Equals(p.name))
                {
                    if (p.qty > 0)
                    {
                        Console.WriteLine("Con hang");
                    }
                    else
                    {
                        Console.WriteLine("het hang");
                    }
                }
            }
        }

        public void addGallery()
        {
            if (gallery.Count < 10)
            {
                foreach (Product p in productList)
                {
                    gallery.Add(p.img);
                }

                Console.WriteLine("Them thanh cong vao ");
                Console.WriteLine("List gallery: ");
                foreach (String img in gallery)
                {
                    Console.WriteLine(img);
                }
            }
            else
            {
                Console.WriteLine("Vuot qua so luong them la 10");
            }
        }

        public void removeGallery()
        {
            int q;
            Console.WriteLine("Nhap anh muon xoa");
            q = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < gallery.Count; i++)
            {
                if (i == q)
                {
                    gallery.RemoveAt(q - 1);
                    Console.WriteLine("Xoa thanh cong!");
                    Console.WriteLine("Gallery list: ");
                    foreach (string img in gallery)
                    {
                        Console.WriteLine(img);
                    }
                }
            }
        }
    }
}
