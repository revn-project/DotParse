using System;
using System.Linq;
using DotParse.Utils;

namespace DotParse.Input
{
    public abstract class Position : IPosition
    {
        public abstract int Line { get; }

        public abstract int Column { get; }

        public string LongString
            => $"{this.LineContents}\n{this.LineContents.Take(this.Column - 1).Select(x => x == '\t' ? x : ' ').Join()}^";

        protected abstract string LineContents { get; }


        public int CompareTo(IPosition that)
        {
            var lineResult = this.Line - that.Line;

            return lineResult == 0
                ? this.Column - that.Column
                : lineResult;
        }

        public override string ToString()
            => $"{this.Line}.{this.Column}";
    }
}