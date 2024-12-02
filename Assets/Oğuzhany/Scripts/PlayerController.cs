using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Input")]
    private float moveInput;
    private float turnInput;

    private void InputManagement()
    {
        moveInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
    }
}
