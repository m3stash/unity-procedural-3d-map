using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
#pragma warning disable 649

    [SerializeField] CharacterController controller;
    [SerializeField] public float speed = 12f;
    Vector2 horizontalInput;

    [SerializeField] float jumpHeight = 3.5f;
    bool jump;

    [SerializeField] float gravity = -30f; // -9.81
    Vector3 verticalVelocity = Vector3.zero;
    [SerializeField] LayerMask layerMask;
    bool isGrounded;

    void Update() {

        isGrounded = Physics.CheckSphere(transform.position, 0.1f, layerMask);

        if (isGrounded) {
            // verticalVelocity.y = 0;
        }

        Vector3 horizontalVelocity = (transform.right * horizontalInput.x + transform.forward * horizontalInput.y) * speed;
        controller.Move(horizontalVelocity * Time.deltaTime);

        if (jump) {
            if (isGrounded) {
                verticalVelocity.y = Mathf.Sqrt(-2f * jumpHeight * gravity);
            }
            jump = false;
        }

        verticalVelocity.y += gravity * Time.deltaTime;
        controller.Move(verticalVelocity * Time.deltaTime);
        /*float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        
        controller.Move(move * speed * Time.deltaTime);*/
    }

    public void ReceiveInput(Vector2 _horizontalInput) {
        horizontalInput = _horizontalInput;
    }

    public void OnJump() {
        jump = true;
    }

}
