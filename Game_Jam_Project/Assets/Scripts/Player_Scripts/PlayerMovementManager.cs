using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class PlayerMovementManager : MonoBehaviour
{


    #region Basic Player Movement
    [Space]
    [Header("Basic Player Movement")]
    public PlayerController controller;
    public float playerMovementSpeed;
    public Vector2 movementKBAMInput;
    private Vector2 mousePosition;
    public bool canMove;
    #endregion

    #region Player Evasion
    [Space]
    [Header("Player Evasion")]
    public bool canEvade;
    private float evadeTimeStart = 0;
    public float evadeCooldown = 1f;
    public float evadeVelocity;
    public float evadeIFrameDuration;
    private Vector3 evadeVel;
    #endregion

    private void OnEnable()
    {
        controller.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controller.Gameplay.Disable();
    }

    void Start()
    { 
        InitialiseVariables();
    }

    private void InitialiseVariables()
    {
        canMove = true;
        canEvade = true;
    }

    private void Awake()
    {

        controller = new PlayerController();

        controller.Gameplay.MovementKBAM.performed += context => movementKBAMInput = context.ReadValue<Vector2>();
        controller.Gameplay.MovementKBAM.canceled += context => movementKBAMInput = Vector2.zero;


        controller.Gameplay.MousePosition.performed += context => mousePosition = context.ReadValue<Vector2>();
        controller.Gameplay.MousePosition.canceled += context => mousePosition = Vector2.zero;

    }

}
