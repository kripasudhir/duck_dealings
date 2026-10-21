using UnityEngine;

public class TestDuckMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;

    [Header("Camera")]
    [SerializeField] private Transform target;
    [SerializeField] private Transform camTransform;
    [SerializeField] private float sensitivity;
    [SerializeField] private float minPitch = -30f;
    [SerializeField] private float maxPitch = 70f;

    private Vector3 offset;
    private Rigidbody rb;

    private float yaw;
    private float pitch;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        offset = target.position - camTransform.position;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        yaw += Input.GetAxis("Mouse X") * sensitivity;
        pitch -= Input.GetAxis("Mouse Y") * sensitivity;

        pitch = Mathf.Clamp(pitch, minPitch, maxPitch);
        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0f);

        camTransform.position = target.position + rotation * Vector3.back * offset.magnitude;
        camTransform.rotation = rotation;
        //
        //
        this.transform.rotation = Quaternion.Euler(0f, yaw, 0f);

        Vector3 velocity = rb.linearVelocity;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = (transform.forward * vertical + transform.right * horizontal).normalized;
        rb.linearVelocity = direction * moveSpeed + Vector3.up * velocity.y;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        void Jump()
        {
            Vector3 velocity = rb.linearVelocity;
            velocity.y = 0f;
            rb.linearVelocity = velocity;

            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }
    }
}
