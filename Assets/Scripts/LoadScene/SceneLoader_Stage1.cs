using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.SceneManagement;

public class SceneLoader_Stage1 : MonoBehaviour
{
    public int SceneIndex = 5;
    public void LoadScene()
    {
        SceneManager.LoadScene(SceneIndex);
    }
}
