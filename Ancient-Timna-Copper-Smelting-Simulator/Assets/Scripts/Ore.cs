﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> typeOre = new List<GameObject>();
    [SerializeField]
    private GameObject oreStorage;

    private void Awake()
    {
        Debug.Log(OVRInput.GetConnectedControllers());
    }
    private void Start()
    {
        oreStorage = GameObject.Find("Ore");
        Transform oreTransform = oreStorage.GetComponent<Transform>();
        foreach(Transform child in oreTransform)
        {
            typeOre.Add(child.gameObject);
        }
    }

    private void Update()
    {
        OVRInput.Update();

        if (OVRInput.Get(OVRInput.Button.One))
        {
            print("Voila!");
        }
    }



}
