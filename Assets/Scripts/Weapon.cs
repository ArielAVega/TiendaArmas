using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private WeaponData weaponData;
    
    private void OnMouseDown()
    {
        //weaponData.PrintWeaponData();
        UIManager.Instance.UpdateUI(weaponData);
    }

}
