using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quest", order = 4, fileName = "New Quest")]
public class QuestData : ScriptableObject
{
    public int ID;
    public string Title;
    public string Description;
    public string Location;
    public Sprite Image;
    public string[] Rewards;
}
