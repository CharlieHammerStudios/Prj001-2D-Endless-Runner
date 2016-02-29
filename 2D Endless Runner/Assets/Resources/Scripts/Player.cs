using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private Universe universeSS;

    public float jumpStr = 1500;
    public bool isGrounded = false;
    public bool isJumping = false;
    public LayerMask groundCheckLayer;
    public float groundCheckRayLength = 0.55f;
    public RaycastHit2D groundCheckRayInfo;
    public bool isAlive = true;
    public bool respawning = false;

    void Awake ()
    {
        universeSS = GameObject.FindGameObjectWithTag("Universe").GetComponent<Universe>();
    }

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        CheckForGround();
        
        if (!isAlive)
        {
            StartCoroutine("Respawn");
        }
    }

    void FixedUpdate ()
    {
        if (isGrounded && !isJumping && universeSS.input_SpacePress)
        {
            isJumping = true;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpStr));
            Debug.Log("Jump!");
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.name == "death cube")
        {
            isAlive = false;
        }
    }

    IEnumerator Respawn()
    {
        if (!respawning)
        {
            respawning = true;
            yield return new WaitForSeconds(2);
            isAlive = true;
            transform.position = GameObject.Find("SpawnPoint").transform.position;
            Debug.Log("has died and stuff");
            respawning = false;
        }
    }
    
    void CheckForGround()
    {
        groundCheckRayInfo = Physics2D.Raycast(GetComponent<Transform>().position, Vector2.down, groundCheckRayLength, groundCheckLayer);
        Debug.DrawRay(GetComponent<Transform>().position, Vector2.down * groundCheckRayLength, Color.red);

        if (groundCheckRayInfo.collider != null)
        {
            isGrounded = true;
            isJumping = false;
        }
        else
        {
            isGrounded = false;
        }
    }
}
