using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Behavioral.Iterator
{
    internal class BufferIterator<T> : IEnumerator<Tuple<T, T>>
    {
        IEnumerator<T> _enumerator;

        public BufferIterator(IEnumerator<T> enumerator)
        {
            _enumerator = enumerator;
            Reset();
        }

        public Tuple<T, T> Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _enumerator.Dispose();
            _enumerator = null;
        }

        public bool MoveNext()
        {
            if(_enumerator.MoveNext())
            {
                Current = new Tuple<T, T>(Current.Item2, _enumerator.Current);
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _enumerator.Reset();
            if(_enumerator.MoveNext())
            {
                Current = new Tuple<T, T>(default, _enumerator.Current);
            }
            else
            {
                Current = default;
            }
        }
    }
}
