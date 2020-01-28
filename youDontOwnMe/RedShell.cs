using System;

public class RedShell : PickupBase
{

    private string Follow = "follow";
    public void speed(){
        Console.WriteLine("Speed =" + cc);
    }
    public void ability(){
        Console.WriteLine("ability =" + Follow);
    }
    
    public void duration(){
        Console.WriteLine("Duration = until hit");
    }
}