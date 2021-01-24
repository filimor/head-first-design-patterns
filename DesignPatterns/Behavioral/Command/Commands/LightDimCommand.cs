using Command.Receivers;

namespace Command.Commands
{
    public class LightDimCommand : ICommand
    {
        private readonly int _level;
        private readonly Light _light;
        private readonly int _previousLevel;

        public LightDimCommand(Light light, int level)
        {
            _light = light;
            _previousLevel = _level;
            _level = level;
        }

        public void Execute()
        {
            _light.Dim(_level);
        }

        public void Undo()
        {
            _light.Dim(_previousLevel);
        }
    }
}