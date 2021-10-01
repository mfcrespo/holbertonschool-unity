using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void twitter()
    {
        Application.OpenURL("https://twitter.com/mafe_crespo");
    }

    public void linkedin()
    {
        Application.OpenURL("https://linkedin.com/in/mariafernandacrespo");
    }

    public void github()
    {
        Application.OpenURL("https://github.com/mfcrespo");
    }

    public void email()
    {
        Application.OpenURL("mailto: mfcrespo77@gmail.com");
    }

    public void mgainstagram()
    {
        Application.OpenURL("https://www.instagram.com/mariethagongoraaccessories/");
    }

    public void mgafacebook()
    {
        Application.OpenURL("https://www.facebook.com/MariethaGongoraAccessories");
    }

    public void mgawebsite()
    {
        Application.OpenURL("https://mariethagongoraaccessories.com");
    }

    public void mgaphone()
    {
        Application.OpenURL("tel: +17863274023");
    }

    public void mgaemail()
    {
        Application.OpenURL("mailto: mariethagongora@hotmail.com");
    }
}
