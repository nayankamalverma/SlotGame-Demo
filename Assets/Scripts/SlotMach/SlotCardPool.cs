using System.Collections.Generic;
using UnityEngine;

public class SlotCardPool : GenericObjectPool<CardType>
{
    private List<SlotCardScriptableObject> cardPrefabList;

    protected override GameObject CreateItem(CardType cardType)
    {
        return GameObject.Instantiate(card);
    }

    public void GetCardObject(List<SlotCardScriptableObject> cardPrefabList)
    {
        this.cardPrefabList = cardPrefabList;
    }

}
