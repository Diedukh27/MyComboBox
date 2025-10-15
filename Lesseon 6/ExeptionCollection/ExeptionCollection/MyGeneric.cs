namespace ExeptionCollection
{
    public class MyGeneric
    {
        private object[] items;

        public MyGeneric()
        {
             items = new object[0]; 
        }

        public void Add(object item)
        {
            int n = items.Length;
            object[] temp = new object[n+1];
            for (int i = 0; i < n; i++)
            {
                temp[i] = items[i];
            }
                temp[n] = item;
            items = temp;
        }

        public void ViewItems()
        {
            foreach (object item in items)
            {
                Console.WriteLine(item);
            }
        }
        public void Clear()
        {
            items = new object[0];
        }

        public int SearchIndex(object itemSearch)
        {
            for (int i = 0; i < items.Length; i++)
            {
                var item = items[i];
                if (items.Equals(itemSearch))
                {
                    return i;
                }
            }
                return -1;

        }

        public void Remove()
        {
            
        }
    }
}
