using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotController : MonoBehaviour
{
    [SerializeField] private Transform returnPos;
    [SerializeField] private Transform startPos;
    [SerializeField] private int initialNoOfImages;

    private SlotCardPool slotCardPool = new SlotCardPool();
    public bool isSpin { get; private set; } = false; 

    private void Start() {
        for (int i = 0; i < initialNoOfImages; i++)
        {
            slotCardPool.GetItem(CardType.Spade);
        }
    }
    private void Update()
    {

    } 
}
