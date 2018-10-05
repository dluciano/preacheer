using UnityEngine;

public class MainCharacterController : MonoBehaviour
{
	public GameObject personController;
	internal static Core.Entity.MainCharacter person = new Core.Entity.MainCharacter();
	
	void Start()
	{
		if(personController == null)
			//TODO: Add the text to a setting file
			throw new UnassignedReferenceException(@"Error grave");
		
		//TODO: Init the person data from the database
		//DO NOT CHANGE THE ORDER OF THE MAX.. And SpiritualPoints...
		person.MaximunSpiritualPoints = 100;
		person.SpitualPoints = 3;
		person.Name = @"Dawlin";
	}
}

