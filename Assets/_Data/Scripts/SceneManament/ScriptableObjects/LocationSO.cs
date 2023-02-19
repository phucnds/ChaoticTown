using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewLocation", menuName = "Scene Data/Location")]
public class LocationSO : GameSceneSO
{
    [Header("Location specific")]
    public string locationName;
    public int enemiesCount; //Example variable, will change later
}
