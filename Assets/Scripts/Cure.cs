using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cure : MonoBehaviour {

    public GameManager GM;

    public float timePenalty;
    public float maxVal = 120;
    

    public UnityEngine.UI.Slider cureBar;
    public UnityEngine.UI.Slider strainsBar;

	// Use this for initialization
	void Start () {

	}

    // Update is called once per frame
    void Update()
    {
        if(GM.cure >= maxVal)
        {
            Penalty();
        }

    }
		
	
    public void Penalty()
    {
        strainsBar.maxValue = Mathf.Round(maxVal * timePenalty);
        GM.cure = 0;
    }
}
