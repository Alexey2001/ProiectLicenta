using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaLaser : MonoBehaviour
{
    public GameObject ArmaJucator;
    public GameObject FocArma;
    public AudioSource SunetArma;
    public bool Trage = false;
    public float DistantaTinta;
    public int viata = 5;
   
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Trage == false)
            {
                StartCoroutine(ArmaDeFoc());
            }
            
        }
    }
    IEnumerator ArmaDeFoc()
    {
        RaycastHit proiectil; 
        Trage = true;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out proiectil))
        {
            DistantaTinta = proiectil.distance;
            proiectil.transform.SendMessage("ExtraterestruLovit",viata, SendMessageOptions.DontRequireReceiver);
        }
        ArmaJucator.GetComponent<Animator>().Play("Recul");
        FocArma.SetActive(true);
        SunetArma.Play();
        yield return new WaitForSeconds(0.05f);
        FocArma.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        ArmaJucator.GetComponent<Animator>().Play("New State");
        Trage = false;
    }
}
