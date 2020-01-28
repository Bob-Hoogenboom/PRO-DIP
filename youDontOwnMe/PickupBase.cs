
using System;


public class PickupBase
{

    public int cc = 100;
    public void canBePickedUp(){
        Console.WriteLine("This item can be picked up");
    }
    
    public void resetTimer(){
        Console.WriteLine("This item has a resetTimer of 15");
    }

}
