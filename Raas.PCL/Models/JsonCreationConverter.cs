/*
 * Raas.PCL
 *
 * This file was automatically generated for Tango Card, Inc. by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TangoCard.Raas;
using TangoCard.Raas.Utilities;

namespace TangoCard.Raas.Models
{
    public abstract class JsonCreationConverter<T> : JsonConverter 
    {
        public string typeName;
        public Dictionary<string, Type> dic;
        protected T Create(Type objectType, JObject jsonObject)
        {
            JToken token;
            if (!jsonObject.TryGetValue(typeName, out token))
                return  (T)Activator.CreateInstance(objectType);
            foreach (var type in dic)
                if (type.Key.Equals(token.ToString()))
                    return (T)Activator.CreateInstance(type.Value);
            return (T)Activator.CreateInstance(objectType);
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(T).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType,
          object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var target = Create(objectType, jsonObject);
            serializer.Populate(jsonObject.CreateReader(), target);
            return target;
        }

        public override bool CanWrite { get { return false; } }

        public override void WriteJson(JsonWriter writer, object value,
       JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}