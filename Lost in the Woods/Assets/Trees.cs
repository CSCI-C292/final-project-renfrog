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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && inTrees){
            waitPanel.SetActive(true);
            choppingProgress = true;
            currentSecond -= Time.deltaTime;
            if(currentSecond <= currentInt){
                waitPanel.GetComponent<Text>().text = currentInt + "";
                currentInt--;
            }
            if(currentInt <= 0){
                //runtimeData.IncreaseWarmth(_woodScore);
                waitPanel.SetActive(false);
                ic.OnMouseDown();
                currentSecond = 7f;
                currentInt = 6;
            }
        } 
        else if (currentSecond != 7f && inTrees){
            waitPanel.SetActive(false);
            currentSecond = 7f;
            currentInt = 6;
        }
    } 
        
    

    void OnTriggerStay(Collider other)
    {
        inTrees = true;
        treeCollideText.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        treeCollideText.SetActive(false);
        inTrees = false;
    }
}
