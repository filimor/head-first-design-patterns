using System;

namespace Singleton
{
    public sealed class ChocolateBoiler
    {
        private static readonly Lazy<ChocolateBoiler> Instance = new(() => new ChocolateBoiler());

        private bool _boiled;
        private bool _empty;

        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public static ChocolateBoiler GetInstance => Instance.Value;

        public void Fill()
        {
            if (IsEmpty())
            {
                _empty = false;
                _boiled = false;
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && isBoiled())
            {
                _empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !isBoiled())
            {
                _boiled = true;
            }
        }

        public bool IsEmpty()
        {
            return _empty;
        }

        public bool isBoiled()
        {
            return _boiled;
        }
    }
}