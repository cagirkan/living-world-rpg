using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector2 moveInput;

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Update()
    {
        Vector3 dir = new Vector3(moveInput.x, 0, moveInput.y);
        transform.Translate(dir.normalized * moveSpeed * Time.deltaTime, Space.World);
    }
}
