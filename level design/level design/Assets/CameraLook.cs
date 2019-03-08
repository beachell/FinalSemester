using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("Camera-Control/Mouse Look")]
public class CameraLook : MonoBehaviour
{
    Vector2 mouseLook;
    Vector2 smoothV;
    public float sensi = 5f;
    public float smoothing = 2.0f;
    public float minc = -90f;
    public float maxc = 90f;
 
    GameObject character;

      // Start is called before the first frame update
      void Start()
      {
          character = this.transform.parent.gameObject;    
      }

      // replace with a coroutine later
      void Update()
      {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        md = Vector2.Scale(md, new Vector2(sensi * smoothing, sensi * smoothing));
          //----------------------------------------------------
          
          smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
          smoothV.x = Mathf.Clamp(smoothV.x, minc, maxc);
          smoothV.y = -Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        
        mouseLook += smoothV;

        transform.localRotation = Quaternion.Euler(Vector3.right * mouseLook.y);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
        

      }
      /*
    public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityX = 15F;
    public float sensitivityY = 15F;

    public float minimumX = -360F;
    public float maximumX = 360F;

    public float minimumY = -60F;
    public float maximumY = 60F;

    private Rigidbody rb;
    float rotationY = 0F;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Make the rigid body not change rotation
        if (GetComponent<Rigidbody>())
            rb.freezeRotation = true;
    }

    void Update()
    {
        if (axes == RotationAxes.MouseXAndY)
        {
            float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;

            rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
        }
        else if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
        }
        else
        {
            rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

            transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
        }
    }*/
}
