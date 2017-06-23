using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    public class LinkedList
    {
        private class ListItem
        {
            public User Data { get; set; }
            public ListItem Next { get; set; }
        }

        private ListItem first = null;

        public void Add(User item)
        {
            ListItem li = new ListItem();
            li.Data = item;
            li.Next = null;

            if (first == null)
            {
                first = li;
                return;
            }

            ListItem iterator = first;
            while(iterator.Next != null)
            {
                iterator = iterator.Next;
            }

            iterator.Next = li;
        }

        public void RemoveAt(int index)
        {

        }

        public int Count()
        {
            return 0;
        }

        public User GetItemAt(int index)
        {
            if (first == null)
                throw new IndexOutOfRangeException();

            int counter = index;

            ListItem iterator = first;
            while (counter > 0)
            {
                counter--;
                iterator = iterator.Next;

                if (iterator == null)
                    throw new IndexOutOfRangeException();
            }

            return iterator.Data;
        }
    }
}
