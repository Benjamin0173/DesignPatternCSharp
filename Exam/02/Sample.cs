using System;

// Poorly designed class without singleton pattern
class PoorlyDesignedClass
{
    public static int InstanceCount = 0;

    public PoorlyDesignedClass()
    {
        InstanceCount++;
    }
}

// Client code
class Program
{
    static void Main(string[] args)
    {
        PoorlyDesignedClass instance1 = new PoorlyDesignedClass();
        Console.WriteLine(PoorlyDesignedClass.InstanceCount); // Output: 1

        PoorlyDesignedClass instance2 = new PoorlyDesignedClass();
        Console.WriteLine(PoorlyDesignedClass.InstanceCount); // Output: 2

        PoorlyDesignedClass instance3 = new PoorlyDesignedClass();
        Console.WriteLine(PoorlyDesignedClass.InstanceCount); // Output: 3

        PoorlyDesignedClass instance4 = new PoorlyDesignedClass();
        Console.WriteLine(PoorlyDesignedClass.InstanceCount); // Output: 4

        PoorlyDesignedClass instance5 = new PoorlyDesignedClass();
        Console.WriteLine(PoorlyDesignedClass.InstanceCount); // Output: 5
    }
}