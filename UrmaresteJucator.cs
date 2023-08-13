using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrmaresteJucator : MonoBehaviour
{
    public Transform Jucator;

    void Update()
    {
        transform.LookAt(Jucator);
    }
}
