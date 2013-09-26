using UnityEngine;
using System.Collections;

public class PaddleControl : MonoBehaviour {
    public GameObject p1;
    public GameObject p2;
    
	// Use this for initialization
	void Update () {
	        p1.transform.position += Vector3.forward * (Input.GetAxis("P1Control") / 2f);
	        p2.transform.position += Vector3.forward * (Input.GetAxis("P2Control") / 2f));
        }
}
