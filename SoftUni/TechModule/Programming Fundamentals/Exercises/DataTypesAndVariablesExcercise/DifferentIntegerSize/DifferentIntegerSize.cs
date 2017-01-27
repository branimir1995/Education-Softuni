using System;
public class Program
{
    public static void Main()
    {

        string number = Console.ReadLine();
        string message = "";
        bool canFit = false;
        try
        {
            sbyte sbyteNumber = sbyte.Parse(number);
            message += "* sbyte\n";
            canFit = true;
        }
        catch (Exception)
        {
        }

        try
        {
            byte byteNumber = byte.Parse(number);
            message += "* byte\n";
            canFit = true;
        }
        catch (Exception)
        {
        }

        try
        {
            short shortNumber = short.Parse(number);
            message += "* short\n";
            canFit = true;
        }
        catch (Exception)
        {
        }

        try
        {
            ushort ushortNumber = ushort.Parse(number);
            message += "* ushort\n";
            canFit = true;
        }
        catch (Exception)
        {
        }

        try
        {
            int intNumber = int.Parse(number);
            message += "* int\n";
            canFit = true;
        }
        catch (Exception)
        {
        }

        try
        {
            uint uintNumber = uint.Parse(number);
            message += "* uint\n";
            canFit = true;
        }
        catch (Exception)
        {
        }

        try
        {
            long longNumber = long.Parse(number);
            message += "* long\n";
            canFit = true;
        }
        catch (Exception)
        {
        }

        if (canFit)
        {
            Console.WriteLine("{0} can fit in:", number);
            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine("{0} can't fit in any type", number);
        }


    }
}