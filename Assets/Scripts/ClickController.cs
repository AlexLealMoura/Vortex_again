using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickController : MonoBehaviour
{
    public GameObject FloatingPoint;
    private int Nclick;
    [SerializeField] static public int Pclick = 1;
    [SerializeField] private TMP_Text counterText;


    void OnMouseDown()
    {
        Instantiate(FloatingPoint, transform.position, Quaternion.identity);
        Nclick = int.Parse(counterText.text);
        Nclick += Pclick;
        Debug.Log("Você clicou " + Nclick + " vezes!");
        counterText.text = "" + Nclick;
    }
}