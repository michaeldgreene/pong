using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringL : MonoBehaviour {

    public TextMesh ScoreL;
    public phy Init;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        ScoreL.text = (int.Parse(ScoreL.text) + 1).ToString();
        Init.Start();
    }
}
