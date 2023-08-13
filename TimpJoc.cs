using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimpJoc : MonoBehaviour
{
    public int NumarareSecunde = 0;
    public int NumarareMinute = 0;
    public bool StartJoc = false;
    public GameObject AfisajTimp;
 
    
    void Update()
    {
        if(StartJoc == false)
        {
            StartCoroutine(Cronometru());
        }
    }
    IEnumerator Cronometru()
    {
        StartJoc = true;
        yield return new WaitForSeconds(1);
        NumarareSecunde += 1;
        if (NumarareSecunde == 60)
        {
            NumarareSecunde = 0;
            NumarareMinute += 1; 
        }
        if (NumarareSecunde <= 9)
        {
            if (NumarareMinute <= 9)
            {
               AfisajTimp.GetComponent<Text>().text = "0" + NumarareMinute + ":0" + NumarareSecunde;
            }
            else
            {
               AfisajTimp.GetComponent<Text>().text = "0" + NumarareMinute + ":0" + NumarareSecunde;
            }
        }
        else
        {
            if (NumarareMinute <= 9)
            {
                AfisajTimp.GetComponent<Text>().text = "0" +  NumarareMinute + ":" + NumarareSecunde;
            }
            else
            {
                AfisajTimp.GetComponent<Text>().text = "" + NumarareMinute + ":" + NumarareSecunde;
            }
        }
        StartJoc = false;
    }
}
