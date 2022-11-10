using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singly_linked_list
{
    class Node
    {
        public int noMhs;
        public string nama;
        public Node next;
    }
    class List
    {
        Node START;
        public List()
        {
            START = null;
        }
        //Method untuk menambahkan sebuah node kedalam list

        public void addNote()
        {
            int nim;
            string nm;
            Console.WriteLine("\nMasukkan nomor Mahasiswa");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nMasukkan nama Mahasiswa");
            nm = Console.ReadLine();

        }
    }
    internal class program
    {
        static void Main(string[] args)
        {
        }
    }
}


