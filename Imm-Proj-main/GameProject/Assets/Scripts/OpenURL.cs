using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    // Start is called before the first frame update
    public void OpenUrl()
    {
        Application.OpenURL("https://github.com/gm485/IMM_Project");
    }
}
