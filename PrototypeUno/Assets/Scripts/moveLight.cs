using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLight : MonoBehaviour
{
  //enable hand authoring for where light should end!
  public Vector3 pointB;

IEnumerator Start()
{
    var transform = this.GetComponent<Transform>(); //get transform
    var pointA = transform.position; //whereever we place for point a
    while(true)
    {   //co-routine to go back & forth from point a to b
        yield return StartCoroutine(MoveObject(transform, pointA, pointB, 3.0f));
        yield return StartCoroutine(MoveObject(transform, pointB, pointA, 3.0f));
    }
}

//params self explanatory but:
// thisTransform - thing we moving
// startPos - where thing startPos
// endPos - where thing endPos
// time - social construct
IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
{
    var i= 0.0f;
    var rate= 1.0f/time; //keep this rate smoooooth
    while(i < 1.0f)
    {
        i += Time.deltaTime * rate;
        thisTransform.position = Vector3.Lerp(startPos, endPos, i); //we Linear interpolating for smoothness :^)
        yield return null;
    }
}
}
