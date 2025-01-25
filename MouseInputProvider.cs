using UnityEngine;
using UnityEngine.InputSystem; // Required for InputValue
using System; // Required for Action delegate

public class MouseInputProvider : MonoBehaviour
{
    public Vector2 WorldPosition { get; private set; } // Corrected spelling here
    public event Action Clicked;
    
    private void OnLook(InputValue value)
    {
        // Corrected spelling and ensured type casting
        WorldPosition = (Vector2)Camera.main.ScreenToWorldPoint((Vector3)value.Get<Vector2>());
    }
     
    private void OnAction(InputValue _)
    {
        Clicked?.Invoke();
    }
}
