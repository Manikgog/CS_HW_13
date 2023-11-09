using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_13
{
    internal class DataStorage<T>
    {
        public List<T> Data;

        public DataStorage() 
        {
            Data = new List<T>();
        }

        public void AddData(T data)
        {
            Data.Add(data);
        }

        public void RemoveData(T data)
        {
            Data.Remove(data);
        }

        public bool ContainsData(T data)
        {
            return Data.Contains(data);
        }

        public void PrintData()
        {
            foreach (var item in Data)
            {
                Console.WriteLine(item.ToString());
            }
        }


    }
}
