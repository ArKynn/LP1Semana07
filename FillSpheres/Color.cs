using System.Net.Mail;

namespace FillSpheres;

public class Color
{
    private int red;
    private int green;
    private int blue;
    private int alpha;

    public Color(int red, int green, int blue)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        alpha = 255;
    }

    public int GetRed()
    {
        return this.red;
    }

    public void SetRed(int input)
    {
        this.red = input;
    }
    
    public int GetGreen()
    {
        return this.green;
    }

    public void SetGreen(int input)
    {
        this.green = input;
    }
    
    public int GetBlue()
    {
        return this.blue;
    }

    public void SetBlue(int input)
    {
        this.blue = input;
    }
    
    public int GetAlpha()
    {
        return this.alpha;
    }

    public void SetAlpha(int input)
    {
        this.alpha = input;
    }

    public int GetGrey()
    {
        return (this.red + this.green + this.blue) / 3;
    }
}