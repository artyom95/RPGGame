using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionBehaviour : MonoBehaviour
{
    private GameObject _gameObject;
    private Outline _outline;

    private void Start()
    {
        _gameObject = GameObject.FindWithTag("Player");
        _outline = _gameObject.GetComponent<Outline>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            _outline.OutlineWidth = 2f;
            Destroy(gameObject);
        }
    }
}
