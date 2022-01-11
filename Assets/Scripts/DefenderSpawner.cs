using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    private Defender defenderPrefab;
    private GameObject defenderParent;
    private const string DEFENDER_PARENT_NAME = "Defenders";

    private void Start()
    {
        CreateDefenderParent();
    }

    private void CreateDefenderParent()
    {
        defenderParent = GameObject.Find(DEFENDER_PARENT_NAME);
        if (!defenderParent)
        {
            defenderParent = new GameObject(DEFENDER_PARENT_NAME);
        }
    }

    private void OnMouseDown()
    {
        AttemptToPlaceDefender(GetClickedSquare());
    }

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defenderPrefab = defenderToSelect;
    }

    private void AttemptToPlaceDefender(Vector2 gridPos)
    {
        var coinDisplay = FindObjectOfType<CoinDisplay>();
        int defenderCost = defenderPrefab.CoinCost;
        if (coinDisplay.HaveEnoughCoins(defenderCost))
        {
            SpawnDefender(gridPos);
            coinDisplay.SpendCoins(defenderCost);
        }
    }

    private Vector2 GetClickedSquare()
    {
        var clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        var worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        var gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    private void SpawnDefender(Vector2 squarePos)
    {
        if (defenderPrefab != null)
        {
            Defender newDefender = Instantiate(defenderPrefab, squarePos, quaternion.identity) as Defender;
            newDefender.transform.parent = defenderParent.transform;
        }
    }
}