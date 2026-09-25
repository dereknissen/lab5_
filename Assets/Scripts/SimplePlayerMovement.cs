using Unity.Hierarchy;
using Unity.VectorGraphics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class SimplePlayerMovement : MonoBehaviour
{
    public float moveForce = 20f;
    public Transform startArea;
    private Rigidbody rb;
    private Vector3 moveDirection;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        moveDirection = Vector3.zero;
        if (Keyboard.current == null)
            return;
        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
            moveDirection += Vector3.forward;
        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
            moveDirection += Vector3.back;
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
            moveDirection += Vector3.left;
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
            moveDirection += Vector3.right;
        moveDirection = moveDirection.normalized;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Obstacle" | collision.gameObject.name == "Water")
        {
            print("TODO: restart game, move to beginning");
            rb.position = startArea.position + new Vector3(0, 2f, 0);
        }    
        if (collision.gameObject.name == "Goal")
        {
            print("TODO: player won the game");
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(moveDirection * moveForce, ForceMode.Acceleration);
    }
}