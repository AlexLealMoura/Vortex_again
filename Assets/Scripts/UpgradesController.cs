using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradesController : MonoBehaviour
{
    private int Nclick;
    private AudioSource UpgradeSound;
    [SerializeField] private int Price;
    [SerializeField] private TMP_Text counterText;

    void Start()
    {
        UpgradeSound = GetComponent<AudioSource>();
        if (UpgradeSound == null)
        {
            Debug.LogError("upgradeSfx nulo");
        }
    }

    void OnMouseDown()
    {
        Nclick = int.Parse(counterText.text);
        if (Nclick >= Price)
        {
            Nclick -= Price;
            counterText.text = "" + Nclick;
            Price += 4; 
            ClickController.Pclick += 1;
            UpgradeSound.Play();
        }
    }
}
