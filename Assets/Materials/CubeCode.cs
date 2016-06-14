using UnityEngine;
using System.Collections;

public class CubeCode : MonoBehaviour
{
    public float RotateSpeed = 1.0f;

    Vector3 spinSpeed = new Vector3(0, 0, 0);
    Vector3 spinAxis = new Vector3.up;
        
    void Start()
    {
        spinSpeed = new Vector3(Random.value, Random.value, Random.value);
        spinAxis.x = .1f * (Random.value - Random.value);
    }

    public void SetSize(float size)
    {
        this.transform.localScale = new Vector3(size, size, size);
    }

    void Update()
    {
        this.transform.Rotate(spinSpeed);
        this.transform.RotateAround(Vector3.zero, spinAxis, RotateSpeed);
    }
}


/*

// ---------------------------------------------------------------------------------
// COMMENTS ABOUT THE CODE!
// ---------------------------------------------------------------------------------
// HERE IS THE EXACT SAME CODE ABOVE, BUT WITH INLINE COMMENTS FOR ADDITIONAL HELP.
// FEEL FREE TO DROP ME AN EMAIL OR DM IF YOU HAVE MORE QUESTIONS - @rickbarraza


public class CubeCode : MonoBehaviour
{

    // THIS FIELD IS PUBLIC SO WHEN WE WRITE OUR MAIN SCRIPT IN LESSON 2,
    // WE CAN CONTROL THE ROTATIONAL ORBIT SPEED INDIVIDUALLY
    public float RotateSpeed = 1.0f;

    // THESE FILEDS ARE PRIVATE, BUT ARE AVAILABLE TO BOTH START() AND UPDATE()

    // "spinSpeed" CONTROLS HOW FAST THE CUBE WILL SPIN AROUND ITSELF.
    // IT TAKES THREE VALUES THAT DETERMINE THE X, Y, Z SPIN IN DEGREES. 
    Vector3 spinSpeed = new Vector3(0, 0, 0);

    // "spinAxis" IS UESD IN ROTATION TO DETERMINE WHAT THE "UP" IS
    // FOR THE ROTATIONAL ORBIT. AS DISCUSSED, TO ROTATE AND OBJECT
    // AROUND A POINT, THEY BOTH NEED TO AGREE ON WHAT "UP" IS.
    // BY DEFAULT, Vector3.up IS (0, 1, 0) WHICH POINTS STRAIGHT UP THE Y-AXIS
    Vector3 spinAxis = Vector3.up;

    void Start()
    {
        // "Random.value" WILL RETURN A DECIMAL BETWEEN [0.0 to +1.0].
        // SO HERE, WE ARE SETTING THE X, Y, AND Z ROTATIONS ALL TO THEIR 
        // OWN RANDOM VALUES BETWEEN 0 AND 1 DEGREE. THAT WAY, EACH CUBE
        // WILL SPIN IT'S OWN UNIQUE WAY.
        spinSpeed = new Vector3(Random.value, Random.value, Random.value);

        // BUT IF YOU WANT TO GET A RANDOM VALUE FROM [-1.0 to +1.0], HERE IS
        // ANOTHER COOL TRICK. JUST DO (Random.value - Random.value).
        // AT MOST, IT WILL BE (+1.0 - 0.0) or +1.0 
        // AT LEAST, IT WILL BE (0.0 - 1.0) or -1.0

        // BY MUTLIPLYING THIS (-1 to +1) RANDOM VALUE BY .1f, WE SHRINK IT
        // DOWN TO BEING IN THE POSSIBLE RANGE OF [-0.1 to +0.1] A MUCH SMALLER
        // VALUE. THIS WAY, spinAxis IS STILL "MOSTLY POINTING UP" BUT WITH A 
        // LITTLE BIT OF TILT ADDED TO THE X, SO IT DOESN'T LOOK SO PERFECT AND BORING
        spinAxis.x = .1f * (Random.value - Random.value);
    }

    // THIS FUNCTION IS PUBLIC, AND WILL BE CALLED BY ANOTHER CLASS IN LESSON 2.
    public void SetSize(float size)
    {
        // SINCE WE WANT TO KEEP THE BOX A PERFECT CUBE, WE ONLY  ASK FOR
        // ONE SIZE AND MAKE SURE THAT LENGTH, WIDTH, AND HEIGHT ARE ALL SET THE SAME
        this.transform.localScale = new Vector3(size, size, size);
    }

    // Update() IS OUR LOOPING FUNCTION THAT LETS US MAKE SMALL CHANGES EVERY "FRAME"
    // SINCE THERE ARE MANY FRAMES PER SECOND, THIS CREATES THE ILLUSION OF ANIMATION
    void Update()
    {
        // FIRST WE SPIN THE CUBE AROUND ITSELF USING OUR spinSpeed VALUES SET IN Start()
        this.transform.Rotate(spinSpeed);

        // THEN WE ROTATE THE CUBE AROUND THE ORIGIN (0,0,0), or Vector3.zero, 
        // AT WHATEVER VALUE HAS BEEN GIVEN TO RotateSpeed
        this.transform.RotateAround(Vector3.zero, spinAxis, RotateSpeed);
    }

}
*/
