using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class CreateQuestUI : MonoBehaviour
{
    private QuestData questData;

    [SerializeField] private Transform mapHolder;

    [Header("UI")]
    [SerializeField] private Image locationIcon;
    [SerializeField] private TextMeshProUGUI locationText;
    [SerializeField] private TextMeshProUGUI descriptionTxt;
    [SerializeField] private TextMeshProUGUI rewardsTxt;

    public void Create(QuestData _questData)
    {
        questData = _questData;
        locationIcon.sprite = questData.Image;
        locationText.text = questData.Location;
        descriptionTxt.text = questData.Description;

        rewardsTxt.text = "";
        foreach (string s in questData.Rewards)
            rewardsTxt.text += s + "\n";
    }

    public void ShowOnMap()
    {
        for (int i=0; i<mapHolder.transform.childCount; i++)
        {
            if (mapHolder.GetChild(i).tag == questData.ID.ToString())
            {
                Camera.main.transform.LookAt(mapHolder.GetChild(i).transform.position);
                Camera.main.fieldOfView = 20;
            }
        }
    }
}
