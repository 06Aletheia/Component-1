using UnityEngine;

public class NewPlayerScript : MonoBehaviour
{
    private float Horizontal;
    private float Vertical;
    public Rigidbody rb;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jump =5f;

// Variables
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(Horizontal, 0, Vertical);
        transform.Translate(movement * speed * Time.deltaTime);

        // Horizontal Movement

        if(Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jump);
        }
    }
         // Vertical Movement.

}
// Horizontal Movement Taken from: https://youtube.com/shorts/fmguXe2n4bk?si=JQLRkXFfxF_e-bz2
// Jump Taken from: https://youtube.com/shorts/fmguXe2n4bk?si=tF5c2PPciJM5oEHG