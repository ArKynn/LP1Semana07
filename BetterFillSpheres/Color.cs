namespace BetterFillSpheres;


public class Color
{
    private int red { get; set; }
    private int green { get; set; }
    private int blue { get; set; }
    private int alpha { get; set; }

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
