using System;


class PoorlyDesignedCode
{
    public void ProcessData(object data)
    {
        if (data is int && (int)data > 0 && (int)data <= 10)
        {
            Console.WriteLine("Data processed by HandlerA");
        }
        else if (data is string && ((string)data).Length > 5 && ((string)data).Length <= 10)
        {
            Console.WriteLine("Data processed by HandlerB");
        }
        else if (data is double && (double)data > 10 && (double)data <= 20)
        {
            Console.WriteLine("Data processed by HandlerC");
        }
        else
        {
            Console.WriteLine("Unable to handle the data");
        }
    }
}

// Handler interface
interface IDataHandler
{
    void SetNextHandler(IDataHandler handler);
    void HandleData(object data);
}

// Concrete handler for handling int data
class IntDataHandler : IDataHandler
{
    private IDataHandler nextHandler;

    public void SetNextHandler(IDataHandler handler)
    {
        nextHandler = handler;
    }

    public void HandleData(object data)
    {
        if (data is int && (int)data > 0 && (int)data <= 10)
        {
            Console.WriteLine("Data processed by HandlerA");
        }
        else if (nextHandler != null)
        {
            nextHandler.HandleData(data);
        }
        else
        {
            Console.WriteLine("Unable to handle the data");
        }
    }
}

// Concrete handler for handling string data
class StringDataHandler : IDataHandler
{
    private IDataHandler nextHandler;

    public void SetNextHandler(IDataHandler handler)
    {
        nextHandler = handler;
    }

    public void HandleData(object data)
    {
        if (data is string && ((string)data).Length > 5 && ((string)data).Length <= 10)
        {
            Console.WriteLine("Data processed by HandlerB");
        }
        else if (nextHandler != null)
        {
            nextHandler.HandleData(data);
        }
        else
        {
            Console.WriteLine("Unable to handle the data");
        }
    }
}

// Concrete handler for handling double data
class DoubleDataHandler : IDataHandler
{
    private IDataHandler nextHandler;

    public void SetNextHandler(IDataHandler handler)
    {
        nextHandler = handler;
    }

    public void HandleData(object data)
    {
        if (data is double && (double)data > 10 && (double)data <= 20)
        {
            Console.WriteLine("Data processed by HandlerC");
        }
        else if (nextHandler != null)
        {
            nextHandler.HandleData(data);
        }
        else
        {
            Console.WriteLine("Unable to handle the data");
        }
    }
}

// Client code
class Program
{
    static void Main(string[] args)
    {
        PoorlyDesignedCode code = new PoorlyDesignedCode();

        IDataHandler intHandler = new IntDataHandler();
        IDataHandler stringHandler = new StringDataHandler();
        IDataHandler doubleHandler = new DoubleDataHandler();

        intHandler.SetNextHandler(stringHandler);
        stringHandler.SetNextHandler(doubleHandler);

        code.ProcessData(5);        // Output: Data processed by HandlerA
        code.ProcessData("Hello");  // Output: Data processed by HandlerB
        code.ProcessData(15.0);     // Output: Data processed by HandlerC
        code.ProcessData(true);     // Output: Unable to handle the data
    }
}
