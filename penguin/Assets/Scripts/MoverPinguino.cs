using UnityEngine;
using UnityEngine.InputSystem;

public class MoverPinguino : MonoBehaviour
{
    public Jugador pinguino;
    
    Camera camera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camera = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.DrawRay(this.transform.position, this.transform.TransformDirection(Vector3.forward) * 10, Color.red);
            RaycastHit hit;
            /*if(Physics.Raycast(this.transform.position + , this.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                Debug.Log(hit.point);
                pinguino.transform.position = hit.point;
            }*/

            Ray ray = camera.ScreenPointToRay(Mouse.current.position.ReadValue());
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                pinguino.AsignarDestino(hit.point);
            }
        }

        
    }
}
