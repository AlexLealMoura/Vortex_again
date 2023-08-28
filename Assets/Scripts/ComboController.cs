using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ComboController : MonoBehaviour
{
    [SerializeField] private int[] ComboBuy = {1,10,50,100,999};
    [SerializeField] private TMP_Text ComboText;
    private int i = 0;

    void OnMouseDown()
    {
        i += 1;
        if (i < 4)
		{
            ComboText.text = ComboBuy[i] + "x";
        }
		else
		{
            i = 0;
            ComboText.text = ComboBuy[i] + "x";
        }
    }
}