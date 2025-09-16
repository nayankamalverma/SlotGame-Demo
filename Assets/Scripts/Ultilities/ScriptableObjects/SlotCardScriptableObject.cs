using UnityEngine;

[CreateAssetMenu(fileName = "SlotCardScriptableObject", menuName = "SlotCardScriptableObject")]
public class SlotCardScriptableObject : ScriptableObject
{
    public CardType cardType;
    public GameObject cardPrefab;
}