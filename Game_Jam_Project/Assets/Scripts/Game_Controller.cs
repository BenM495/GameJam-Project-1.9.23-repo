using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game_Controller : MonoBehaviour
{

    [SerializeField] GameObject gameManager;

    #region Player

    public GameObject Player;

    #region Player Movement
    [Space]
    [Header("Player Movement")]
    public float playerMovementSpeed;
    [Space]
    #endregion

    #region Player Attacks
    [Header("Player Attack")]
    public string[] playerWeapons;
    public int maxPlayerAttackCombo;
    [Space]
    #endregion

    #region Player Health
    [Header("Player Health")]
    public int maxPlayerHealth;
    public int currentPlayerHealth;
    [Space]
    #endregion

    #endregion

    #region Terrain Management
    [Header("Terrain Management")]
    public GameObject Terrain;
    [Space]
    #endregion

    #region Mobs

    #region Mob Movement
    [Header("Mob Movement")]
    public float mob1MovementSpeed;
    public float mob2MovementSpeed;
    public float mob3MovementSpeed;
    public float mob4MovementSpeed;
    public float mob5MovementSpeed;
    public float mob6MovementSpeed;
    [Space]
    #endregion

    #region Mob Attacks
    [Header("Mob Attacks")]
    public int mob1AttackDamage;
    public int mob2AttackDamage;
    public int mob3AttackDamage;
    public int mob4AttackDamage;
    public int mob5AttackDamage;
    public int mob6AttackDamage;
    [Space]
    #endregion

    #region Mob Health
    [Header("Mob Health")]
    public int mob1MaxHealth;
    public int mob2MaxHealth;
    public int mob3MaxHealth;
    public int mob4MaxHealth;
    public int mob5MaxHealth;
    public int mob6MaxHealth;
    [Space]
    #endregion

    #endregion

    #region Animator
    [Header("Animator")]
    public GameObject animator;
    [Space]
    #endregion

    #region Menu    
    [Header("Menu")]
    public GameObject startButton;
    public GameObject quitButton;
    #endregion


    void Start()
    {
        DontDestroyOnLoad(gameManager);
        DontDestroyOnLoad(animator);
        DontDestroyOnLoad(Camera.main);
    }

    void Update()
    {
        
    }
}
