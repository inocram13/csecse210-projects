public class Cycling : Activity
{
    private double _speedInKph;

    public Cycling(DateTime date, int lengthInMinutes, double speedInKph)
        : base(date, lengthInMinutes)
    {
        _speedInKph = speedInKph;
    }

    public override double GetDistance() => (_speedInKph * LengthInMinutes) / 60;
    public override double GetSpeed() => _speedInKph;
    public override double GetPace() => 60 / _speedInKph;
}
