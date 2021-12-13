using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    private Defender defenderPrefab;
    
    private void OnMouseDown()
    {
        SpawnDefender(GetClickedSquare());
    }

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defenderPrefab = defenderToSelect;
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
        Defender newDefender = Instantiate(defenderPrefab, squarePos, quaternion.identity) as Defender;
    }
}