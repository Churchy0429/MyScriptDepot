using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon Type", menuName = "Weapons")]
public class weapon : ScriptableObject
{
    [SerializeField] int damage;
    [SerializeField] string weaponName;
}
