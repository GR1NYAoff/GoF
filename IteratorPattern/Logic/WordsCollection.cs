using System.Collections;
using System.Collections.Generic;
using IteratorPattern.Models;

namespace IteratorPattern.Logic
{
    internal class WordsCollection : IteratorAggregate
    {
        private readonly List<string> collection = new List<string>();

        bool isReverse;

        public void ReverseDirection()
        {
            isReverse = !isReverse;
        }

        public List<string> GetItems()
        {
            return collection;
        }

        public void AddItem(string item)
        {
            collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, isReverse);
        }
    }
}
