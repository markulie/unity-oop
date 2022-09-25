using System; // System Library for NullReferenceException
using UnityEngine; // Unity's Main Library for MonoBehaviour

public class InputController : MonoBehaviour // Unity's Base Class
{
    [SerializeField] // Serialize the Variable for Inspector
    private GameObject go; // GameObject of Component IControllable
    private IControllable controllableObject; // Component IControllable

    private void Start() // Unity's Event Function / Update Once
    {
        if (!go.TryGetComponent<IControllable>(out controllableObject)) // Gets Component IControllable from GameObject
            throw new NullReferenceException("GameObject doesn't have Component IControllable"); // In case GameObject doesn't have Component IControllable
    }

    private void Update() // Unity's Event Function / Updates Every Frame
    {
        if (Input.GetMouseButtonDown(0)) controllableObject.Move(); // Waiting for Player Mouse Left Click
    }
}