using UnityEngine;
using System.Collections;

public class SetTexture : MonoBehaviour {

    public float offsetX, offsetY;
    public float tilingX, tilingY;
    private Vector2 offset, tiling;

	// Use this for initialization
	void Start () {
        offset = new Vector2(offsetX, offsetY);
        tiling = new Vector2(tilingX, tilingY);
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnDisable()
    {
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
        GetComponent<Renderer>().sharedMaterial.SetTextureScale("_MainTex", tiling);
    }
}
