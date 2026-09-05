using System;

class Alarm
{
    // Declare delegate
    public delegate void RingHandler();

    // Declare event
    public event RingHandler Ring;

    public void StartAlarm()
    {
        Console.WriteLine("Alarm Started!");

        // Raise the event
        if (Ring != null)
        {
            Ring();
        }
    }
}

class Program
{
    static void ShowMessage()
    {
        Console.WriteLine("Wake up! Alarm is ringing.");
    }

    static void Main(string[] args)
    {
        Alarm alarm = new Alarm();

        // Subscribe to the event
        alarm.Ring += ShowMessage;

        // Start alarm
        alarm.StartAlarm();

        Console.ReadLine();
    }
}