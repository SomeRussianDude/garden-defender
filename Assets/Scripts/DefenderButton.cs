using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        ButtonSelected();
    }

    private void ButtonSelected()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(51, 51, 51, 255);
        }

        GetComponent<SpriteRenderer>().color = Color.white;
    }
}