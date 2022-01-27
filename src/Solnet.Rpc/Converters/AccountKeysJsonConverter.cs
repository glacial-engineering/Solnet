// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Solnet.Rpc.Converters
{
    public class AccountKeysJsonConverter : JsonConverter<string[]>
    {
        public override string[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var list = new LinkedList<string>();
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                reader.Read();
                do
                {
                    if (reader.TokenType == JsonTokenType.String)
                        list.AddFirst(reader.GetString());
                    else if (reader.TokenType == JsonTokenType.StartObject)
                    {
                        reader.Read();
                        if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "pubkey")
                        {
                            reader.Read();
                            list.AddFirst(reader.GetString());
                            while (reader.TokenType != JsonTokenType.EndObject)
                                reader.Read();
                        }
                    } else
                    {
                        throw new Exception("expected string or object");
                    }
                    reader.Read();
                } while (reader.TokenType != JsonTokenType.EndArray);
            } else
            {
                throw new Exception("expected array");
            }
            return list.ToArray();
        }

        public override void Write(Utf8JsonWriter writer, string[] value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}