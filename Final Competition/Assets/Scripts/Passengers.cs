using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passengers : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
    {
        busInventory businventory = other.GetComponent<busInventory>();

        if (businventory != null)
        {
        businventory.PassangerPickUp();
        gameObject.SetActive(false);
        }
    }
}
