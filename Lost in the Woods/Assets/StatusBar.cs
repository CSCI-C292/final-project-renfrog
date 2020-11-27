using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusBar : MonoBehaviour
{

    float currentScore = 1.0f;
    [SerializeField] Image healthBar;
    int down = 0;
    bool duringDay = true;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DecreaseScore", 0.1f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseStatus(float amount )
    {
        currentScore += amount;
        SetHealth(currentScore);
    }

    public void DecreaseScore()
    {
        if(duringDay){
            currentScore -= 0.1f;
            float newAmount = currentScore;
            SetHealth(newAmount);
        }
    }

    public void SetHealth(float amount)
    {
        healthBar.fillAmount = amount;
    }

}
