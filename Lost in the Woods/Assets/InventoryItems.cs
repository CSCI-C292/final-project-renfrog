using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButton1 : MonoBehaviour
{
    [SerializeField] Button thisButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ItemIn(Item newItem){
        Image buttonImage = thisButton.GetComponent<Image>();
        Sprite newImage = GameObject.Find("applePicture").GetComponent<Sprite>();
        buttonImage.sprite = newImage;
    }
}
