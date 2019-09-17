using UnityEngine;
using System.Collections;

public class BackGroundParallax : MonoBehaviour {
    public Transform[] BackGrounds;
    public float ParallaxScale;
    public float ParallaxReductionsFactor;
    public float Smoothing;

    private Vector3 _lastPositions;

	// Use this for initialization
	void Start () {
        _lastPositions = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
        var paralax = (_lastPositions.x - transform.position.x) * ParallaxScale;
        for (var i =0; i<BackGrounds.Length;i++)
        {
            var backgroundTargetPosition = BackGrounds[i].position.x + paralax * (i * ParallaxReductionsFactor + 1);
            BackGrounds[i].position = Vector3.Lerp(
                BackGrounds[i].position,
                new Vector3(backgroundTargetPosition, BackGrounds[i].position.y, BackGrounds[i].position.z),
                Smoothing * Time.deltaTime);

        }
        _lastPositions = transform.position;
	
	}
}
