using UnityEngine;
using System.Collections;

public class StopatBoundary : MonoBehaviour {
    public float axis;
    void OnCollisionEnter(Collision theCollision)
    {
       if (theCollision.gameObject.tag == "Paddle")
       {
            theCollision.transform.Translate(0, 0, axis);
       }
    }
	
}
