using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDetection : MonoBehaviour
{
    public delegate void CardPicked();
    public static event CardPicked onCardPicked;
    private void OnTriggerEnter2D(Collider2D other)
    {
        onCardPicked();
    }
}
