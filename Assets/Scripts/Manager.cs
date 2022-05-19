using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public enum MyScenes
{
    Welcome,
    Start,
    End,
}

public class Manager : MonoBehaviour
    {

    public InputField ipfKidsName;
    public TMP_InputField ipfKidsNameTMP;
    public TMP_Text displayKidsName;

    private SoRuntimeData runtimeData;


    public void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");
    }

        public void SwitchTheScene(int x)
        {
            Debug.Log("BTN Pressed, get kidsname" +ipfKidsNameTMP.text);
            runtimeData.nameKid = ipfKidsName.text;

        if(SceneManager.GetActiveScene().buildIndex == (int)MyScenes.Main)
        {
            displayKidsName.text = runtimeData.nameKid;
        }

            SceneManager.LoadScene(x);
        }

        //aus einem Skript wird die Scene geladen
        public void SwitchTheScene(MyScenes x)
        {
            SceneManager.LoadScene((int)x);
        }

    //Aufruf in inspector Onclick bei Button, generisch über parameter
    public void SwitchTheScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    //jede szene wird einzeln aufgerufen,muss dann auch für jede szene eine Methode Schreiben

    public void SwitchToWelcome()
    {
        SceneManager.LoadScene((int)MyScenes.Welcome);
    }

    private void Update()
    {
        
    }
}

  