using Assets.Scripts.Utilities;
using UnityEngine;

public class SlotCardPool : GenericObjectPool<CardType>
{
    private GameObject card;

    protected override GameObject CreateItem(CardType cardType)
    {
        return GameObject.Instantiate(card);
    }

    public void GetCardObject(GameObject card)
    {
        this.card = card;
    }

}
