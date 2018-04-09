using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phy : MonoBehaviour {
    public Rigidbody rb;
    public Transform cT;
    // Use this for initialization
    public void Start () {
        float speed = 22.5F;
        List<float> dirS = new List<float> { 45F, 135F, 225F, 315F };
        float dir = dirS[Random.Range(0, 4)] * Mathf.Deg2Rad;
        rb.velocity = new Vector3(speed * Mathf.Cos(dir), 0, speed * Mathf.Sin(dir));
        rb.angularVelocity = new Vector3(0, 0, 0);
        cT.transform.position = new Vector3(0, 0.25F, Random.Range(-14F, 14F));
        cT.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update () {

    }

    public void Accelerate ()
    {
        rb.velocity *= 1.1F;
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.collider.name == "Paddle2" || collision.collider.name == "Paddle1")
        {
            Accelerate();
        }
    }
}
