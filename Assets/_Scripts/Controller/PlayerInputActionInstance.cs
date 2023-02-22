using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputActionInstance : MonoBehaviour
{
    public static PlayerInputActionInstance instance;

    public PlayerInputAction inputActions;

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        inputActions = new PlayerInputAction();
    }
}
