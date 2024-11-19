using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CharacterManager : MonoBehaviour
{
    public CharacterDatabase characterDB;
    public SpriteRenderer artworkSprite;
    public Animator animator;

    private int selectedOption = 0;

    void Start()
    {
        Initialize();
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex != 0) // Assuming 0 is the main menu scene index
        {
            LoadSelectedOption();
        }
    }

    public void BoyOption()
    {
        selectedOption = 0;
        UpdateCharacter(selectedOption);
        Save();
    }

    public void GirlOption()
    {
        selectedOption = 1;
        UpdateCharacter(selectedOption);
        Save();
    }

    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
        animator.runtimeAnimatorController = character.animatorController;
    }

    public void Save()
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
        Character character = characterDB.GetCharacter(selectedOption);
        PlayerPrefs.SetString("selectedCharacterSprite", character.characterSprite.name);
        PlayerPrefs.SetString("selectedAnimatorController", character.animatorController.name);
    }

    public void Load(int selectedOption)
    {
        this.selectedOption = selectedOption;
        UpdateCharacter(selectedOption);
    }

    public void ChangeScene(int sceneID)
    {
        Save();
        SceneManager.LoadScene(sceneID);
    }

    private void Initialize()
    {
        if (PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = PlayerPrefs.GetInt("selectedOption");
            UpdateCharacter(selectedOption);
        }
        else
        {
            selectedOption = 0;
            UpdateCharacter(selectedOption);
        }
    }

    private void ResetCharacterManager()
    {
        selectedOption = 0;
        PlayerPrefs.DeleteKey("selectedOption");
        UpdateCharacter(selectedOption);
    }

    public int GetSelectedOption()
    {
        return selectedOption;
    }

    public void LoadSelectedOption()
    {
        if (PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = PlayerPrefs.GetInt("selectedOption");
            UpdateCharacter(selectedOption);
        }
    }
}