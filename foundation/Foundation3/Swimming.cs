
public class Swimming : Activity
{
    private int laps;
    private const double LapLengthInKm = 0.05; // 50 meters in kilometers

    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance() => laps * LapLengthInKm;
    public override double GetSpeed() => (GetDistance() / LengthInMinutes) * 60;
    public override double GetPace() => LengthInMinutes / GetDistance();
}
