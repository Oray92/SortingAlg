using System;

namespace Alphanumerische_Zahlen
{
    public class Node
    {
        private Node _next;
        private Node _prev;
        private Char _data;

        public Node Next
        {
            get { return _next;}
            set { _next = value;}
        }

        public Node Prev
        {
            get { return _prev;}
            set { _prev = value;}
        }

        public Char Data
        {
            get => _data;
            set => _data = value;
        }

        
    }

}