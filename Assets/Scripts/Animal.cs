using UnityEngine; // Unity's Main Library for MonoBehaviour

public abstract class Animal : MonoBehaviour, IControllable // Base Class / Abstraction
{
    private void Walk() // Encapsulation
    {
        Debug.Log("Walking"); // Encapsulated Action
    }

    public virtual void Move() // Virtual Method / Polymorphism
    {
        Walk(); // Calling Private Method
    }
}