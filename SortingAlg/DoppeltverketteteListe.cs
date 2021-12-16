using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Alphanumerische_Zahlen
{
   public class DoppeltverketteteListe
    {

        private Node startNode = null;

        public void Add(string payload)
        {//set the first node
            Node newNode = new Node();
            newNode.Data = payload;
            if (startNode == null)
            {
                startNode = newNode;
            }
            else
            {   //get the last Node of the list
                Node currentNode = startNode;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;                    
                }
                currentNode.Next = newNode;
            }
            //return newNode;
        }



        public bool Remove(Node node)
        {
            if (startNode == null)
            {
                return false;
            }
            else
            {
                Node currentNode = startNode;
                if (currentNode == null)
                {
                    if (currentNode.Next != null)   // wenn startNode gelöscht werden soll und einen next hat
                    {
                        startNode = currentNode.Next;   //setze nächsten als startNode
                        startNode.Prev = null;  //lösche den alten Prev vom neuen startNode
                        currentNode.Next = null;   //lösche den Next vom alten startNode
                        return true;    //wurde gelöscht
                    }
                    else //wenn startNode gelöscht werden soll und keinen Next hat
                    {
                        startNode = null;
                        return true;    //wurde gelöscht
                    }                    
                }

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                    if (currentNode == node) // ist es der geuschte node?
                    {
                        if (currentNode != null) // wenn currentNode gelöscht werden soll und einen Next hat
                        {
                            currentNode.Prev = currentNode.Next;   //dem Prev vom currentNode seinen Next zuweisen
                            currentNode.Next = currentNode.Prev;   //dem Next vom currentNode seinen Prev zuweisen

                            currentNode.Next = null;    // currentNode Next löschen
                            currentNode.Prev = null;    // currentNode Prev löschen

                            return true;    //wurde gelöscht
                        }
                    }
                }
                return false;   //wurde kein passender Node gefunden
            }
        }


        public bool RemoveByIndex(int index)
        {
            int count = 0;
            if (startNode == null)
            {
                return false;
            }
            else
            {
                Node currentNode = startNode;
                if (index == 0)
                {
                    if (currentNode.Next != null)   // wenn startNode gelöscht werden soll und einen Next hat
                    {
                        startNode = currentNode.Next;   //setze nächsten als startNode
                        startNode.Prev = null;  //lösche den alten Prev vom neuen startNode
                        currentNode.Next = null;   //lösche den Next vom alten startNode
                        return true;    //wurde gelöscht
                    }
                    else //wenn startNode gelöscht werden soll und keinen Next hat
                    {
                        startNode = null;
                        return true;    //wurde gelöscht
                    }
                }

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                    count++;
                    if (count == index) // ist es der geuschte node?
                    {
                        if (currentNode != null) // wenn currentNode gelöscht werden soll und einen Next hat
                        {
                            currentNode.Prev = currentNode.Next;   //dem Prev vom currentNode seinen Next zuweisen
                            currentNode.Next = currentNode.Prev;   //dem Next vom currentNode seinen Prev zuweisen

                            currentNode.Next = null;    // currentNode Next löschen
                            currentNode.Prev = null;    // currentNode Prev löschen

                            return true;    //wurde gelöscht
                        }
                    }
                }
                return false;   //wurde kein passender Node gefunden
            }
        }


        public Node GetNode(int i)
        {// wenn der Parameter höher ist als die Länge der Liste, gib null zurück
            if (GetLength()  - 1 < i)
            {
                throw new IndexOutOfRangeException();
            }
            //beginne mit startNode und setzte den count um 1
            Node currentNode = startNode;

            int count = 0;
            //die schleife läuft solange nextNode nicht null ist
            while (currentNode.Next != null)
            {// ist der count gleich mit unserem Parameter "i"?
                if (count == 1)
                {// wenn der parameter dem count gleicht, gib currentNode zurück
                    return currentNode;
                }
                //wenn dem nicht so ist, überschreibe currentNode mit der nächsten Node in der liste und erhöhe den count um 1
                else
                {
                    currentNode = currentNode.Next;
                    count++;
                }
            }
            // wenn Next null ist, beende die Schleife
            return currentNode;
        }

        public int GetLength()
        {
            if (startNode == null)
            {
                return 0;
            }
            else
            {
                Node currentNode = startNode;
                //länge der Liste
                int count = 1;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                    count++;
                }
                return count;
            }
        }

        public string toString(string type)
        {
            string returnString = "";
            if (startNode == null)
            {
                return "";
            }
            else
            {
                Node currentNode = startNode;
                returnString += currentNode.Data;
                
                int count = 1;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                    returnString += " | " + currentNode.Data;
                    count++;
                }
                return returnString;
            }
        }
    }
}
