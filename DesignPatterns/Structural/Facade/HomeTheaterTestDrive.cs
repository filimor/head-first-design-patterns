using Facade.Subsystems;

namespace Facade
{
    public static class HomeTheaterTestDrive
    {
        private static void Main()
        {
            var amplifier = new Amplifier();
            var tuner = new Tuner();
            var dvd = new DvdPlayer();
            var cd = new CdPlayer();
            var projector = new Projector();
            var lights = new TheaterLights();
            var screen = new Screen();
            var popper = new PopcornPopper();

            var homeTheater = new HomeTheaterFacade(amplifier, tuner, dvd, cd, projector, lights, screen, popper);
            homeTheater.WatchMovie("Raiders of the Lost Ark");
            homeTheater.EndMovie();
        }
    }
}