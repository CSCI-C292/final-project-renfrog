using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryControl : MonoBehaviour
{
    [SerializeField] List<Button> itemSlots;
    [SerializeField] RuntimeData runtimeData;
    
    List<Item> itemsList = new List<Item>();
    private int currentSlot = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void AddedItem(Item item){
        Button current = itemSlots[currentSlot];
        current.GetComponentInChildren<Text>().text = "" + item.GetName();
        itemsList.Add(item);
        currentSlot++;

    }
    
    //found out how to convert string to int here: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
    public void WhenInventoryClicked(int buttonNumber){
        try{
            Item item = itemsList[buttonNumber-1];
            Button current = itemSlots[buttonNumber-1];
            current.GetComponentInChildren<Text>().text = "";
            runtimeData.IncreaseHunger(item.GetHungerScore());
            runtimeData.IncreaseWarmth(item.GetWarmthScore());
            itemsList.RemoveAt(buttonNumber-1);
            reOrder();
        } catch(System.Exception e){   }
    }

    public void reOrder() {
        int j = 0;
        foreach (Item i in itemsList){
            Button current = itemSlots[j];
            current.GetComponentInChildren<Text>().text = i.GetName();
            j++;
        }
        currentSlot = itemsList.Count;
        for(int i = currentSlot; i < itemSlots.Count; i++){
            Button current = itemSlots[j];
            current.GetComponentInChildren<Text>().text = "";
        }
    }
    
    
}
