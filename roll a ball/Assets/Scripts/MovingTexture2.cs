using UnityEngine;
using System.Collections;

public class MovingTexture2 : MonoBehaviour
{
    private Vector2 savedOffset;
    private Vector2 savedScale;
    public float offsetX, offsetY;
    public float speed = 0;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        savedOffset = GetComponent<Renderer>().sharedMaterial.GetTextureOffset("_MainTex");
        savedScale = GetComponent<Renderer>().sharedMaterial.GetTextureScale("_MainTex");
        Vector2 startScale = new Vector2((float)0.03703704, (float)0.07692308);
        Vector2 startOffset = new Vector2(offsetX, offsetY);
        GetComponent<Renderer>().sharedMaterial.SetTextureScale("_MainTex", startScale);
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", startOffset);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        float x = Mathf.Repeat(Time.time * scrollSpeed, 1);
        Vector2 offset = new Vector2(x, savedOffset.y);
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
        */
        GameObject parent = this.transform.parent.gameObject;
        Vector3 parentZ = parent.transform.position;
        Vector3 position = player.transform.position;
        float x = (position.z - parentZ.z) * speed * -1;
        float y = (position.y - 1) * speed * -1;
        //Debug.Log(parentZ.y);
        Debug.Log(position.y);
        Vector2 offset = new Vector2(x + savedOffset.x, y + offsetY);
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
    void OnDisable()
    {
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", savedOffset);
        GetComponent<Renderer>().sharedMaterial.SetTextureScale("_MainTex", savedScale);
    }
}
