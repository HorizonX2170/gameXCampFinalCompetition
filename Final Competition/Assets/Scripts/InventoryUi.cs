using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUi : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateScoreText(busInventory businventory)
    {
        scoreText.text = businventory.NumberofPassanger.ToString();
    }
}
