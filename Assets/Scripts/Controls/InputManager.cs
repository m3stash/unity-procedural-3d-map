using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
#pragma warning disable 649

    [SerializeField] PlayerMovement movement;
    [SerializeField] MouseLook mouseLook;

    public static InputManager instance;

    PlayerControls controls;
    PlayerControls.MovementsActions movementsActions;

    Vector2 horizontalIpunt;
    Vector2 mouseInput;

    private void Awake() {
        instance = this;

        // Init gameplay controls
        controls = new PlayerControls();
        movementsActions = controls.Movements;

        movementsActions.Horizontal.performed += ctx => horizontalIpunt = ctx.ReadValue<Vector2>();

        movementsActions.Jump.performed += _ => movement.OnJump();

        movementsActions.MouseX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        movementsActions.MouseY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();
    }

    private void Update() {
        movement.ReceiveInput(horizontalIpunt);
        mouseLook.ReceiveInput(mouseInput);
    }

    private void OnEnable() {
        controls.Enable();
    }
    private void OnDestroy() {
        controls.Disable();
    }
}

