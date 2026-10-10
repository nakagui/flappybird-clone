using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    public bool JumpIsPressed { get; private set; }

    public void OnJump()
    {
        JumpIsPressed = true;
    }

    public void EndJump()
    {
        Debug.Log("Jump");
        JumpIsPressed = false;
    }
}
