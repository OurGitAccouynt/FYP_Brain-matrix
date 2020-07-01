using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using IndieStudio.DrawingAndColoring.Utility;

 

namespace IndieStudio.DrawingAndColoring.Logic
{
	public class SceneStartup : MonoBehaviour
	{
			// Use this for initialization
			void Start ()
			{
					ShowAd ();
			}

			public void ShowAd ()
			{
					if (SceneManager.GetActiveScene().name == "Album") {
						 	} else if (SceneManager.GetActiveScene().name == "Game") {
						 } 
			}
			
			void OnDestroy ()
			{
			 }
	}
}
