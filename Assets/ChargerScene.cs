using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChargerScene : MonoBehaviour {

    public void ChargerMaScene (string scene)
    {
        SceneManager.LoadScene(scene);
    }
}