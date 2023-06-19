using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    void Update() // 60 // 30  // 30 - 60
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
}