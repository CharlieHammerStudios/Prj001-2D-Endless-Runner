using UnityEngine;
using System.Collections;

public class PlatformManager : MonoBehaviour {

    public GameObject[] stageParts;
    public int genParts = 10;

    public float terrainSpacing = 21.5f;
    public GameObject[] someNewArray;

    public GameObject defaultStart;

	// Use this for initialization
	void Start () {
        someNewArray = new GameObject[genParts];

        someNewArray[0] = (GameObject)GameObject.Instantiate(defaultStart, new Vector3(0, 0, 0), Quaternion.identity);

        for (int i = 1; i < genParts; i++) {
            someNewArray[i] = (GameObject)GameObject.Instantiate(stageParts[Random.Range(0, stageParts.Length)], new Vector3(terrainSpacing * i, 0, 0), Quaternion.identity);
        }

    }
	
	// Update is called once per frame
	void Update () {

	}
}
