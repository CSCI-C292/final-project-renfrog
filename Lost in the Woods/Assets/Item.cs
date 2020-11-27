﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] int hungerScore;
    [SerializeField] int warmthScore;
    [SerializeField] GameObject item;
    [SerializeField] RuntimeData runtimeData;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        Destroy(item);
        runtimeData.IncreaseHunger(hungerScore);
        runtimeData.IncreaseWarmth(warmthScore);
    }
}
