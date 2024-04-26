using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleRotation : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(25, transform.rotation.eulerAngles.y + 1, 0);
    }
}
