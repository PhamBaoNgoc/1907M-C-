using System.Collections.Generic;
using ConsoleApp1.buoi2.Lab2;

namespace ConsoleApp1.buoi3.Lab3
{
    public class Fashion : Product
    {
        protected string color;
        protected string size;
        public List<Fashion> ListFashion = new List<Fashion>();

        public Fashion()
        {
            
        }

        public Fashion(string color, string size)
        {
            this.color = color;
            this.size = size;
        }

        public Fashion(int id, string name, int price, int qty, string img, string desc, List<string> gallery,
            string color, string size) : base(id, name, price, qty, img, desc, gallery)
        {
            this.color = color;
            this.size = size;
        }

        public void descColor()
        {
            
        }
    }
}