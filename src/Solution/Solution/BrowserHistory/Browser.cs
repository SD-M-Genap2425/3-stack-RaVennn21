using Solution.BracketValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BrowserHistory
{
    public class Halaman
    {
        public string URL { get; set; }

        public Halaman(string url)
        {
            URL = url;
        }
    }

    public class StackNode
    {
        public Halaman Data { get; set; }
        public StackNode Next { get; set; }

        public StackNode(Halaman data)
        {
            Data = data;
            Next = null;
        }
    }
    public class HistoryManager
    {
        private StackNode Top;

        public HistoryManager()
        {
            Top = null;
        }

        public void KunjungiHalaman(string url)
        {
            Halaman newPage = new Halaman(url);
            StackNode newNode = new StackNode(newPage);
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
        public string Kembali()
        {
            if (Top.Next == null)
            {
                return "Tidak ada halaman sebelumnya.";
            }
            else
            {
                Top = Top.Next;
                return Top.Data.URL;
            }
        }
        public string LihatHalamanSaatIni()
        {
            if (Top == null)
            {
                return null;
            }
            else
            {
                return Top.Data.URL;    
            }
        }
        public void TampilkanHistory()
        {
            List<string> history = new List<string>();
            StackNode current = Top;
            while (current != null)
            {
                history.Add(current.Data.URL);
                current = current.Next;
            }
            for (int i = history.Count - 1;  i >= 0; i--)
            {
                Console.WriteLine(history[i]);
            }
        }

    }
}
