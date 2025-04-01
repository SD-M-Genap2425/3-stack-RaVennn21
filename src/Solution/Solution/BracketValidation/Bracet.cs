using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BracketValidation
{

    public class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }
        public Node(string data)
        {
            Data = data;
            Next = null;
        }
    }
    public class BracketValidator
    {
        public Node Top;
        public BracketValidator()
        {
            Top = null;
        }

        public void Push(string data)
        {
            Node newNode = new Node(data);
            if (Top == null)
            {
                Top = newNode;
            }
            else
            {
                newNode.Next = Top;
                Top = newNode;
            }
        }
        public void pop()
        {
            if (Top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            else
            {
                Top = Top.Next;
            }
        }
        public bool ValidasiEkspresi(string ekspresi)
        {
            string[] l1 = ekspresi.ToCharArray().Select(c => c.ToString()).ToArray();

            for (int i = 0; i < l1.Length; i++)
            {
                if (l1[i] == "(" || l1[i] == "{" || l1[i] == "[")
                {
                    Push(l1[i]);
                }
                else if (l1[i] == ")" || l1[i] == "}" || l1[i] == "]")
                {
                    if (Top == null)
                    {
                        return false;
                    }

                    if ((l1[i] == ")" && Top.Data == "(") ||
                        (l1[i] == "}" && Top.Data == "{") ||
                        (l1[i] == "]" && Top.Data == "["))
                    {
                        pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return Top == null;
        }
    }
}
