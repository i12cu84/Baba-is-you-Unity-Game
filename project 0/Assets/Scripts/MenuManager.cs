using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // 메뉴 에서 레벨 버튼 눌렀을때 어떤 씬 불러올것인지.
    public void Select(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
