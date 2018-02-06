﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoldColor.Config;

public class ReserveController : MonoBehaviour {

    public GameObject Info;
    public GameObject GameBody;
    private Color _camp;
    public GameObject Interact;
    public Color Camp
    {
        get
        {
            return _camp;
        }
    }
    private void Start()
    {
        Debug.Log("Reserve");
        _camp = GameObject.Find("InitializeController").GetComponent<Initialize>().Camp;
        GameBody.GetComponent<SpriteRenderer>().color = _camp;
    }
}
