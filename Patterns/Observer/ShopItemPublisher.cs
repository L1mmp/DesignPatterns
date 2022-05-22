using System.Collections.Generic;
using DesignPatterns.Patterns.Observer.Abstractions;
using DesignPatterns.Patterns.Observer.Models;

namespace DesignPatterns.Patterns.Observer
{
    public class ShopItemPublisher : IPublisher
    {
        public ShopItemPublisher(ShopItem observingItem)
        {
            this.observingItem = observingItem;
        }
        public void AddSubscriber(ISubscriber sub)
        {
            _subs.Add(sub);
        }

        public void RemoveSubscriber(ISubscriber sub)
        {
            _subs.Remove(sub);
        }

        public void ChangeShopItem(ShopItem item)
        {
            observingItem = item;
            Notify();
        }

        public void Notify()
        {
            foreach (var subscriber in _subs)
            {
                subscriber.Update(observingItem); 
            }
        }

        private HashSet<ISubscriber> _subs = new HashSet<ISubscriber>();
        ShopItem observingItem;
    }
}