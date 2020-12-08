using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneFade : MonoBehaviour
{
    //found a guide on how to do this here: https://www.youtube.com/watch?v=C_Ok4xC_xVU
    public Image image;

    public void StartDay(){
        StartCoroutine(In());
    }

    public void BeginNight(){
        StartCoroutine(Out());
    }
    
    IEnumerator In(){
        float time = 1f;

        while(time >0f){
            time -=Time.deltaTime;
            image.color = new Color(0f, 0f, 0f, time);
            yield return 0;
        }
    }

    IEnumerator Out(){
        float time = 0f;

        while(time < 1f){
            time +=Time.deltaTime;
            image.color = new Color(0f, 0f, 0f, time);
            yield return 0;
        }
    }
}
