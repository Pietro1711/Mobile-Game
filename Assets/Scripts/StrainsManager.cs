using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StrainsManager : MonoBehaviour
{

    public GameManager GM;

    public Text levelDisp;
    public Text costDisp;
    public Text IPSDisp;
    public Slider strainBar;

    public int level;
    public float cost;
    public float IPSAdd;
    public int time;
    public int maxTime;


    // Use this for initialization
    void Start()
    {

        StartCoroutine(AutoTick());
        strainBar.maxValue = maxTime;
    }

    // Update is called once per frame
    void Update()
    {

        if (level <= 0)
        {
            time = 0;
        }

        strainBar.value = time;

        if(time >= maxTime)
        {
            GM.infections += IPSAdd;
            time = 0;
        }
    }

    public void OnPurchase()
    {
        if (GM.plaguePoints >= cost)
        {
            GM.plaguePoints -= cost;
            level += 1;
            IPSAdd = Mathf.Round(IPSAdd * 1.15f);
            cost = Mathf.Round(cost * 1.05f);

        }
    }

    private void timeAdd()
    {
        time += 1;
    }

    IEnumerator AutoTick()
    {

        while (true)
        {
            timeAdd();
            yield return new WaitForSeconds(1);
        }


    }
}