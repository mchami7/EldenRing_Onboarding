using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateKeyItem : MonoBehaviour
{
    [SerializeField] private KeyItemsData keyItemData;
    [SerializeField] private Transform holder;
    [SerializeField] private GameObject entityPrefab;

    public void CreateInfo()
    {
        if (holder.childCount > 0)
            Destroy(holder.GetChild(0).gameObject);

        GameObject entity = Instantiate(entityPrefab, holder);
        entity.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = keyItemData.Title;
        entity.transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().text = keyItemData.Description;
        entity.transform.GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = keyItemData.Type;
        entity.transform.GetChild(0).GetChild(3).GetComponent<Image>().sprite = keyItemData.Image;
        entity.SetActive(true);
    }
}
