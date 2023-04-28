using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateQuestList : MonoBehaviour
{
    [SerializeField] private GameObject questEntryPrefab;
    [SerializeField] private Transform holder;

    [SerializeField] private QuestData[] questListData;

    private void OnEnable()
    {
        for (int i=0; i<holder.childCount; i++)
            Destroy(holder.GetChild(i).gameObject);

        for (int i = 0; i < questListData.Length; i++)
        {
            GameObject g = Instantiate(questEntryPrefab, holder);
            g.GetComponent<CreateQuest>().SetData(questListData[i]);
        }

        QuestPanelResize.resizeEvent?.Invoke();

    }
}
