using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passengers : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
    {
        busInventory businventory = other.GetComponent<busInventory>();
        PrometeoCarController prometeoCarController = other.GetComponent<PrometeoCarController>();

        if (businventory != null && prometeoCarController != null)
        {
        float speedInKmH = prometeoCarController.carSpeed;
     
                businventory.PassangerPickUp();
                gameObject.SetActive(false);

        }
    }
}
