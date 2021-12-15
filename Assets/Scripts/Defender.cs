using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] private int coinCost = 100;

    public int CoinCost => coinCost;

    public void AddCoins(int cost)
    {
        FindObjectOfType<CoinDisplay>().AddCoins(cost);
    }
}
