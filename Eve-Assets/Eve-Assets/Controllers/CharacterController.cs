using Eve_Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Xml;

namespace Eve_Assets.Controllers
{
    public class CharacterController : ApiController
    {
        //URL for basic character info
        private string APIurl = "https://api.eveonline.com/account/Characters.xml.aspx?keyID=KEYCODE&vCode=VERIFICATION";

        [HttpGet, Route("api/character/getCharacters")]
        public IEnumerable<Character> GetCharacter(string key, string code)
        {
            var returnList = new List<Character>();
            string url = APIurl.Replace("KEYCODE", key).Replace("VERIFICATION", code);

            XmlTextReader reader = new XmlTextReader(url);

            while (reader.Read())
            {
                //Character info is stored as attributes on row
                if (reader.NodeType == XmlNodeType.Element) {
                    if(reader.Name == "row")
                    {
                        var character = new Character();
                        character.CharacterName = reader.GetAttribute("name");
                        character.CharacterId = reader.GetAttribute("characterID");
                        character.CorpName = reader.GetAttribute("corporationName");
                        returnList.Add(character);
                    }
                }
            }
            return returnList;
        }
    }
}