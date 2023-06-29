using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInput playerInput;
    
    private InputAction jumpAction;
    private void Awake() {
        playerInput = GetComponent<PlayerInput>();
        jumpAction = playerInput.actions["Jump"];
        //jumpAction.ReadValue<float>();
    }

}
