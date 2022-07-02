using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class MoveObject : MonoBehaviour
{
 [SerializeField] private Vector3 pointA = new Vector3(-2, 0, 0);
 [SerializeField] private Vector3 pointB = new Vector3(2, 0, 0);
 [SerializeField] private float speed = 1;
 private float t;
 private void Update()
 {
 t += Time.deltaTime * speed;
 // Moves the object to target position
 transform.position = Vector3.Lerp(pointA, pointB, t);
 // Flip the points once it has reached the target
 if (t >= 1)
 {
 var b = pointB;
 var a = pointA;
 pointA = b;
 pointB = a;
 t = 0;
 }
 }
 // What Linear interpolation actually looks like in terms of code
 private Vector3 CustomLerp(Vector3 a, Vector3 b, float t)
 {
 return a * (1 - t) + b * t;
 }
}
