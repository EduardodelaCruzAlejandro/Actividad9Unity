using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Weapon Data", menuName ="Weapon Data")]

public class WeaponData : ScriptableObject
{
    [SerializeField] private string weaponName;
    [SerializeField] private string description;
    [SerializeField] private int cost;
    [SerializeField] private int damage;

    public string WeaponName { get { return weaponName; } }
    public string Description { get { return description; } }
    public int Cost { get { return cost; } }
    public int Damage { get { return damage; } }
}

