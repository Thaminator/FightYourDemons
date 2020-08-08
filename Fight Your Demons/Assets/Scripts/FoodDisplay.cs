using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FoodDisplay : MonoBehaviour
{
    [SerializeField] int food = 100;
    TextMeshProUGUI foodText;

    private void Start()
    {
        foodText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        foodText.text = food.ToString();
    }

    public void AddFood(int amount)
    {
        food += amount;
        UpdateDisplay();
    }

    public void SpendFood(int amount)
    {
        if (food >= amount)
        {
            food -= amount;
            UpdateDisplay();
        }
        


    }


}
