using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineRenderer : MonoBehaviour {

    private LineRenderer lineRendererr;
    private float counter;
    private float dist;

    public Transform origin;
    public Transform destination;
        
    public float lineDrawSpeed = 6f;

	void Start () {
      
        lineRendererr = GetComponent<LineRenderer>();
        lineRendererr.SetPosition(0, origin.position);
        lineRendererr.SetWidth(.15f, .15f);

        dist = Vector3.Distance(origin.position, destination.position);
    }
	
	// Update is called once per frame
	void Update () {
        if (counter < dist)
        {
			
            counter += 0.1f;
            float x = Mathf.Lerp(0, dist, counter);

            Vector3 pointA = origin.position;
            Vector3 pointB = destination.position;

            Vector3 pointAlongLine = x * Vector3.Normalize(pointB - pointA) + pointA;

            lineRendererr.SetPosition(1, pointAlongLine);

		}

     
        
         
        
		
	}
}
