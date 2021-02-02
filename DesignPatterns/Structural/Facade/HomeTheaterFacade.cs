using System;
using Facade.Subsystems;

namespace Facade
{
    public class HomeTheaterFacade
    {
        private readonly Amplifier _amplifier;
        private readonly CdPlayer _cd;
        private readonly DvdPlayer _dvd;
        private readonly TheaterLights _lights;
        private readonly PopcornPopper _popper;
        private readonly Projector _projector;
        private readonly Screen _screen;
        private readonly Tuner _tuner;

        public HomeTheaterFacade(Amplifier amplifier, Tuner tuner, DvdPlayer dvdPlayer, CdPlayer cdPlayer,
            Projector projector, TheaterLights lights, Screen screen, PopcornPopper popper)
        {
            _amplifier = amplifier;
            _tuner = tuner;
            _dvd = dvdPlayer;
            _cd = cdPlayer;
            _projector = projector;
            _lights = lights;
            _screen = screen;
            _popper = popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _popper.On();
            _popper.Pop();
            _lights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amplifier.On();
            _amplifier.SetDvd(_dvd);
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(5);
            _dvd.On();
            _dvd.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            _popper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amplifier.Off();
            _dvd.Stop();
            _dvd.Eject();
            _dvd.Off();
        }
    }
}