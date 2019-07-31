//From scratch (use ArrayList(dynamic arr))

using System;
using System.Collections;

namespace LeetCodeFirstTry
{
    //From scratch

    class Stack
    {
        private int p_index;
        private ArrayList list;

        public Stack()
        {
            list = new ArrayList();
            p_index = -1;
        }

        public int count
        {
            get { return list.Count; }
        }

        public void push(object item)
        {
            list.Add(item);
            p_index++;
        }

        public object pop()
        {
            object obj = list[p_index];
            list.RemoveAt(p_index);
            p_index--;
            return obj;
        }

        public void clear()
        {
            list.Clear();
            p_index = -1;
        }

        public object peek()
        {
            return list[p_index];
        }
    }
}

/********** Main Test **********/
/* A palindrome is a string that is spelled the same forward and backward. 
* Forexample, “dad” , “madam” , and “sees” arepalindromes, whereas “hello” is not a palindrome.
*/
static void Main(string[] args)
        {
            Stack alist = new Stack();

            string ch;
            string word = "sees";
            bool isPalindrome = true;

            for (int x = 0; x < word.Length; x++)
                alist.push(word.Substring(x, 1));

            int pos = 0;
            while (alist.count > 0)
            {
                ch = alist.pop().ToString();
                if (ch != word.Substring(pos, 1))
                {
                    isPalindrome = false;
                    break;
                }
                pos++;
            }
            if (isPalindrome)
                Console.WriteLine(word + " is apalindrome.");
            else Console.WriteLine(word + " is not apalindrome.");

            Console.Read();
        }
