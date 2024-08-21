using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class busInventory : MonoBehaviour
{
    public int NumberofPassanger { get; private set; }

    public void PassangerPickUp()
    {
        NumberofPassanger++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
