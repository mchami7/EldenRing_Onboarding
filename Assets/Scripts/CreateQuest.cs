using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateQuest : MonoBehaviour
{
    [SerializeField] private QuestData questData;

    [Header("Header")]
    [SerializeField] private TextMeshProUGUI titleTxt;
    [SerializeField] private TextMeshProUGUI locationBriefTxt;

    private GameObject questPanelUI;

    public void SetData(QuestData data)
    {
        questData = data;
        titleTxt.text = questData.Title;
        locationBriefTxt.text = "Location: " + questData.Location;
    }

    public void OpenQuestPanel()
    {
        questPanelUI = GameObject.FindGameObjectWithTag("QuestPanel");
        questPanelUI.transform.GetChild(0).gameObject.SetActive(true);
        questPanelUI.GetComponentInChildren<CreateQuestUI>().Create(questData);
    }
}
