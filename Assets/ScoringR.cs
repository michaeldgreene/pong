using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringR : MonoBehaviour {

    public TextMesh ScoreR;
    public phy Init;
    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    private void OnTriggerEnter(Collider other)
    {
        ScoreR.text = (int.Parse(ScoreR.text) + 1).ToString();
        Init.Start();
    }
}
