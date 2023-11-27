using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Timeline;

public class MenuScript : MonoBehaviour
{
    [SerializeField]
    private GameObject content;
    private bool isShown;
    private bool isW;
    // Start is called before the first frame update
    void Start()
    {
        isShown = content.activeInHierarchy;
        isW = true;
        ToggleMenu(isShown);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu(!isShown);
            Debug.Log("SHOWN: " + isShown);
        }
    }
    private void ToggleMenu(bool isDisplay)
    {
        isShown = !isShown;
        if (isDisplay)
        {
            content.SetActive(false);
            Time.timeScale = 1.0f;
        }
        else
        {
            content.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void CloseButtonClick()
    {
        ToggleMenu(false);
    }

    public void ControllWToggleChanged(Boolean value)
    {
        isW = value;
    }

}
