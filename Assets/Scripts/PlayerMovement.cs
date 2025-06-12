using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Hýzlar")]
    public float walkSpeed = 5f;
    public float sprintSpeed = 8f;

    [Header("Zýplama & Yerçekimi")]
    public float jumpHeight = 1.5f;
    public float gravity = -9.81f;

    private CharacterController controller;
    private Vector2 moveInput;
    private bool jumpInput;
    private bool sprintInput;
    private Vector3 velocity;
    private bool isGrounded;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    // Send Messages - PlayerInput’dan çaðrýlýr
    void OnMove(InputValue val) => moveInput = val.Get<Vector2>();
    void OnJump(InputValue val) => jumpInput = val.isPressed;
    void OnSprint(InputValue val)
    {
        sprintInput = val.isPressed;
        Debug.Log("Sprint tetiklendi: " + sprintInput);
    }

    void Update()
    {
        // Ground check
        isGrounded = controller.isGrounded;
        if (isGrounded && velocity.y < 0)
            velocity.y = -2f;

        // Yürüme veya koþma hýzý
        float speed = sprintInput ? sprintSpeed : walkSpeed;
        Debug.Log("Hýz: " + speed);
        // Yatay hareket
        Vector3 move = transform.right * moveInput.x + transform.forward * moveInput.y;
        controller.Move(move.normalized * speed * Time.deltaTime);

        // Zýplama
        if (jumpInput && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            jumpInput = false; // bir kez tetikle
        }

        // Yerçekimi
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
