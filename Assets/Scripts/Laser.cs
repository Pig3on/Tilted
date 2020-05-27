using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    LineRenderer lineRenderer;

    public bool rotate = false;

    public float rotateSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = this.GetComponent<LineRenderer>();
        lineRenderer.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(rotate) {
            transform.Rotate(0,rotateSpeed * Time.deltaTime,0);
        }
        
        lineRenderer.SetPosition(0, this.transform.position);
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward * -3, out hit)){
            if(hit.collider){
                lineRenderer.SetPosition(1,hit.point);
                if(hit.collider.gameObject.CompareTag("Player")){
                      Destroy(hit.collider.gameObject);
                }
            }
        }
        else{
            lineRenderer.SetPosition(1,transform.forward * 5000);
        }

    }
}
