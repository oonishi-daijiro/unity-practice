using UnityEngine;

public class FirstPersonCam : MonoBehaviour
{
    [SerializeField] public GameObject playerHead;

    private GameObject cam;

    void Start()
    {
        cam = gameObject;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // cam.transform.rotation = playerHead.transform.rotation;
        var plh= playerHead.transform.position;
        plh.z -= 0.5f;
        cam.transform.position = plh;
        
    }
}
