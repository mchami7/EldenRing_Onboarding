using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestPanelResize : MonoBehaviour
{
    public static Action resizeEvent;

    private void OnEnable()
    {
        resizeEvent += Resize;
    }

    public void Resize()
    {
        int childrenCount = transform.childCount;
        GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<RectTransform>().sizeDelta.x, 350 * childrenCount);
    }
}
