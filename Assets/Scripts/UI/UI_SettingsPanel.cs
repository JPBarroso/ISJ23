using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_SettingsPanel : MonoBehaviour
{
    [Header("[References]")]
    [SerializeField] private GameObject mainMenuPanel;


    public void OnClick_Save()
    {
        //Guardar configuraci�n
        mainMenuPanel.SetActive(true);
        gameObject.SetActive(false);
    }
}
