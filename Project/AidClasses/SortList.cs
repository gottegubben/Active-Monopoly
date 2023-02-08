using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The SortList class is for sorting an array of type T with the keys following the element being sorted to be able to find the key after the sort is done.
    /// </summary>
    public class SortList<T>
    {
        #region Constructors:
        public SortList(T[] data)
        {
            Data = data;

            List<int> id = new List<int>();
            for (int i = 0; i < data.Length; i++)
            {
                id.Add(i);
            }
            DataId = id.ToArray();

            SortedData = new T[data.Length];
            SortedDataId = new int[data.Length];
        }
        #endregion

        #region Properties:
        //Raw (not sorted)
        public T[] Data { get; set; }
        public int[] DataId { get; set; }

        //Sorted
        public T[] SortedData { get; set; }
        public int[] SortedDataId { get; set; }
        #endregion

        #region Methods:
        //Sorts the Data array and moves the ids the same. Places them in the sorted arrays.
        public void Sort()
        {
            Array.Copy(Data, SortedData, Data.Length);
            Array.Copy(DataId, SortedDataId, DataId.Length);

            Array.Sort(SortedData, SortedDataId);
        }
        
        //The same as the previous method but sorts using a comparer.
        public void Sort(IComparer<T> comparer)
        {
            Array.Copy(Data, SortedData, Data.Length);
            Array.Copy(DataId, SortedDataId, DataId.Length);

            Array.Sort(SortedData, SortedDataId, comparer);
        }
        #endregion
    }
}
