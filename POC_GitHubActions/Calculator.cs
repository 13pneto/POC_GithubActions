namespace POC_GitHubActions;

public static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    
    public static int Subtract(int a, int b)
    {
        return a - b;
    }
    
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    
    public static double Divide(double a, double b)
    {
        return a / b;
    }
    
    public static int Modulo(int a, int b)
    {
        return a % b;
    }
    
    public static int Square(int a)
    {
        return a * a;
    }
    
    public static int Cube(int a)
    {
        return a * a * a;
    }
}