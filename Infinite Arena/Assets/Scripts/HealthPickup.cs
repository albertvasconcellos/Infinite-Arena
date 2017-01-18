using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour {

    #region Private Variables

    [SerializeField] private float healthToIncrease;
    [SerializeField] private bool isActive;

    #endregion

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && isActive == true)
        {
            other.GetComponent<PlayerStats>().incrementHP(healthToIncrease);
            //TODO: Play Health Pickup sound here
            Destroy(this.gameObject);
        }
    }
}
