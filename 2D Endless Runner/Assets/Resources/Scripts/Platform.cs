using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

    private Universe universeSS;

    void Awake()
    {
        universeSS = GameObject.FindGameObjectWithTag("Universe").GetComponent<Universe>();
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}

    void Move ()
    {
        GetComponent<Transform>().Translate(new Vector3(universeSS.scrollingSpeed, 0, 0) * Time.deltaTime);
    }
}
