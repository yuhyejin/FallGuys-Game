using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;

public class PlayFabManager : MonoBehaviour
{
    public InputField emailInput;
    public InputField passwordInput;
    public GameObject btnObject;
    public GameObject loginObject;


    public void LoginBtn()
    {
        var request = new LoginWithEmailAddressRequest { Email = emailInput.text, Password = passwordInput.text };
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnLoginFailure);
    }

    public void RegisterBtn()
    {
        var request = new RegisterPlayFabUserRequest { Email = emailInput.text, Password = passwordInput.text, RequireBothUsernameAndEmail = false };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnRegisterFailure);
    }

    void OnLoginSuccess(LoginResult result)
    {
        loginObject.SetActive(false);
        btnObject.SetActive(true);
        print("�α��� ����");
    }

    void OnLoginFailure(PlayFabError error) => print("�α��� ����");

    void OnRegisterSuccess(RegisterPlayFabUserResult result) => print("ȸ������ ����");

    void OnRegisterFailure(PlayFabError error) => print("ȸ������ ����");
}
