using Eve_Assets.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Xml;

namespace Eve_Assets.Controllers
{
    public class AssetController : ApiController
    {
        string APIurl = "https://api.eveonline.com/char/AssetList.xml.aspx?characterID=CHARACTER&keyID=VERIFICATION&vCode=KEYCODE";
        [HttpGet, Route("api/asset/calculateLiquidIsk")]
        public float calculateLiquidIsk(string data)
        {

            List<Item> allItems = new List<Item>();
            #region getItems
            IEnumerable<Character> characters = JsonConvert.DeserializeObject<List<Character>>(data);
            foreach (Character character in characters)
            {
                string url = APIurl.Replace("KEYCODE", character.ApiKey)
                    .Replace("VERIFICATION", character.ApiCode)
                    .Replace("CHARACTER", character.CharacterId);

                XmlTextReader reader = new XmlTextReader(url);

                while (reader.Read())
                {
                    //Character info is stored as attributes on row
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "row")
                        {
                            var item = new Item();
                            item.TypeId = int.Parse(reader.GetAttribute("typeID"));
                            item.Quantity = int.Parse(reader.GetAttribute("quantity"));

                            if (!allItems.Any(i => i.TypeId == item.TypeId))
                            {
                                allItems.Add(item);
                            }
                            else
                            {
                                allItems.Single(i => i.TypeId == item.TypeId).Quantity += item.Quantity;
                            }
                        }
                    }
                }
            }
            #endregion

            float totalIsk = 0;
            foreach (Item item in allItems)
            {
                var itemUrl = "http://api.eve-central.com/api/marketstat?typeid=" + item.TypeId + "&usesystem=30000142";
                XmlTextReader itemReader = new XmlTextReader(itemUrl);
                if (itemReader.ReadToDescendant("buy"))
                {
                    if (itemReader.ReadToDescendant("max"))
                    {
                        itemReader.Read();
                        float value = float.Parse(itemReader.Value);
                        totalIsk += value * item.Quantity;
                    }
                }
            }
            Console.WriteLine(totalIsk);
            return totalIsk;
        }
    }
}