using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Rigidbody2D rb;
    public Camera cam;
    public float speedTracker;
    public float angle;

    Vector2 movement;
    Vector2 mousePos;

    public Transform playerTransform;
    public float lastFrame;

    public void Start()
    {
        lastFrame = playerTransform.position.x;
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
        //Debug.Log(lastFrame);
        //Debug.Log(playerTransform.position.x);
        speedTracker = Mathf.Abs(playerTransform.position.x - lastFrame);
        lastFrame = playerTransform.position.x;
        Debug.Log(speedTracker);
    }
}
