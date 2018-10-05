using UnityEngine;
using Core;
using Core.Entity;
using System;

public class BibleController : MonoBehaviour {
	
	public Bible.BibleType type;
	private readonly Core.Entity.Bible bible = new Core.Entity.Bible(){ Id = Guid.NewGuid() };
	
	void Start()
	{
		bible.Type = type;
	}
	
	void Update()
	{
		animation.enabled = renderer.enabled = collider.enabled = bible.Visible;
	}
	
	void OnTriggerEnter(Collider collider)
	{
		if(!collider.gameObject.name.Equals(Configuration.PlayerName))
			return;
		
		if(bible.Type == Bible.BibleType.FirstBible)
			Configuration.VisiblesBiblesType.Add(Bible.BibleType.Simple);
		
		MainCharacterController.person.SpitualPoints = bible.SpiritualPoints + MainCharacterController.person.SpitualPoints;
		Destroy(gameObject);
		GuiSkinManager.firstBibleIconVisible = true;
	}
}
