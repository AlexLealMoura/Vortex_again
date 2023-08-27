using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradesController : MonoBehaviour
{
    private int Nclick;
    [SerializeField] private int Price;
    [SerializeField] private TMP_Text counterText;

    void OnMouseDown()
    {
        Nclick = int.Parse(counterText.text);
        if (Nclick >= Price)
        {
            Nclick -= Price;
            counterText.text = "" + Nclick;
            Price += 4; 
            ClickController.Pclick += 1;
        }
    }
}
