using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text infectDisp;
    public Text ipsDisp;
    public Text ipcDisp;
    public Text plagueDisp;
    public Text pppsDisp;
    public Text pppcDisp;
    public Text stage;
    public Text date;

    public Slider cureBar;

    public float infections = 0;
    public float ips = 0;
    public float ipc = 1;
    public float plaguePoints = 0;
    public float ppps = 0;
    public float pppc = 0;
    public float cure;

    public string stageName;

    public int hours = 0;
    public int days = 0;


    // Use this for initialization
    void Start () {

        StartCoroutine(time());
        cureBar.maxValue = 120;
		
	}
	
	// Update is called once per frame
	void Update () {

        infectDisp.text = "Infections: " + infections;
        ipsDisp.text = "IPS: " + ips;
        ipcDisp.text = "IPC: " + ipc;
        plagueDisp.text = "Plague Pts: " + plaguePoints;
        pppsDisp.text = "P.P. Per Sec: " + ppps;
        pppcDisp.text = "P.P. Per Click: " + pppc;
        date.text = "Day: " + days;
        cureBar.value = cure;

        ipc = Mathf.Round(infections * 0.01f);
        pppc = Mathf.Round(ipc * 0.1f);

        if(ipc <= 1)
        {
            ipc = 1;
        }
  
	}

    private void timeAdd()
    {
        hours += 1;
        cure += 1;

        if(hours >= 24)
        {
            days += 1;
            hours = 0;
        }
    }
    IEnumerator time()
    {
        while (true)
        {
            timeAdd();
            yield return new WaitForSeconds(1);
        }
    }
}

    
