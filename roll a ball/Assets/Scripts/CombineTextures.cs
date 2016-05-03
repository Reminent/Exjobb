using UnityEngine;
using System.Collections;

public class CombineTextures : MonoBehaviour {

    public RenderTexture[] inTextures;
    public Camera[] inCameras;
    public RenderTexture targetTex;

    private int width = 256;
    private int height = 256;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        bool texNull = true;
        for (int i = 0; i < inTextures.Length; i++) {
            if (inTextures[i] == null) {
                texNull = false;
            }
        }

        bool cameraNull = true;
        for (int i = 0; i < inCameras.Length; i++)
        {
            if (inCameras[i] == null)
            {
                cameraNull = false;
            }
        }

        if (texNull && cameraNull)
        {
            Debug.Log("hejsan");
            Texture2D tex1 = new Texture2D(width, height, TextureFormat.RGB24, false);
            /*
            // ofc you probably don't have a class that is called CameraController :P
            Camera activeCamera = ;

            // Initialize and render
            RenderTexture rt = new RenderTexture(width, height, 24);
            activeCamera.targetTexture = rt;
            activeCamera.Render();
            RenderTexture.active = rt;

            // Read pixels
            tex.ReadPixels(rectReadPicture, 0, 0);

            // Clean up
            activeCamera.targetTexture = null;
            RenderTexture.active = null; // added to avoid errors 
            DestroyImmediate(rt); */
        }
	}
}
