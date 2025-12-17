using Legacy.GrpcContracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace UILookUpDropDownLib.BackendAPI.Mappers.Grpc
{
    internal class PackedObjectMapper
    {
        public IDictionary<string, PackedObject> Map(Dictionary<string, object> data)
        {
            var res = new Dictionary<string, PackedObject>();
            foreach (var kvp in data)
                res[kvp.Key] = Map(kvp.Value);
            return res;
        }

        public PackedObject Map(object obj)
        {
            if (obj == null)
                return new PackedObject {
                    ClrType = "null"
                };
            var objType = obj.GetType();
            using (var stream = new MemoryStream())
            {
                var serializer = new DataContractSerializer(objType);
                serializer.WriteObject(stream, obj);
                return new PackedObject
                {
                    ClrType = objType.FullName ?? objType.Name,
                    Payload = Google.Protobuf.ByteString.CopyFrom(stream.ToArray())
                };
            }
        }

        public object Map(PackedObject packedObject)
        {
            if (packedObject == null ||
                packedObject.ClrType == "null"
                ) return null;
            var packedObjectType = GetType(packedObject.ClrType) ??
                throw new InvalidDataContractException($"Unknown data type {packedObject.ClrType}!");
            using (var stream = new MemoryStream(packedObject.Payload.ToByteArray()))
            {
                var serializer = new DataContractSerializer(packedObjectType);
                return serializer.ReadObject(stream);
            }
        }

        private Type GetType(string typeName)
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies().Reverse())
            {
                var type = assembly.GetType(typeName);
                if (type != null) return type;
            }
            return null;
        }
    }
}
