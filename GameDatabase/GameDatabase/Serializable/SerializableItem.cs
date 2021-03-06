﻿using System;
using GameDatabase.Enums;
using Newtonsoft.Json;

namespace GameDatabase.Serializable
{
    [Serializable]
    public class SerializableItem
    {
        [JsonIgnore]
        public string FileName { get; set; }

        [JsonIgnore]
        public string FilePath { get; set; }

        public ItemType ItemType;
        public int Id;
    }
}
