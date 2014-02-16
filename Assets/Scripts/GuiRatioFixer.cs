using UnityEngine;
using System.Collections;

// Use this on a guiText or guiTexture object to automatically have
// it adjust its aspect ratio when the game starts.

public class GuiRatioFixer : MonoBehaviour {

    public float m_NativeRatio = 1.333333333333F;

	// Use this for initialization
	void Start () {
	   float currentRatio = (float)Screen.width / (float)Screen.height;
       Vector3 scale = transform.localScale;
       scale.x *= m_NativeRatio / currentRatio;
       transform.localScale = scale;
	}
}
