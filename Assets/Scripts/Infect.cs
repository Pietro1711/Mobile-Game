using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Infect : MonoBehaviour {

    public GameManager GM;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InfectClick()
    {
        GM.infections += GM.ipc;
        GM.plaguePoints += GM.pppc;
    }
}
