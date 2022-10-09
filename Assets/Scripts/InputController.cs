using UnityEngine; // Unity's Main Library for MonoBehaviour

public class InputController : MonoBehaviour // Unity's Base Class
{
    [SerializeField] // Serialize the Variable for Inspector
    private GameObject go; // GameObject of Component IControllable
    private IControllable controllable; // Component IControllable

    private void Start() // Unity's Event Function / Update Once
    {
        controllable = go.GetComponent<IControllable>(); // Gets Component IControllable from GameObject
    }

    private void Update() // Unity's Event Function / Updates Every Frame
    {
        if (Input.GetMouseButtonDown(0)) controllable.Move(); // Waiting for Player Mouse Left Click
    }
}