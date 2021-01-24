using Command.Receivers;

namespace Command.Commands
{
    public class StereoOn : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOn(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}