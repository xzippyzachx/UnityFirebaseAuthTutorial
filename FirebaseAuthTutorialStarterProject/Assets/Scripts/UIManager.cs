using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject loginUI;
    public GameObject registerUI;




    //Functions to change the login screen UI
    public void LoginScreen() //Back Btn
    {
        loginUI.SetActive(true);
        registerUI.SetActive(false);
    }
    public void RegisterScreen() // Regester Btn
    {
        loginUI.SetActive(false);
        registerUI.SetActive(true);
    }


}
