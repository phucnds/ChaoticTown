using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{

    public static CharacterManager Instance { get; private set; }

    public List<Character> characterList;

    private void Awake()
    {
        Instance = this;
        characterList = new List<Character>();
    }

    private void Start()
    {
        Character.OnAnyCharacterSpawned += Character_OnAnyCharacterSpawned;
        Character.OnAnyCharacterDead += Character_OnAnyCharacterDead;

        ActionBasic.Load();

        StartCoroutine(startAction());
        
    }

    IEnumerator startAction()
    {
        yield return new WaitForSeconds(2);
        characterList[0].StartAction(ActionBasic.Get<ActionTakeAWalk>(), World.Instance.getStartPoint());
    }

    private void Character_OnAnyCharacterSpawned(Character character)
    {
        characterList.Add(character);
    }

    private void Character_OnAnyCharacterDead(Character character)
    {
        characterList.Remove(character);
    }
}
