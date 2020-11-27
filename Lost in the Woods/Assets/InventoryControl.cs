using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryControl : MonoBehaviour
{
    [SerializeField] List<Button> itemSlots;

    private int currentSlot = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    public void AddedItem(Item newItem){
        Button current = itemSlots.get(currentSlot);
        current.ItemIn(newItem);
    }
    */
}
