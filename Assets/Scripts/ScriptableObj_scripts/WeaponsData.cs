using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "WeaponsData", order = 3, fileName = "New Weapon Data")]
public class WeaponsData : ScriptableObject
{
    public string Title;
    public string Description;
    public Sprite Image;
    public string Type;
}
