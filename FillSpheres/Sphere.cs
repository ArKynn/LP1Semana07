using System.Runtime.Intrinsics.X86;

namespace FillSpheres;

public class Sphere
{
    public Color color;
    private int radius;
    private int timesThrown;
    private readonly string name;

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

    public int GetTimesThrown()
    {
        return timesThrown;
    }

    public int GetRadius()
    {
        return this.radius;
    }

    public string GetName()
    {
        return this.name;
    }
}