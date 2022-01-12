using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] private Defender defenderPrefab;

    private void Start()
    {
        DisplayCost();
    }

    private void DisplayCost()
    {
        Text costText = GetComponentInChildren<Text>();
        if (!costText)
        {
            Debug.LogError($"{name} has no cost text!");
        }
        else
        {
            costText.text = defenderPrefab.CoinCost.ToString();
        }
    }

    private void OnMouseDown()
    {
        ButtonSelected();
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }

    private void ButtonSelected()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);
        }

        GetComponent<SpriteRenderer>().color = Color.white;
    }
}