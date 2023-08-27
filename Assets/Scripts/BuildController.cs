using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BuildController : MonoBehaviour
{
    private int Nclick;
    private int i = 0;
    [SerializeField] private int[] Price;
    [SerializeField] private TMP_Text counterText;
    public GameObject[] Nstage = new GameObject[4];
    public GameObject[] Pstage = new GameObject[3];

    void OnMouseDown()
    {
        Nclick = int.Parse(counterText.text);   
		if (Nstage[i])
		{
            if (Nclick >= Price[i] )
            {
                Nclick -= Price[i];
                counterText.text = "" + Nclick;
            }
            Pstage[i].SetActive(false);
            Nstage[i].SetActive(true);
            i += 1;
		}
    }
}
