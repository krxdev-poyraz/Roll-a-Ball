using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    /*
     * KAANIN KAMERA OFFSETLERI
    public Transform Cube;
    public Transform Camera;
    public Vector3 offset;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Camera.position = Cube.position + offset;
    }
    */
    public GameObject Ball;
    Vector3 distance;
	// Use this for initialization
	void Start ()
    {
        distance = transform.position - Ball.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        transform.position = Ball.transform.position + distance;
	}
}
