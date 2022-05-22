using System;
using DesignPatterns.Patterns.Observer.Abstractions;

namespace DesignPatterns.Patterns.Observer.Models
{
    public class EmaiSubscriber : ISubscriber
    {
        public void Update(ShopItem item)
        {
            Console.WriteLine($"Name: {item.Name}.\tPrice: {item.Price}.\nDescroption: {item.Description}");
        }
    }
}