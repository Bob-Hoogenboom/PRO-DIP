using System;

public class BoostMushroom : PickupBase
{
    private int Duration = 5;
    public void speed(){
        Console.WriteLine("Speed =" + cc);
    }
    public void invinciblity(){
        Console.WriteLine("Invincibility = 1");
    }
    
    public void duration(){
        Console.WriteLine("Duration =" + Duration);
    }
}
