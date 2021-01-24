using System;

namespace Command.Receivers
{
    public class Light
    {
        private readonly string _location;
        private int _level;

        public Light(string location)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine($"{_location} Light is On");
        }

        public void Off()
        {
            Console.WriteLine($"{_location} Light is Off");
        }

        public void Dim(int level)
        {
            _level = level;

            if (level == 0)
            {
                Off();
            }
            else
            {
                Console.WriteLine($"Light is dimmed to {_level} %");
            }
        }

        public int GetLevel()
        {
            return _level;
        }
    }
}