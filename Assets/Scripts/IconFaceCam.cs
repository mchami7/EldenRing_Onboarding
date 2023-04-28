using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconFaceCam : MonoBehaviour
{
    private void Update()
    {
        Vector3 relativePos = Camera.main.transform.position - transform.position;
        Quaternion LookAtRotation = Quaternion.LookRotation(-relativePos);

        Quaternion LookAtRotationOnly_Y = Quaternion.Euler(transform.rotation.eulerAngles.x, LookAtRotation.eulerAngles.y, transform.rotation.eulerAngles.z);

        transform.rotation = LookAtRotationOnly_Y;

    }
}
