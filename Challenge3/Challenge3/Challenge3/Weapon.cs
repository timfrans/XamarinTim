using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge3
{
    public class Weapon
    {
        Int32 id;
        string name;
        string description;
        ICollection<Character> characters;

        [JsonProperty(PropertyName = "id")]
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [JsonProperty(PropertyName = "description")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Version { get; set; }
    }
}
