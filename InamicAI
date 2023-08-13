using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InamicAI : MonoBehaviour //SoldierAi
{
    public string tintaTag; //hitTag
    public bool JucatorDetectat = false; //jucator detectat
    public GameObject Inamic; //theSoldier
    public AudioSource SunetArmaDeFoc; 
    public bool Trage = false;
    public float TimpDeTragere = 1.5f;
    public GameObject EcranRosu;

    
    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            tintaTag = Hit.transform.tag;
        }
        if (tintaTag == "Player" && Trage == false)
        {
            StartCoroutine(InamiculTrage());

           
        }
       
    }       
    IEnumerator InamiculTrage()
    {
        EcranRosu.SetActive(false);
        Trage = true;
        Inamic.GetComponent<Animation>().Play("Default Take");
        SunetArmaDeFoc.Play();
        JucatorDetectat = true;
        Viata.Energie -= 5;
        EcranRosu.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        EcranRosu.SetActive(false);
        yield return new WaitForSeconds(TimpDeTragere);
        Trage = false;
            
    }
}
