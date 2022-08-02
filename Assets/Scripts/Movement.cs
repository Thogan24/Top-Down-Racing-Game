using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Rigidbody2D rb;
    public Camera cam;
    public float speedTrackerx;
    public float speedTrackery;
    public float speedTrackerTotal;
    public float angle;
    private GameManager GameManager;
    public GameObject GameManagerObject;
    public bool firstMovement = false;

    public Transform lastFrameTransform;
    public GameObject playerPrefab;

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
        GameManager = GameManagerObject.GetComponent<GameManager>();

        lastFrameTransform = transform;
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
            speedTrackerTotal = speedTrackerx + speedTrackery;
            lastSecondX = playerTransform.position.x;
            lastSecondY = playerTransform.position.y;
        }

        if((speedTrackerx > 0 || speedTrackery > 0) && firstMovement == false)
        {
            GameManager.startTimer = true;
            firstMovement = true;
        }

        if (speedTrackerTotal > 50)
        {
            GameObject newPlayerPrefab = Instantiate(playerPrefab, lastFrameTransform);
            Destroy(newPlayerPrefab, 0.05f);
            lastFrameTransform = transform;
            newPlayerPrefab.transform.parent = null;
        }
    }
}
