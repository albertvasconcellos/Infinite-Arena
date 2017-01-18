using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    #region Private Variables

    [SerializeField] private float maxHP;
    [SerializeField] private float _HP;

    #endregion

    #region Getters and Setters

    public void incrementHP(float hpToAdd)
    {
        if (hpToAdd + _HP >= maxHP)
        {
            _HP = maxHP;
        }
        else
        {
            _HP = hpToAdd + _HP;
        }
    }

    #endregion

    #region Start and Update

    // Use this for initialization
    void Start () {
        _HP = maxHP;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    #endregion
}
