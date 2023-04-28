namespace BetterFillSpheres;


public class Color
{
    public int red { get; set; }
    public int green { get; set; }
    public int blue { get; set; }
    private int alpha { get; }

    public Color(int red, int green, int blue)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        alpha = 255;
    }

    
    public int GetGrey
    {
        get
        {
            return (this.red + this.green + this.blue) / 3;    
        }
        
    }
}    
