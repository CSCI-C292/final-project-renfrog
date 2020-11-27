using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButton : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject button;
    private bool _shown = false;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick() {
        if (_shown){
            panel.SetActive(false);
            _shown = false;
        }
        else {
            panel.SetActive(true);
            _shown = true;
        }
    }

    //found how to change button images here: https://forum.unity.com/threads/change-ui-button-source-image-in-code.271034/

}
