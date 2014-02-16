using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
    public int m_BoxWidth = 100;
    public int m_BoxHeight = 90;

    public int m_ButtonWidth = 80;
    public int m_ButtonHeight = 20;

    void OnGUI() {
        GUI.Box(new Rect((Screen.width / 2) - (m_BoxWidth / 2), (Screen.height / 2) - (m_BoxHeight / 2), m_BoxWidth, m_BoxHeight), "Main Menu");
        if (GUI.Button(new Rect((Screen.width / 2) - (m_ButtonWidth / 2), (Screen.height / 2) - (m_ButtonHeight / 2) - 5, m_ButtonWidth, m_ButtonHeight), "Start")) {
            // Start application.
        }

        if (GUI.Button(new Rect((Screen.width / 2) - (m_ButtonWidth / 2), (Screen.height / 2) - (m_ButtonHeight / 2) + 25, m_ButtonWidth, m_ButtonHeight), "Exit")) {
            // Exit application.
            Application.Quit();
        }
    }	
}
