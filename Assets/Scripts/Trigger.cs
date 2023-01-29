using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject Dust;


    private void Start()
    {
        Dust.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Dust.SetActive(true);
    }
}
