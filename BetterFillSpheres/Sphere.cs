namespace BetterFillSpheres;

public class Sphere
{
    public Color color;
    public int radius { get; set; }
    public int timesThrown { get; set; }
    public string name { get; }

    public Sphere(Color color, int radius, string name)
    {
        this.color = color;
        this.radius = radius;
        timesThrown = 0;
        this.name = name;
    }

    public void Pop()
    {
        this.radius = 0;
    }

    public void Throw()
    {
        if (this.radius > 0)
        {
            timesThrown++;
        }
    }
}
