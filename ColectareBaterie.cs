using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColectareBaterie : MonoBehaviour
{
    public GameObject ObiectulColectat;
    public AudioSource SunetBaterie;
   // public GameObject pickUpDisplay;

    void OnTriggerEnter(Collider other)
    {  
        Baterie.NumarBaterii += 1;
        ObiectulColectat.SetActive(false);
        SunetBaterie.Play();
        GetComponent<BoxCollider>().enabled = false;
    }
}
