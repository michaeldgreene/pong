using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public float initZ = 0;
    // Use this for initialization
    void Start () {
        
}

    // Update is called once per frame
    void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 point = ray.origin + (ray.direction * 25.32F);
        initZ = point.z;
        if (initZ > 13.4F) {
            initZ = 13.4F;
        } else if (initZ < -13.4F)
        {
            initZ = -13.4F;
        }
        transform.position = new Vector3(-16, 2, initZ);
        Debug.DrawLine(Vector3.zero, new Vector3(1, 1, 1), Color.red);
    }
}
