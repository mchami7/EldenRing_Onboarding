using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Key Item", order = 1, fileName = "New Key Item")]
public class KeyItemsData : ScriptableObject
{
    public string Title;
    public string Description;
    public Sprite Image;
    public string Type;
}
