using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

    private Universe universeSS;
    private PlatformManager terrainManagerSS;

    void Awake()
    {
        universeSS = GameObject.FindGameObjectWithTag("Universe").GetComponent<Universe>();
        terrainManagerSS = GameObject.Find("TerrainManager").GetComponent<PlatformManager>();
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Move();

        //Once the terrain set scrolls 2 screens behind the player, recycle back into queue in front of player
        if (transform.position.x < (0 - terrainManagerSS.terrainSpacing * 2))
        {
            transform.position = new Vector3(terrainManagerSS.terrainSpacing * 8, 0, 0);
        }

	}

    void Move ()
    {
        GetComponent<Transform>().Translate(new Vector3(universeSS.scrollingSpeed, 0, 0) * Time.deltaTime);
    }
}
