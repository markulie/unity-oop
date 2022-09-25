using UnityEngine; // Unity's Main Library for MonoBehaviour

public class Cat : Animal // Derived Class / Inheritance
{
    public override void Move() // Polymorphism
    {
        base.Move(); // Calling Base Class Method
        Debug.Log("Moew"); // Added Actions
    }
}