using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Weapon Data",menuName ="Selector Weapon Data")]
public class WeaponData : ScriptableObject
{
    [SerializeField]private string weaponName;
    [SerializeField]private string description;
    [SerializeField]private int cost;
    [SerializeField]private int damage;

    public string WeaponName { get => weaponName; set => weaponName = value; }
    public string Description { get => description; set => description = value; }
    public int Cost { get => cost; set => cost = value; }
    public int Damage { get => damage; set => damage = value; }

    public void PrintWeaponData()
    {
        Debug.Log(WeaponName);
        Debug.Log(Description);
        Debug.Log(Cost);
        Debug.Log(Damage);
    }
}

