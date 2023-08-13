using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Extraterestru : MonoBehaviour
{
    public int ViataExtraterestru = 20;
    public bool ExtraterestruMort = false;
    public GameObject ExtraterestruAI;
    public GameObject Inamic;
    public GameObject ArmaExtraterestru;
    public GameObject Plan;


    void ExtraterestruLovit (int damageAmaount)
    {
        ViataExtraterestru -= damageAmaount;
    }

    void Update()
    {
        if(ViataExtraterestru <= 0 && ExtraterestruMort == false)
        {        
                ExtraterestruMort = true;
                Inamic.GetComponent<Animation>().Play("Death");
                Plan.GetComponent<Animation>().Play("metarigAction");
                Plan.GetComponent<Animation>().Play("Death");
                ExtraterestruAI.SetActive(false);
                Inamic.GetComponent<Renderer>().enabled = false;
                Inamic.GetComponent<BoxCollider>().enabled = false;
                ArmaExtraterestru.GetComponent<Renderer>().enabled = false;          
        }
    }
}
