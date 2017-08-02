using System.Linq.Expressions;

namespace DotParse.Input
{
    public interface IPositional
    {
        IPosition Pos { get; }

        IPositional SetPos(IPosition newpos);
    }

    public abstract class IPositionalDefaultImpl : IPositional
    {
        public IPosition Pos { get; protected set; } = Position.NoPosition;

        public IPositional SetPos(IPosition newPos)
        {
            if (this.Pos == Position.NoPosition)
            {
                this.Pos = Position.NoPosition;
            }

            return this;
        }
    }
}