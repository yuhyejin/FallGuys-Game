using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{

    public void OnclickStartButton()
    {
        Debug.Log("시작");
    }

    public void OnClickQuitButton()
    {
#if UNITY_EDITOR    // 에디터에서 실행된 상태면 플레이를 중단시킴
        UnityEditor.EditorApplication.isPlaying = false;
#else   // 빌드된 상태이면 게임을 종료
    Application.Quit();
#endif
    }
}
