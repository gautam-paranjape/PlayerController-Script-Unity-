using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 3;
    private Vector2 rotation = Vector2.zero;

    public float walkSpeed = 6;
    float forwardMovement;
    float sideMovement;

    bool isGrounded = false;
    bool isJumping;

    public GameObject Player;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //MouseLook
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += Input.GetAxis("Mouse Y");

        rotation.x = Mathf.Clamp(rotation.x, -15f, 15);

        transform.eulerAngles = new Vector2(0, rotation.y) * rotationSpeed;
        Camera.main.transform.localRotation = Quaternion.Euler(rotation.x * rotationSpeed, 0, 0);

        //Movement
        forwardMovement = Input.GetAxis("Vertical") * walkSpeed;
        sideMovement = Input.GetAxis("Horizontal") * walkSpeed;

        rb.velocity = (transform.forward * forwardMovement) + (transform.right * sideMovement) + (transform.up * rb.velocity.y);

        //Jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isJumping = true;
        }
    }

    private void FixedUpdate()
    {
        if (isJumping)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            isGrounded = false;
            isJumping = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
