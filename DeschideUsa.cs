using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeschideUsa : MonoBehaviour
{
    public GameObject Usa;

    void OnTriggerEnter(Collider other)
    {
        Usa.GetComponent<Animator>().Play("DeschideUsa");
    }

}
