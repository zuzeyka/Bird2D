using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    public bool isWKeyEnable { get; set; }
    public float pipeState { get; set; }
    public float foodState { get; set; }

    private void Start()
    {
        if(PlayerPrefs.GetString("Toggle") != null)
        {
            LoadSettings();
        }
        else
        {
            isWKeyEnable = GameObject.Find("Toggle").GetComponent<Toggle>().isOn;
            pipeState = GameObject.Find("PipeSL").GetComponent<Slider>().value;
            foodState = GameObject.Find("FoodSlider").GetComponent<Slider>().value;
        }
        
    }
    private void LoadSettings()
    {
        if (PlayerPrefs.GetString("Toggle") == "True")
        {
            isWKeyEnable = true;
        }
        else
        {
            isWKeyEnable = false;
        }
        pipeState = PlayerPrefs.GetFloat("PipeSL");
        foodState = PlayerPrefs.GetFloat("FoodSlider");
        Debug.Log("Loaded toggle" + GameObject.Find("Toggle").GetComponent<Toggle>().isOn);
        GameObject.Find("Toggle").GetComponent<Toggle>().isOn = isWKeyEnable;
        GameObject.Find("PipeSL").GetComponent<Slider>().value = pipeState;
        GameObject.Find("FoodSlider").GetComponent<Slider>().value = foodState;
    }
    public void WChange()
    {
        isWKeyEnable = !isWKeyEnable;
        PlayerPrefs.SetString("Toggle", isWKeyEnable.ToString());
        PlayerPrefs.Save();
    }
    public void PipeChange()
    {
        pipeState = GameObject.Find("PipeSL").GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("PipeSL", pipeState);
        PlayerPrefs.Save();

    }
    public void FoodState()
    {
        foodState = GameObject.Find("FoodSlider").GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("FoodSlider", foodState);
        PlayerPrefs.Save();

    }
}
