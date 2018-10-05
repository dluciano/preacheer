using UnityEngine;
using System.Collections.Generic;

public class GuiSkinManager : MonoBehaviour
{	
	public GUISkin skin;
	
	public Texture2D firstBibleIcon;
	public Texture2D disableFirstBibleIcon;
	public Texture2D referenceBibleIcon;
	public Texture2D disableReferenceBibleIcon;
	public Texture2D disablePapyrusBibleIcon;
	public Texture2D papyrusBibleIcon;
	
	public Texture2D prayIcon;
	public Texture2D bibleKnowlegdeIcon;
	
	internal static bool firstBibleIconVisible = false;
	internal static bool referenceBibleIconVisible = false;
	internal static bool papyrusBibleIconVisible = false;
	
	
	private bool visible;
	
	void Update()
	{
		//TODO: Change this to an action in the control		
		visible = Input.GetKeyDown("escape") ? !visible : visible;
	}
	
	void OnGUI()
	{
		GUI.skin = skin;
		
		var mainBox = new Rect (0, Screen.height - 135, Screen.width, Screen.height);
		
		GUI.BeginGroup(mainBox);
		
		GUI.Box(new Rect (0, 0, mainBox.width, mainBox.height),  @"");
		
		#region Bibles Collection
		GUI.Box(new Rect (10, 10, 300, 115), @"Bibles Collection +23");
		
		var firstBibleLevel = (MainCharacterController.person.SpitualPoints >= 0 ? @"+" : @"-") 
								+ MainCharacterController.person.SpitualPoints.ToString();
		
		var content = new GUIContent[]{ new GUIContent(@"Simple " + firstBibleLevel, firstBibleIconVisible ? firstBibleIcon : disableFirstBibleIcon, @"The Bible Version, Reina-Valera 60"),
										new GUIContent(@"Reference", referenceBibleIconVisible ? referenceBibleIcon : disableReferenceBibleIcon, @"Strong Referenced Bible"),
										new GUIContent(@"Hebrew", papyrusBibleIconVisible ? papyrusBibleIcon : disablePapyrusBibleIcon, @"Original Papyrus")};
		var selectedToolbar = GUI.Toolbar(new Rect(28, 30, 270, 80), -1, content);
		#endregion
		
		#region Spiritual Live
		GUI.Box(new Rect (330, 10, 360, 115), @"Spiritual Live +150");

		GUI.Label(new Rect(335, 28, 100, 50), new GUIContent(@"Pray", prayIcon, @"Pray Level"));
		GUI.Label(new Rect(380, 30, 80, 50), @"Power: +3");
		GUI.Label(new Rect(380, 50, 80, 50), @"Max: +23");
		
		GUI.Label(new Rect(335, 75, 100, 50), new GUIContent(@"Bible", bibleKnowlegdeIcon, @"Bible Level"));
		GUI.Label(new Rect(380, 80, 80, 50), @"Power: +3");
		GUI.Label(new Rect(380, 100, 80, 50), @"Max: +23");
		
		GUI.Label(new Rect(455, 28, 100, 50), new GUIContent(@"Ayuno", bibleKnowlegdeIcon, @"Ayuno Level"));
		GUI.Label(new Rect(500, 30, 80, 50), @"Power: +3");
		GUI.Label(new Rect(500, 50, 80, 50), @"Max: +23");
		
		GUI.Label(new Rect(455, 75, 100, 50), new GUIContent(@"Vigilia", bibleKnowlegdeIcon, @"Vigilia Level"));
		GUI.Label(new Rect(500, 80, 80, 50), @"Power: +3");
		GUI.Label(new Rect(500, 100, 80, 50), @"Max: +23");
		
		GUI.Label(new Rect(575, 28, 100, 50), new GUIContent(@"Silicio", bibleKnowlegdeIcon, @"Silicio Level"));
		GUI.Label(new Rect(620, 30, 80, 50), @"Power: +3");
		GUI.Label(new Rect(620, 50, 80, 50), @"Max: +23");
		
		GUI.Label(new Rect(575, 75, 100, 50), new GUIContent(@"Worshi", bibleKnowlegdeIcon, @"Worship Level"));
		GUI.Label(new Rect(620, 80, 80, 50), @"Power: +3");
		GUI.Label(new Rect(620, 100, 80, 50), @"Max: +23");
		#endregion		
		
		GUI.Box(new Rect(710, 10, 360, 115), @"Attack & Defense");

		
		GUI.Box(new Rect(1090, 10, 260, 115), @"Help");
		GUI.Label(new Rect(1095, 30, 250, 105), @""+GUI.tooltip);
		
		GUI.EndGroup();
		
		if(visible){
			GUILayout.BeginVertical();
			if(GUILayout.Button(@"Resume")) visible = !visible;
	        if(GUILayout.Button(@"Quit")) Application.Quit();
			GUILayout.EndVertical();
		}
		

		
	}
}

