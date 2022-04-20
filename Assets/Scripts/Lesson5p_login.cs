using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lesson5p_login : MonoBehaviour
{
    public Rect loginPos;
    public Rect passwordPos;

    string loginInput = "";
    string passwordInput = "";

    private void OnGUI()
    {
        loginInput = GUI.TextField(loginPos, loginInput);
        passwordInput = GUI.PasswordField(passwordPos, passwordInput, '*');


        if (loginInput != null && passwordInput != null)
        {
            if (loginInput.Equals("admin")&&passwordInput.Equals("8888"))
            {
                SceneManager.LoadScene("GameScene");
            }
        }
    }
}
