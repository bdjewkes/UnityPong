using UnityEngine;
using System.Collections;

public class PaddleControl : MonoBehaviour {
    public GameObject p1;
    public GameObject p2;
    
	// Use this for initialization
	void Update () {
        Vector3 pos1 = p1.transform.position;
        Vector3 pos2 = p2.transform.position;
        float player1move = Input.GetAxis("P1Control");
        float player2move = Input.GetAxis("P2Control");
        p1.transform.position = new Vector3(pos1.x, pos1.y, pos1.z + player1move/2);
        p2.transform.position = new Vector3(pos2.x, pos2.y, pos2.z + player2move/2);
        
    
	}
}
