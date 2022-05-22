using System;
using DesignPatterns.Patterns.Observer.Abstractions;

namespace DesignPatterns.Patterns.Observer.Models
{
    public class PhoneSubscriber : ISubscriber
    {
        public void Update(ShopItem item)
        {
            Console.WriteLine($"Phone notification:\nName: {item.Name}.\tPrice: {item.Price}.\nDescroption: {item.Description}");
        }
    }
}