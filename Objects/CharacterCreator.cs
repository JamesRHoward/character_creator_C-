using System.Collections.Generic;

namespace CharacterCreator.Objects
{
  public class Character
  {
    private string _characterName;
    private string _characterClass;
    private string _characterRace;
    private int _id;
    private static List<Character> _identity = new List<Character> {};


    // Our constructor
    public Character (string characterName, string characterClass, string characterRace)
    {
      _characterName = characterName;
      _characterClass = characterClass;
      _characterRace = characterRace;
      _id = _identity.Count;
    }

    public string GetCharacterName()
    {
      return _characterName;
    }
    public void SetCharacterName(string newCharacterName)
    {
      _characterName = newCharacterName;
    }

    public string GetCharacterClass()
    {
      return _characterClass;
    }
    public void SetCharacterClass(string newCharacterClass)
    {
      _characterClass = newCharacterClass;
    }

    public string GetCharacterRace()
    {
      return _characterRace;
    }
    public void SetCharacterRace(string newCharacterRace)
    {
      _characterRace = newCharacterRace;
    }

    public int GetId()
    {
      return _id;
    }

    private static List<Character> GetAllIdentity()
    {
      return _identity;
    }

    public static Character Find(int characterId)
    {
      return _identity[characterId-1];
    }
  }
}
