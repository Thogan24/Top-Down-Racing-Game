using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Rigidbody2D rb;
    public Camera cam;
    public float speedTrackerx;
    public float speedTrackery;
    public float angle;

    
    public GameObject player;
    float h;
    float s;
    float v;

    Vector2 movement;
    Vector2 mousePos;

    public Transform playerTransform;
    public float lastFrame;
    public float lastSecondX;
    public float lastSecondY;
    public float time;
    public void Start()
    {
        lastFrame = playerTransform.position.x;
        lastSecondX = playerTransform.position.x;
        lastSecondY = playerTransform.position.y;
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        Color.RGBToHSV(player.GetComponent<SpriteRenderer>().color, out h, out s, out v);
        player.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(h + Time.deltaTime * .25f, s, v);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
        //Debug.Log(lastFrame);
        //Debug.Log(playerTransform.position.x);
        //speedTracker = Mathf.Abs(playerTransform.position.x - lastFrame);
        //lastFrame = playerTransform.position.x;
        //Debug.Log(speedTracker);

        time = time + Time.deltaTime;
        if (time >= 1)
        {
            time = 0;
            speedTrackerx = Mathf.Abs(playerTransform.position.x - lastSecondX);
            speedTrackery = Mathf.Abs(playerTransform.position.y - lastSecondY);
            lastSecondX = playerTransform.position.x;
            lastSecondY = playerTransform.position.y;
        }
    }
}
