using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    /*
    //kaanın wasd kontrol kodları
    [Range(0, 10000)]
    public float speed;
    public Rigidbody rb;
    */
    Rigidbody physics;
    public float speed;
    int Counter = 0;
    public int NumberOfObjectsToCollect;

    public Text CounterText;
    public Text GameOverText;

    // Use this for initialization
    void Start()
    {
        physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    /*void Update ()
    {
         //kaanınwasd kontrolleri
         {
            if (Input.GetKey("w"))
            {
                rb.AddForce(Vector3.forward * speed * Time.deltaTime);
            }
            if (Input.GetKey("a"))
            {
                rb.AddForce(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey("d"))
            {
                rb.AddForce(Vector3.right * speed * Time.deltaTime);
            }
            if (Input.GetKey("s"))
            {
                rb.AddForce(Vector3.back * speed * Time.deltaTime);
            }

        }
        
}
*/

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(horizontal, 0, vertical);

        physics.AddForce(vec * speed);

        //Debug.Log("horizontal = " + horizontal + "   vertical = " + vertical);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Barrier")
        {
            other.gameObject.SetActive(false);
            Counter++;

            CounterText.text = "Counter = " + Counter;

            if (Counter == NumberOfObjectsToCollect)
            {
                CounterText.text = "";
                GameOverText.text = "GAME OVER";
            }
        }
    }
}


