using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObject/Enemy", order = 1)]

public class EnemyData : ScriptableObject
{
    // ScriptableObject holds some data for us that we can change

    public int hp;
    public int damage;
    public float speed;

}
