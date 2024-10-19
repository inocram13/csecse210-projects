public class BreathingActivity : Activity
{
    public BreathingActivity()
    :base("Breathing", "This activity will help you relax by guiding you through deep breathing exercises.", 60)
    {

    }
    public void Run()
    {
        DisplayStartingMessage();
        int halfDuration = _duration / 2;
        for(int i = 0; i < halfDuration; i ++)
        {
            Console.WriteLine("Hinga......");
            ShowCountDown(3);
            Console.WriteLine("Buga......");
            ShowCountDown(5);
        }
        DisplayEndMessage();
    }
}