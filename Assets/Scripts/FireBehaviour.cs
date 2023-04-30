using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject _fire;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _fire.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
