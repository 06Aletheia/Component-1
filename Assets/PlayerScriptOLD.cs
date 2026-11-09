using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float speed =1f;
    [SerializeField] private float jump =5f;
    private Rigidbody body;
    [SerializeField] InputActionAsset input;
    private InputAction move;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody>();
        move = input["Player/Move"];
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputDirection = move.ReadValue<Vector2>();
        Vector3 movement = new Vector3(0, -1, 0);
        movement.x = inputDirection.x;
        movement.z = inputDirection.y;
        body.linearVelocity = movement * speed;

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            body.AddForce(Vector3.up * jump, ForceMode.Impulse); // Ensures the force is applied all at once instead of continously.
        }
    }
}
// Taken from the VLE's base script. Alongside referencing from the script within this video. https://www.youtube.com/shorts/Azh5QuGLDcU