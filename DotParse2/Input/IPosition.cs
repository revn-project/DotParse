using System;
using System.Runtime.InteropServices;

namespace DotParse.Input
{
    public interface IPosition : IComparable<IPosition>
    {
        int Line { get; }

        int Column { get; }

        string LongString { get; }
    }
}