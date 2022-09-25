using UnityEngine; // Unity's Main Library for MonoBehaviour

public class Parrot : Animal // Derived Class / Inheritance
{
    [SerializeField]  // Serialize the Variable for Inspector
    private float stamina = 100; // Private Variable for Stamina

    private void Fly() // Encapsulation
    {
        Debug.Log("Flying"); // Encapsulated Action
    }

    public override void Move() // Polymorphism
    {
        if (stamina > 50) Fly(); // Check Stamina before calling Fly() Method
        else base.Move(); // Call Move() Method instead

        stamina -= 10; // Reducing Stamina
        if (stamina < 1) stamina = 0; // Keeps Stamina 0
    }

    private void Update() // Unity's Event Function / Updates Every Frame
    {
        if (stamina < 100) stamina += Time.deltaTime * 10f; // Add Stamina over time
    }
}