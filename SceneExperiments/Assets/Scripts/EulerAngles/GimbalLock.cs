using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://en.wikipedia.org/wiki/Gimbal_lock
// https://answers.unity.com/questions/573035/avoiding-gimbal-lock.html
// https://physics.stackexchange.com/questions/254082/gimbal-lock-why-is-it-a-problem
// https://math.stackexchange.com/questions/1838/why-is-gimbal-lock-an-issue
// http://www.anticz.com/eularqua.htm
// https://www.youtube.com/watch?v=olydnG_0a0M


// https://www.reddit.com/r/gamedev/comments/48qcbr/can_anyone_out_there_explain_using_quaternions_to/
    //In formal language, gimbal lock occurs because the map from Euler angles to rotations(topologically, 
    //from the 3-torus T3 to the real projective space RP3) is not a covering map – it is not a local 
    //homeomorphism at every point, and thus at some points the rank(degrees of freedom) must drop below 3, 
    //at which point gimbal lock occurs.Euler angles provide a means for giving a numerical description of 
    //any rotation in three-dimensional space using three numbers, but not only is this description not unique, 
    //but there are some points where not every change in the target space (rotations) can be realized by 
    //a change in the source space (Euler angles). This is a topological constraint – there is no covering 
    //map from the 3-torus to the 3-dimensional real projective space; the only (non-trivial) covering map 
    //is from the 3-sphere, as in the use of quaternions.




public class GimbalLock : MonoBehaviour {

    // volgens mij is het probleem dat je 
    //  tijdens een animatie in een gimballock situatie kan komen en dat 
    //  daarna je animatie zich raar zal gedragen
    // je verwacht een bepaalde rotatie die je niet zal verkrijgen door die gimbal lock
    //  er zijn nl. twee rotatie-assen die dan hetzlfde resultaat geven (is dit wel correct geformuleerd?)
    // Hoe kan je dit demonstreren?
    //  begin van een bepaalde situatie (bepaalde waarden voor eulerangles)
    //  we willen eindigen in een andere situatie (andere waarden voor eulerangles)
    //  tijdens de weg ernaartoe belanden we in een gimballock situatie
    //  > komen we dan wel aan in onze doel situatie?

    // Gimbal lock
    //  X = 90, dan zijn positieve Y en Z gelijk (probeer Y = 10 en Z = -10)

    public GameObject RotateXAxis;
    public GameObject RotateYAxis;
    public GameObject RotateZAxis;

    public float XRotation;
    public float YRotation;
    public float ZRotation;

    // Use this for initialization
    void Start () {
        // Gimbal lock occurs when two rotations line up

        this.transform.eulerAngles = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        RotateZAxis.transform.localEulerAngles = new Vector3(0, 0, ZRotation);
        RotateXAxis.transform.localEulerAngles = new Vector3(XRotation, 0, 0);
        RotateYAxis.transform.localEulerAngles = new Vector3(0, YRotation, 0);

    }
}
