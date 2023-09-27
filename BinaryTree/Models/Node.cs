using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Models
{
   public class Node<T> where T:IComparable<T>
    {
        public T Data { get; private set; }
        public Node<T> Left { get; private set; }
        public Node<T> Right { get; private set; }

        public Node(T data)
        {
            Data = data;          
        }
        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }
        public bool Add(T data)
        {
            if (data == null)
            {
                return false;
            }
            int compareResult = Data.CompareTo(data);
            if (compareResult < 0)
            {
                if (Left == null)
                {
                    Left = new Node<T>(data);                   
                }
                else
                {
                    return Left.Add(data);
                }
            }
            else if (compareResult == null)
            {
                return false;
            }
            else
            {
                if (Right == null)
                {
                    Right = new Node<T>(data);
                }
                else
                {
                    return Right.Add(data);
                }
            }
            return true;
        }

    }
}

