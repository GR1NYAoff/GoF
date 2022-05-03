using IteratorPattern.Models;

namespace IteratorPattern.Logic
{
    internal class AlphabeticalOrderIterator : Iterator
    {
        private readonly WordsCollection collection;
        private int position = -1;
        private readonly bool isReverse;

        public AlphabeticalOrderIterator(WordsCollection collection, bool isReverse = false)
        {
            this.collection = collection;
            this.isReverse = isReverse;

            if (isReverse)
            {
                position = collection.GetItems().Count;
            }
        }

        public override object Current()
        {
            return collection.GetItems()[position];
        }

        public override int Key()
        {
            return position;
        }

        public override bool MoveNext()
        {
            var updatedPosition = position + (isReverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < collection.GetItems().Count)
            {
                position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            position = isReverse ? collection.GetItems().Count - 1 : 0;
        }
    }
}
