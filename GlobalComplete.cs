using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalComplete : MonoBehaviour
{
    public GameObject GameCompletePanel;
    public GameObject gameTimer;
    void OnTriggerEnter(Collider other)
    {
        gameTimer.SetActive(false);
        GameCompletePanel.SetActive(true);
    }
}
