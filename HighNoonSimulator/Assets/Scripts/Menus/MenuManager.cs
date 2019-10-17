using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public delegate void PlayDelegate();
    public static event  PlayDelegate OnPlayClick;
    // Start is called before the first frame update
    public void OnPlayPress()
    {if(OnPlayClick != null)
        {
            OnPlayClick();
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
