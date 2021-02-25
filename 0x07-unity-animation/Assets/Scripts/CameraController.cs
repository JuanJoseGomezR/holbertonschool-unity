using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseS = 4f;
    // public GameObject player;
    public GameObject player;
    private Vector3 offset;
    private Quaternion camRotX;
    private Quaternion camRotY;

    public bool IsInverted;
    
    
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("isInverted") == 1)
        {
            if(Input.GetMouseButton(1))
            {
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * mouseS, Vector3.up) * Quaternion.AngleAxis((Input.GetAxis("Mouse Y") * -1) * mouseS, Vector3.left) * offset;
            transform.position = player.transform.position + offset; 
            // offset.x = Mathf.Clamp(offset.x, 0, 80f);
            // Debug.Log("x" + offset.x);
            // Debug.Log("y" + offset.y);
            transform.LookAt(player.transform.position);
            }
            else
            {
            transform.position = player.transform.position + offset; 
            // offset.x = Mathf.Clamp(offset.x, 0, 80f); 
            }
        }
        else 
        {
            if(Input.GetMouseButton(1))
            {
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * mouseS, Vector3.up) * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * mouseS, Vector3.left) * offset;
            transform.position = player.transform.position + offset; 
            // offset.x = Mathf.Clamp(offset.x, 0, 80f);
            // Debug.Log("x" + offset.x);
            // Debug.Log("y" + offset.y);
            transform.LookAt(player.transform.position);
            }
            else
            {
            transform.position = player.transform.position + offset; 
            // offset.x = Mathf.Clamp(offset.x, 0, 80f); 
            }
        }
    }
}