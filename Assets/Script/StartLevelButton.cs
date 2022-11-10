using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevelButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void beginG()
    {
        SceneManager.LoadScene("mainlevel");
    }
}
