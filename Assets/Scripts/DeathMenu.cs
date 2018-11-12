using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class DeathMenu : MonoBehaviour
{
    [SerializeField] private GameObject deathMenu;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject Boat;

    void OnTriggerEnter(Collider Dead)
    {
        if (Dead.CompareTag("Player"))
        {
            deathMenu.SetActive(true);
            Player.GetComponent<FirstPersonController>().enabled = false;
            //LelToMakeMouseAppear
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    void OnTriggerExit(Collider Dead)
    {
        if (Dead.CompareTag("Player"))
        {
            deathMenu.SetActive(false);
            //ToMakeMouseStay
            Cursor.visible = true;
        }

        if (Dead.CompareTag("BoatController"))
        {
            deathMenu.SetActive(false);
            //ToMakeMouseStay
            Cursor.visible = true;
        }
    }
}
