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
    [SerializeField] bool isTree;
    string name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown() {
        string objectName = item + "";
        name = objectName.Substring(0, objectName.IndexOf(" "));
        if(!isTree){
            item.SetActive(false);
        }
        ic.AddedItem(this);
    }

    public int GetHungerScore(){
        return hungerScore;
    }

    public int GetWarmthScore(){
        return warmthScore;
    }

    public string GetName(){
        return name;
    }
}
