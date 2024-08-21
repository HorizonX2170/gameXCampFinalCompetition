using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class busInventory : MonoBehaviour
{
    public int NumberofPassanger { get; private set; }
    public UnityEvent<busInventory> OnPassangerPickUp;

    public void PassangerPickUp()
    {
        NumberofPassanger++;
        OnPassangerPickUp.Invoke(this); 
    }


}
