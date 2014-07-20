using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Predlojenie
    {
        public int _maxChars = 0;                          
        public string _sentance = "";                       
        public string[] _words = {};                        
        public int _chars = 0;                             
                                                            
                                                            
        private char[] _ch = { '.', ',', '!', '?', '/', ':', ';', '"', '-' };
        public Predlojenie(int maxChars, string sentance)
        {
            _maxChars = maxChars;
            _sentance = sentance;
            for (int i = 0; i < _sentance.Length; i++)
            {
                for (int j = 0; j < _ch.Length; j++)
                {
                    if (_sentance[i] == _ch[j])
                        _chars++;
                }
            }

            _words = _sentance.Split(' ');
        }

        public string ReverseSentance()
        {
            string sentance = "";
            for (int i = _words.Length - 1; i >= 0; i--)
            {

                string[] word = _words[i].Split(_ch);
                sentance += word[0].ToLower() + " ";
            }
            return sentance;
        }

        public string SearchSentanse(int index)
        {
      
            if (index > 0 && index < _words.Length)
            {
           
                string[] word = _words[index].Split(_ch);
                return word[0];
            }
            else
                return "Слова с таким индексом в данном предложении не существует.";
        }
    }
}
