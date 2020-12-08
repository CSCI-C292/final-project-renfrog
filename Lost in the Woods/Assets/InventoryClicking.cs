using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InventoryClicking : MonoBehaviour
{
    [SerializeField] InventoryControl ic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WhenClicked(string name){
        int buttonNumber = Int32.Parse(name);
        ic.WhenInventoryClicked(buttonNumber);
    }
}
