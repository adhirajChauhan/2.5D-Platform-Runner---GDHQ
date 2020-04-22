﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text _coinText, _liveText;
    public void UpdateCoinDisplay(int coins)
    {
        _coinText.text = "Coins: " + coins.ToString();
    }

    public void UpdateLiveDisplay(int lives)
    {
        _liveText.text = "Lives: " + lives.ToString();
    }
}
