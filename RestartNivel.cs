using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartNivel : MonoBehaviour
{
    public GameObject JocPierdut;

    void Start()
    {
        NumarareVieti.NrVieti -= 1;
        if (NumarareVieti.NrVieti == 0)
        {
            JocPierdut.SetActive(true);
        }
        else
        {

            SceneManager.LoadScene(1);
        }
    }
}
