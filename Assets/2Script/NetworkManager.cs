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

    //��Ʈ��ũ ����
    private void Start()
    {
        Screen.SetResolution(540, 960, false);
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        print("�������ӿϷ�");
        PhotonNetwork.LocalPlayer.NickName = NickNameInput.text;
    }
}
