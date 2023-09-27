using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Models
{
    public class Tree<T> where T: IComparable<T>
    {
        public Node<T> Root { get; set; }
        public int Count { get; set; }
        public Tree()
        {
            Root = null;
            Count = 0;
        }
        public bool Add(T data)
        {
            if (data == null)
            {
                return false;
            }
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return true;
            }

            bool addResult = Root.Add(data);

            if (addResult)
            {
                Count++;
            }
            return addResult;
        }
    }
}
