using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickController : MonoBehaviour
{
    public GameObject FloatingPoint;
    private AudioSource CoinSound;
    private int Nclick;
    [SerializeField] static public int Pclick = 1;
    [SerializeField] private TMP_Text CounterText;

    void Start()
	{
        CoinSound = GetComponent<AudioSource>();
		if (CoinSound == null)
		{
            Debug.LogError("CoinSfx nulo");
		}
	}

    void OnMouseDown()
    {
        FloatingPoint.GetComponent<TextMesh>().text = Pclick.ToString();
        Instantiate(FloatingPoint, transform.position, Quaternion.identity);
        Nclick = int.Parse(CounterText.text);
        Nclick += Pclick;
        Debug.Log("Você clicou " + Nclick + " vezes!");
        CounterText.text = "" + Nclick;
        CoinSound.Play();
    }
}