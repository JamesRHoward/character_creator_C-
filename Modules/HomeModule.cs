using Nancy;
using CharacterCreator.Objects;
using System.Collections.Generic;

namespace CharacterCreator
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/character/new"] = _ => {
        return View["character_add_form.cshtml"];
      };
      Post["/character/add"] = _ => {
        Character newCharacter = new Character(Request.Form["new-character"],Request.Form["new-class"],Request.Form["new-race"]);
        List<Character> allCharacters = Character.GetAllIdentity();
        return View["view_all_characters.cshtml", allCharacters];
      };
      Get["/character/{id}"] = parameters => {
        Character myCharacter = Character.Find(parameters.id);
        return View["/view_one_character", myCharacter];
      };
    }
  }
}
