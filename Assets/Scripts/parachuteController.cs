using UnityEngine;
using System.Collections;

public class parachuteController : MonoBehaviour {

    public GameObject player;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(player.transform.position.x - 1.61f, player.transform.position.y + 4.4f, player.transform.position.z - 0.5f);

	}
}
