﻿using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace DotNetOpenAuth.Web.Clients
{
    internal static class JsonHelper
    {
        public static T Deserialize<T>(Stream stream) where T : class
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }

            var serializer = new DataContractJsonSerializer(typeof(T));
            return (T)serializer.ReadObject(stream);
        }
    }
}
