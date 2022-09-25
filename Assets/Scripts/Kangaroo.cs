using UnityEngine; // Unity's Main Library for MonoBehaviour

public class Kangaroo : Animal // Derived Class / Inheritance
{
    private void Jump() // Encapsulation
    {
        Debug.Log("Jumping"); // Encapsulated Action
    }

    public override void Move() // Polymorphism
    {
        Jump(); // Overrided Actions
    }
}