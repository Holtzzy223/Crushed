using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HoltzzyHelper
{
    
    public static class Extensions
    {
        public static Vector3 Direction2D(this Transform transform,bool invert = false)
        {
            int inverted = 1;
            _= invert == true ? inverted = -1 : inverted = 1;
            Vector3 direction2D = new Vector3(0, 0, Mathf.Atan2(transform.position.y, transform.position.x) * inverted * Mathf.Rad2Deg);
            return direction2D;
        }
    }
    public static class Helpers 
    {
        public static float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
        {
            return Mathf.Atan2(b.y - a.y, b.x - a.x) * Mathf.Rad2Deg - 90f;
        }

        public static void ReloadScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
    
}
