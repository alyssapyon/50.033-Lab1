using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
   void Awake()
    {
        Time.timeScale = 0.0f;
    }

    public void StartButtonClicked()
    {
        foreach (Transform eachChild in transform)
        {
            foreach (Transform grandChild in eachChild)
            {
                if (grandChild.name != "Score")
                {
                    Debug.Log("Child found. Name: " + grandChild.name);
                    // disable them
                    grandChild.gameObject.SetActive(false);
                    Time.timeScale = 1.0f;
                }
            }
        }
    }
}
