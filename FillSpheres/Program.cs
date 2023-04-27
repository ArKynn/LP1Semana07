namespace  FillSpheres;

class Program
{
    private static void Main()
    {
        Sphere red = new Sphere(new Color(255, 0, 0), 5, "red");
        Sphere green = new Sphere(new Color(0, 255, 0), 5, "green");
        Sphere blue = new Sphere(new Color(0, 0, 255), 5, "blue");

        Sphere[] allSpheres = new Sphere[] { red, green, blue }; 
        
        red.Throw();
        green.Pop();
        blue.Throw();
        
        red.Throw();
        red.Throw();

        foreach (Sphere sphere in allSpheres)
        {
            Console.WriteLine($"{sphere.GetName()} color = ({sphere.color.GetRed()}, {sphere.color.GetGreen()}, {sphere.color.GetBlue()})" +
                              $" {sphere.GetName()} radius = {sphere.GetRadius()}," +
                              $" {sphere.GetName()} times thrown = {sphere.GetTimesThrown()}");
        }
    }
}