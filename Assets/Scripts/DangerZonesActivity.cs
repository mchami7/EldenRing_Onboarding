using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZonesActivity : MonoBehaviour
{
    [SerializeField] private MeshRenderer modelRenderer;
    [SerializeField] private Material normal_Mat;
    [SerializeField] private Material danger_Mat;

    private bool active;

    public void TurnOnOffDangerZones()
    {
        active = !active;

        if (active)
            modelRenderer.material = danger_Mat;
        else
            modelRenderer.material = normal_Mat;
    }
}
