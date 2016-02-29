using UnityEngine;
using System.Collections;

public class Dead : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerStay (Collider col)
    {

        if (col.gameObject.tag == "Player")
        {
            Debug.Log("touched");
            col.gameObject.GetComponent<Player>().isAlive = false;
            col.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - 50, transform.position.z);
        }
    }
}
