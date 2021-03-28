using System;

static class Method
{
    public static void Divide(int parameter)
    {

        int answer = parameter / 2;
        Method.Divide(parameter, answer);

    }
    public static void Divide(int parameter, int answer)
    {
        Console.WriteLine(parameter + " divided by 2 = " + answer);
        Console.ReadLine();

    }

}