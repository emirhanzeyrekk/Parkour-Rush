using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartUp : MonoBehaviour
{
    public Slider mouse_slider;

    private void Awake()
    {
        //Set Mouse Sensitivity on Player and Slider
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().mouseSensitivity = PlayerPrefs.GetFloat("MouseSensitivity", 220);

        mouse_slider.value = PlayerPrefs.GetFloat("MouseSensitivity", 220);

    }
}
