using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Alphanumerische_Zahlen
{
    public class Node : IComparable
    {
        private Node _next;
        private Node _prev;
        private string _data;

        public Node Next
        {
            get
            {
                return _next;
            }
            set
            {
                _next = value;
            }
        }

        public Node Prev
        {
            get
            {
                return _prev;
            }
            set
            {
                _prev = value;
            }
        }

        public string Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        public int CompareTo(object obj)
        {
            return _data.CompareTo(((Node)obj).Data);
        }
    }

}