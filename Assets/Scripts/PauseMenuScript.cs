using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{

    
    public string pauseInputName;
    
    public static bool isPaused = false;
    
    public GameObject pauseMenuObeject;


    // Start is called before the first frame update
    void Start()
    {
        unPause();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(pauseInputName))
        {
            if (!isPaused)
                Pause();

            else
                unPause();

        }
    }
    public void Pause() 
    {
        pauseMenuObeject.SetActive(true);
       //
        Time.timeScale = 0f;
       // 
        isPaused = true; 

    }

    public void unPause() 
    {

        pauseMenuObeject.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

    }
}

