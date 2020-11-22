using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayManager : MonoBehaviour
{
    float timeLeft = 45.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PassTime();
    }

    private void PassTime(){
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 40.0f;
            Debug.Log( "--another day passes");
        }
    }
}
