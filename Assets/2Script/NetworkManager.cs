using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public InputField NickNameInput;
    // Start is called before the first frame update

    void Awake()
    {
        //PhotonNetwork.AutomaticallySyncScene = true;
    }

    //네트워크 연결
    private void Start()
    {
        Screen.SetResolution(540, 960, false);
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        print("서버접속완료");
        PhotonNetwork.LocalPlayer.NickName = NickNameInput.text;
    }
}
