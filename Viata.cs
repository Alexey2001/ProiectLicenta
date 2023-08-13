using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Viata : MonoBehaviour
{
    public GameObject AfisajValoare;
    public static int Energie;
    public int internalViata;

    void Start()
    {
        Energie = 100;
    }
    void Update()
    { 
        if(Energie <= 0)
        {
            SceneManager.LoadScene(2);
        }
        internalViata = Energie;
        AfisajValoare.GetComponent<Text>().text = " " + Energie + "%";
    }
}
