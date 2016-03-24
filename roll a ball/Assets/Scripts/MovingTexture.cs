using UnityEngine;
using System.Collections;

public class MovingTexture : MonoBehaviour {
    public float scrollSpeed;
    private Vector2 savedOffset;
    public float speed = 0;
    public GameObject player;

	// Use this for initialization
	void Start () {
        savedOffset = GetComponent<Renderer>().sharedMaterial.GetTextureOffset("_MainTex");
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        /*
        float x = Mathf.Repeat(Time.time * scrollSpeed, 1);
        Vector2 offset = new Vector2(x, savedOffset.y);
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
        */
        scrollSpeed = 2;
        Vector3 position = player.transform.position;
        float z = position.z * (float)0.1;
        float x = Mathf.Repeat(Time.time * scrollSpeed, 1);
        Vector2 offset = new Vector2(position.z + savedOffset.x, savedOffset.y);
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
	}
    void OnDisable()
    {
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", savedOffset);
    }
}
