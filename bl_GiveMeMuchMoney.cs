using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BitchLand//must have this namespace
{
	public class Mod//must have this class name
	{
		public static bl_GiveMeMuchMoneyMod ThisMod;

		public static void Init() //must have this name, and MUST be static
		{
			ThisMod = Main.Instance.gameObject.AddComponent<bl_GiveMeMuchMoneyMod>();
		}

		public static void EnableMod(bool value)
		{
			if(value)
			{//mod was enabled in the settings
				Main.Instance.Player.Money += 90000000;
                Main.Instance.Player.Hunger += 100;
                Main.Instance.GameplayMenu.ShowNotification("Here 90 mio cash and 100 hunger for you");
            }
			else
			{//mod was disabled in the settings
			}
		}
	}

	public class bl_GiveMeMuchMoneyMod : MonoBehaviour
	{
		public void Start()
		{
			Main.Instance.Player.Money += 90000000;
			Main.Instance.Player.Hunger += 100;
		    Debug.Log((object) "bl_GiveMeMuchMoneyMod.Start() Give Me Much Money");
		}

	}
}

