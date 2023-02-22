using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerInputAction pInputAction;

    [SerializeField] private GameObject menuUI;

    private float menuTimer = 0;
    [SerializeField]private float menuTimeToggleInterval = 1;

    private void ToggleMenu()
    {
        menuUI.SetActive(true);
        if (menuTimer <= 0)
        {
            menuUI.SetActive(!menuUI.activeSelf);
            menuTimer += menuTimeToggleInterval;
        }
        
    }

    void Start()
    {
        pInputAction = PlayerInputActionInstance.instance.inputActions;
        pInputAction.Player.Editor.performed += context => ToggleMenu();
        menuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (menuTimer > 0) menuTimer -= Time.deltaTime;
    }
}
