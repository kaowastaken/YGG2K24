using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterDatabase", menuName = "ScriptableObjects/CharacterDatabase", order = 1)]
public class CharacterDatabase : ScriptableObject
{
    public Character[] characters;

    public Character GetCharacter(int index)
    {
        if (index >= 0 && index < characters.Length)
        {
            return characters[index];
        }
        return null;
    }

    public int CharacterCount
    {
        get { return characters.Length; }
    }
}