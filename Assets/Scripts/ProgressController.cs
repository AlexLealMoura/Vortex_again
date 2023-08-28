using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProgressController : MonoBehaviour
{
    public Image TimeBar;
    private int Nclick;
    private bool Tflag = false;
    //private float timeRemaining = 10;
    public float Tremaining = 10;
    public float Treset = 10;
    private AudioSource UpgradeSound;
    [SerializeField] private int Price;
    [SerializeField] static public int Tclick = 1;
    [SerializeField] private TMP_Text counterText;
    //[SerializeField] private TMP_Text ComboText;
    public GameObject FloatingPoint;

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
        if (Nclick >= Price && Treset != 1)
        {
            Nclick -= Price;
            counterText.text = "" + Nclick;
            Price += 4;
            Tclick += 1;
			if(Treset > 1)
			{
                Treset -= 0.5f;
            }
            Tflag = true;
        }
    }
    
    void Update()
    {
        Nclick = int.Parse(counterText.text);
        if (Tflag == true)
		{
            if (Tremaining >= 0)
            {
                Tremaining -= Time.deltaTime;
                TimeBar.fillAmount = Tremaining / Treset;
            }
            else
            {
                Nclick += Tclick;
                counterText.text = "" + Nclick;
                Tremaining = Treset;
                FloatingPoint.GetComponent<TextMesh>().text = Tclick.ToString();
                Instantiate(FloatingPoint,  transform.position, Quaternion.identity);
                UpgradeSound.Play();
            }
        }
    }
}
