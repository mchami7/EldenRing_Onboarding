using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "NPC", order = 2, fileName = "New NPC")]
public class NPCData : ScriptableObject
{
    public string Title;
    public string Description;
    public Sprite Image;
    public string Type;
}
