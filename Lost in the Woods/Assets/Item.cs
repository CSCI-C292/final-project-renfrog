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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        Debug.Log("no");
        //item.SetActive(false);
        Destroy(item);
        runtimeData.IncreaseHunger(hungerScore);
        runtimeData.IncreaseWarmth(warmthScore);
    }
}
