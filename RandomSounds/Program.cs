using System.Media;

internal class Program
{
    private static void Main(string[] args)
    {
        DateTime start = DateTime.Now;
        var i = 0;
        var rnd = new Random();
        while (i < 200)
        {
            while (DateTime.Now < start)
            {
                Thread.Sleep(1000);
                TimeSpan ts = start - DateTime.Now;
                Console.WriteLine((int)ts.TotalSeconds);
            }
            Console.WriteLine("Play");
            var player = new SoundPlayer("C:\\projects\\Steps\\shagi-29.wav");
            player.PlaySync();
            var sec = rnd.Next(1 * 60, 3 * 60);
            start = DateTime.Now.AddSeconds(sec);
            i++;
        }
    }
}