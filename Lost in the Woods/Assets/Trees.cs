using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trees : MonoBehaviour
{
    [SerializeField] GameObject treeCollideText;
    [SerializeField] RuntimeData runtimeData;
    [SerializeField] GameObject waitPanel;
    [SerializeField] Item ic;

    string displayText;

    int _woodScore = 20;
    float currentSecond = 7f;
    int currentInt = 6;
    bool inTrees = false;
    bool choppingProgress = false;
    // Start is called before the first frame update
    void Start()
    {
        runtimeData.currentState = BusyEnum.NotBusy;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && inTrees){
            runtimeData.currentState = BusyEnum.Busy;
            waitPanel.SetActive(true);
            choppingProgress = true;
            currentSecond -= Time.deltaTime;
            if(currentSecond <= currentInt){
                waitPanel.GetComponent<Text>().text = currentInt + "";
                currentInt--;
            }
            if(currentInt <= 0){
                runtimeData.currentState = BusyEnum.NotBusy;
                waitPanel.SetActive(false);
                ic.OnMouseDown();
                currentSecond = 7f;
                currentInt = 6;
            }
        } 
        else if (currentSecond != 7f && inTrees){
            runtimeData.currentState = BusyEnum.Busy;
            waitPanel.SetActive(false);
            currentSecond = 7f;
            currentInt = 6;
        }
        else{
            runtimeData.currentState = BusyEnum.NotBusy;
        }
    } 
        
    

    void OnTriggerStay(Collider other)
    {
        inTrees = true;
        if(runtimeData.currentState == BusyEnum.NotBusy){
            treeCollideText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        treeCollideText.SetActive(false);
        inTrees = false;
    }
}
