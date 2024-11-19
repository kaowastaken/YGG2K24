using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSceneCharacterManager : MonoBehaviour
{
 public CharacterDatabase characterDB;
    public SpriteRenderer artworkSprite;

    private int selectedOption;

    void Start()
    {
        Load();
        UpdateCharacter(selectedOption);
    }

    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption", 0); // Default to 0 if not set
    }

}
