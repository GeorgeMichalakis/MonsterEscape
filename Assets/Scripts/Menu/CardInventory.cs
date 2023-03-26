using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardInventory : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI cardQ;
    [SerializeField]
    private TextMeshProUGUI cardE;
    void OnEnable()
    {
        CardDetection.onCardPicked += IncreaseCardQ;
    }


    void OnDisable()
    {
        CardDetection.onCardPicked -= IncreaseCardQ;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            int prevVal = int.Parse(cardQ.text);
            prevVal--;
            cardQ.text = prevVal.ToString();
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            int prevVal = int.Parse(cardE.text);
            prevVal--;
            cardE.text = prevVal.ToString();
        }
    }

    public void IncreaseCardQ()
    {
        int prevVal = int.Parse(cardQ.text);
        prevVal++;
        cardQ.text = prevVal.ToString();
    }
}
