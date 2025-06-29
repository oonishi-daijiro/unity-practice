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
        cam.transform.rotation = playerHead.transform.rotation;
        cam.transform.transform.position = playerHead.transform.position;
    }
}
