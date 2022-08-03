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

    public Vector3 lastFrameTransform;
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
    public float fadeIntensity;
    
    public void Start()
    {
        lastFrame = playerTransform.position.x;
        lastSecondX = playerTransform.position.x;
        lastSecondY = playerTransform.position.y;
        GameManager = GameManagerObject.GetComponent<GameManager>();

        lastFrameTransform = transform.position;
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

        if((speedTrackerx > 0 || speedTrackery > 0) && firstMovement == false)
        {
            GameManager.startTimer = true;
            firstMovement = true;
        }

        if (speedTrackerTotal > 0)
        {
            GameObject newPlayerPrefab = Instantiate(playerPrefab, transform.position, transform.rotation);
            fadeIntensity = (transform.position - newPlayerPrefab.transform.position).magnitude;
            Debug.Log(fadeIntensity);
            Color color = GetComponent<SpriteRenderer>().color;
            color.a = 0.15f * (5-fadeIntensity);
            newPlayerPrefab.GetComponent<SpriteRenderer>().color = color;
            

            Destroy(newPlayerPrefab, 0.02f + (speedTrackerTotal * 0.01f)); //If its above 100 change slow down increasing
            
            newPlayerPrefab.transform.parent = null;
        }
        /*if (speedTrackerTotal > 100)
        {
            GameObject newPlayerPrefab = Instantiate(playerPrefab, lastFrameTransform);
            Destroy(newPlayerPrefab, 0.05f);
            lastFrameTransform = transform;
            newPlayerPrefab.transform.parent = null;
        }*/


        speedTrackerTotal = (transform.position - lastFrameTransform).magnitude * Time.deltaTime * 100;
        speedTrackerx = Mathf.Abs(transform.position.x - lastFrameTransform.x) * Time.deltaTime * 100;
        speedTrackery = Mathf.Abs(transform.position.y - lastFrameTransform.y) * Time.deltaTime * 100;
        /*lastSecondX = playerTransform.position.x;
        lastSecondY = playerTransform.position.y;*/
        lastFrameTransform = transform.position;
    }
}
