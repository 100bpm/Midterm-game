using TMPro;
using UnityEngine;


public class Timer : MonoBehaviour
{

    private float m_Time = 0f * 60f;

    private float timer;


    public TextMeshProUGUI FirstMinute;
    public TextMeshProUGUI SecondMinute;
    public TextMeshProUGUI FirstSecond;
    public TextMeshProUGUI SecondSecond;
    public TextMeshProUGUI FirstMillisecond;
    public TextMeshProUGUI SecondMillisecond;





    // Start is called before the first frame update
    void Start()
    {
        resetTimer();

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        UpdateTimerDisplay(timer);


    }
    private void resetTimer()
    {

        timer = m_Time;

    }


    private void UpdateTimerDisplay(float time)
    {

        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        float milliseconds = Mathf.FloorToInt((time * 1000) % 60);


        string currentTime = string.Format("{0:00}{1:00}{2:00}", minutes, seconds, milliseconds);
        FirstMinute.text = currentTime[0].ToString();
        SecondMinute.text = currentTime[1].ToString();
        FirstSecond.text = currentTime[2].ToString();
        SecondSecond.text = currentTime[3].ToString();
        FirstMillisecond.text = currentTime[4].ToString();
        SecondMillisecond.text = currentTime[5].ToString();
    }




}
