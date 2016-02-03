using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private Universe universeSS;

    public float jumpStr = 1500;

    void Awake ()
    {
        universeSS = GameObject.FindGameObjectWithTag("Universe").GetComponent<Universe>();
    }

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void FixedUpdate ()
    {
        if (universeSS.input_SpacePress)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpStr));
            //Debug.Log("gooby");
        }
    }
}
