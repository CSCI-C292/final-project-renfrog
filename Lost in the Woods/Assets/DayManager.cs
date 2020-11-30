using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayManager : MonoBehaviour
{
    [SerializeField] GameObject eveningPanel;
    [SerializeField] GameObject nightPanel;
    [SerializeField] GameObject currentTimeText;
    [SerializeField] GameObject day1;
    [SerializeField] GameObject day2;
    [SerializeField] GameObject day3;
    [SerializeField] GameObject day4;
    [SerializeField] GameObject day5;

    float timeLeft = 50.0f;
    float currentTransperancy = 1f;
    int currentWait = 1;
    bool nighttime = false;
    private float inGameTime = 0f;
    private int inGameInt = 8;
    private Dictionary<int, string> timeTexts = new Dictionary<int, string>();
    private Dictionary<int, GameObject> gameDays = new Dictionary<int, GameObject>();
    bool dead = false;
    int currentDay = 1;
    // Start is called before the first frame update
    void Start()
    {
        PopulizeTimeText();
        nightPanel.SetActive(false);
        eveningPanel.SetActive(false);
        ChangeText();
    }

    // Update is called once per frame
    void Update()
    {
        PassTime();
    }

    void ChangeText() {
        Debug.Log(inGameInt);
        currentTimeText.GetComponent<Text>().text = "" + timeTexts[inGameInt];
    }

    private void PassTime(){
        if(!nighttime && !dead){
            timeLeft -= Time.deltaTime;
            inGameTime += Time.deltaTime;
            if (timeLeft < 0)
            {
                timeLeft = 40.0f;
                nightPanel.SetActive(true);
                nighttime = true;
            }
            else if (timeLeft < 10){
                eveningPanel.SetActive(true);
            }
            if(inGameTime >= 5){
                inGameInt++;
                inGameTime = 0;
                ChangeText();
            }
        }
        if(dead){
            currentTimeText.SetActive(false);
        }
        if(nighttime) {
            if(currentWait == 65){
                inGameTime = 0;
                inGameInt = 8;
                ChangeText();
                nighttime = false;
                currentWait = 0;
                nightPanel.SetActive(false);
                eveningPanel.SetActive(false);
                currentDay++;
                gameDays[currentDay].SetActive(true);
                gameDays[currentDay-1].SetActive(false);
            }
            currentWait++;
        }
        
        
    }

    private void PopulizeTimeText(){
        timeTexts.Add(8, "8:00am");
        timeTexts.Add(9, "9:00am");
        timeTexts.Add(10, "10:00am");
        timeTexts.Add(11, "11:00am");
        timeTexts.Add(12, "12:00pm");
        timeTexts.Add(13, "1:00pm");
        timeTexts.Add(14, "2:00pm");
        timeTexts.Add(15, "3:00pm");
        timeTexts.Add(16, "4:00pm");
        timeTexts.Add(17, "5:00pm");

        gameDays.Add(1, day1);
        gameDays.Add(2, day2);
        gameDays.Add(3, day3);
        gameDays.Add(4, day4);
        gameDays.Add(5, day5);
    }

    public void TurnDead(){
        dead = true;
    }
}
