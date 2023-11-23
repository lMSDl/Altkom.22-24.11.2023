﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Creational.ObjectPool
{
    public class ItemPool
    {
        private IReadOnlyCollection<Item> _items;

        public ItemPool(int count)
        {
            _items = Enumerable.Range(1, count).Select(x => new Item()).ToList();
        }

        public Item? Acquire()
        {
            lock (this)
            {
                var item = _items.FirstOrDefault(x => !x.IsVisible);
                if (item != null)
                    item.IsVisible = true;
                return item;
            }
        }
    }
}
