using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{

    public void OnclickStartButton()
    {
        Debug.Log("����");
    }

    public void OnClickQuitButton()
    {
#if UNITY_EDITOR    // �����Ϳ��� ����� ���¸� �÷��̸� �ߴܽ�Ŵ
        UnityEditor.EditorApplication.isPlaying = false;
#else   // ����� �����̸� ������ ����
    Application.Quit();
#endif
    }
}
