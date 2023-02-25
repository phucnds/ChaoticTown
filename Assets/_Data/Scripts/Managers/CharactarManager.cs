using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactarManager : MonoBehaviour
{
    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform characterPrefab;
    [SerializeField] private int number = 20;


    void Start()
    {
        StartCoroutine(SpawnChar());
    }

    IEnumerator SpawnChar()
    {
        for (int i = 0; i < number; i++)
        {
            yield return new WaitForSeconds(Random.Range(5, 10));
            Instantiate(characterPrefab, transform.position, Quaternion.identity, transform);
        }
        
    }
}
