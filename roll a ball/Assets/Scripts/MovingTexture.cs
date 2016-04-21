using UnityEngine;
using System.Collections;

public class MovingTexture : MonoBehaviour
{
    private Vector2 savedOffset;
    public float speed = 0;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        savedOffset = GetComponent<Renderer>().sharedMaterial.GetTextureOffset("_MainTex");
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
        float z = (position.z - parentZ.z) * speed * -1;
        Debug.Log(z);
        Vector2 offset = new Vector2(z + savedOffset.x, savedOffset.y);
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
    void OnDisable()
    {
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", savedOffset);
    }
}
