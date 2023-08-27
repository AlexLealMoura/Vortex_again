using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BuildController : MonoBehaviour
{
    private int Nclick;
    private int i = 0;
    private AudioSource BuildSound;
    [SerializeField] private int[] Price;
    [SerializeField] private TMP_Text counterText;
    public GameObject[] Nstage = new GameObject[4];
    public GameObject[] Pstage = new GameObject[3];

    void Start()
    {
        BuildSound = GetComponent<AudioSource>();
        if (BuildSound == null)
        {
            Debug.LogError("buildSfx nulo");
        }
    }

    void OnMouseDown()
    {
        Nclick = int.Parse(counterText.text);
        Debug.Log(Nclick + "//" + Price[i]);
		if(Nstage[i])
		{
            if (Nclick >= Price[i])
            {
                Nclick -= Price[i];
                counterText.text = "" + Nclick;
                Pstage[i].SetActive(false);
                Nstage[i].SetActive(true);
                BuildSound.Play();
                i += 1;
            }
        }
    }
}
