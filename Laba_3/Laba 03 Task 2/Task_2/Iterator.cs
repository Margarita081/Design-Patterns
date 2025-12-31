using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Laba_03_Task_2.Task_2
{

    public class WordCollection : IEnumerable<string>
    {
        private readonly List<string> _words = new();
        public void Add(string word) => _words.Add(word);

        public IEnumerator<string> GetEnumerator()
        {
            return new WordEnumerator(_words);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class WordEnumerator : IEnumerator<string>
    {
        private readonly List<string> _word;
        private int _index = -1;

        public WordEnumerator(List<string> words)
        {
            _word = words;
        }

        public string Current { get; private set; }
        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _index++;
            if (_index < _word.Count)
            {
                Current = _word[_index];
                return true;
            }
            return false;
        }

        public void Dispose() { }
        public void Reset() => _index = -1;
    }

}
