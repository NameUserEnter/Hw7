using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    //Порушено принцип єдиності обов’язку
    class Item
    {

    }
    class Order
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }

        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
    }

    class OrderDemostrator
    {
        private Order order;

        internal Order Order
        {
            get { return order; }
            set { order = value; }
        }
        public void Print() {/*...*/}
        public void Show() {/*...*/}
    }

    class OrderAdmin
    {
        private Order order;

        internal Order Order
        {
            get { return order; }
            set { order = value; }
        }

        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }
    class Program
    {
        static void Main()
        {
        }
    }
}