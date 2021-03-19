using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmenucontroller : MonoBehaviour
{
    public void PlayGameButton()
    {
        Application.LoadLevel ("SampleScene");
    }
    public void QuitGamebutton()
    {
        Application.Quit ();
    }
}
