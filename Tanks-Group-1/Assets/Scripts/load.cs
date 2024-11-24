using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnplayButton()
    {
        SceneManager.LoadScene("lvl1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
