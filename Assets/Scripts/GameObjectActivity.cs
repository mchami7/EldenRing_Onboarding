using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectActivity : MonoBehaviour
{
    [SerializeField] private GameObject[] obj;
    private bool active;

    public void Destroy()
    {
        foreach (GameObject go in obj)
            Destroy(go);
    }

    public void SetActiveFalse()
    {
        foreach(GameObject go in obj)   
            go.SetActive(false);
    }

    public void SetActiveTrue()
    {
        foreach(GameObject go in obj)   
            go.SetActive(true);
    }

    public void SetActiveTrueFalse()
    {
        active = !active;
        foreach (GameObject go in obj)
            go.SetActive(active);
    }
}
