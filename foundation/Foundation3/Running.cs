public class Running : Activity
{
    private double _distanceInKm;

    // Constructor
    public Running(DateTime date, int lengthInMinutes, double distanceInKm)
        : base(date, lengthInMinutes)
    {
        _distanceInKm = distanceInKm;
    }

    public override double GetDistance() => _distanceInKm;
    public override double GetSpeed() => (_distanceInKm / LengthInMinutes) * 60;
    public override double GetPace() => LengthInMinutes / _distanceInKm;
}
