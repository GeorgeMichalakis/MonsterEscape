using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDetection : MonoBehaviour
{
    [SerializeField]
    private Transform cardQ;
    [SerializeField]
    private Transform cardE;
    [SerializeField]
    private int closeToCard = 100;
    private void Update()
    {
        Debug.Log(cardQ.InverseTransformDirection(transform.position).magnitude);
    }
}
