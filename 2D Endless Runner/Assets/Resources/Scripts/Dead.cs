using UnityEngine;
using System.Collections;

public class Dead : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerStay2D (Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            Debug.Log("touched");
            col.gameObject.GetComponent<Player>().isAlive = false;
            col.gameObject.transform.position = new Vector3(0, 0, 0);
        }
    }
}
