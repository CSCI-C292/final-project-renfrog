﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuntimeData : MonoBehaviour
{

    [SerializeField] StatusBar hungerBar;
    [SerializeField] StatusBar warmthBar;
    public int days;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseHunger(int amount){
        float floatedAmount = (float) amount / (float) 100;
        hungerBar.IncreaseStatus(floatedAmount);
    }

    public void IncreaseWarmth(int amount){
        float floatedAmount = (float) amount / (float) 100;
        warmthBar.IncreaseStatus(floatedAmount);
    }
}
