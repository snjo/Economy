using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Business : MonoBehaviour {

    public string displayName = string.Empty;
    public List<Resource> resources = new List<Resource>();    
    public float productionPerSecond = 1f;
    public float maxStorage = 500f;

	// Use this for initialization
	void Start () {

        resources.Add(new Resource("Iron Ore"));
}
	
	// Update is called once per frame
	void Update () {
        foreach (Resource r in resources)
        {            
            r.amount += productionPerSecond * Time.deltaTime;
        }
	}
}
