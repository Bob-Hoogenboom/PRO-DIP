using System;

public class SuperFeather : PickupBase
{

    private int JumpHeight = 100;
    public void speed()
    {
        Console.WriteLine("The Speed is:" + cc + "cc" );
        
    }
    public void jump(){
        Console.WriteLine("jumphight=" + JumpHeight);
    }
    
    public void boost(){
        Console.WriteLine("boost = 100cc+");
    }
}