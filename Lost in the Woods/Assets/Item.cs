using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [SerializeField] int hungerScore;
    [SerializeField] int warmthScore;
    [SerializeField] GameObject item;
    [SerializeField] RuntimeData runtimeData;
    [SerializeField] InventoryControl ic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        Debug.Log(item + "");
        item.SetActive(false);
        ic.AddedItem(item + "");
        runtimeData.IncreaseHunger(hungerScore);
        runtimeData.IncreaseWarmth(warmthScore);
    }
}
