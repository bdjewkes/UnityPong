using UnityEngine;
using System.Collections;

public class BallBehavior : MonoBehaviour {
    public Vector3 direction;
    public float speed;
    public GameObject ballstart;
    public int p1score = 0;
    public int p2score = 0;
	// Use this for initialization
	void Start () 
    {
        this.direction = new Vector3(1.0f, 0, 1.0f).normalized;
        this.speed = 25f;
	}
    void Update()
    {
        this.transform.position += direction * speed * Time.deltaTime;
    }
    void OnCollisionEnter(Collision theCollision)
    {   
        if (theCollision.collider.name == "Goal")
        {
            gameObject.transform.position = ballstart.transform.position;
            if (theCollision.gameObject.tag == "P1 Goal")
            {
                p2score += 1;
                Debug.Log(p2score);
            }
            if (theCollision.gameObject.tag == "P2 Goal")
            {
                p1score += 1;
                Debug.Log(p1score);
            }
        }
        else
        {
            Vector3 normal = theCollision.contacts[0].normal;
            direction = Vector3.Reflect(direction, normal);
        }

    }
    void OnGUI()
    {
        GUI.Label(new Rect(320, 0, 150, 100),p1score.ToString());
        GUI.Label(new Rect(380, 0, 150, 100), p2score.ToString());
    }
}

