using System.Runtime.Intrinsics.X86;

namespace FillSpheres;

public class Sphere
{
    private Color color;
    private int radius;
    private int timesThrown;

    public Sphere(Color color, int radius)
    {
        this.color = color;
        this.radius = radius;
        timesThrown = 0;
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
}