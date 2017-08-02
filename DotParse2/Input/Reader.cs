using System;
using System.Collections.Generic;

namespace DotParse.Input
{
    public interface IReader<out T>
    {
        IEnumerable<char> Source { get; }

        int Offset { get; }

        T First { get; }

        IReader<T> Rest { get; }

        IReader<T> Drop(int n);

        Position Pos { get; }

        bool AtEnd { get; }
    }

    public abstract class IReaderDefaultImpl<T> : IReader<T>
    {
        public virtual IEnumerable<char> Source => throw new NotImplementedException();
        public virtual int Offset => throw new NotImplementedException();
        public abstract T First { get; }
        public abstract IReader<T> Rest { get; }
        public IReader<T> Drop(int n)
        {
            IReader<T> reader = this;
            int count = n;
            while (count > 0)
            {
                reader = reader.Rest;
                count--;
            }

            return reader;
        }

        public Position Pos { get; }
        public bool AtEnd { get; }
    }
}