namespace TrandingBotClasses
{
    using System.IO;
    using System.Runtime.Serialization.Json;
    using System.Text;
    namespace Converte_Object_Json
    {
        public class JsonConversao
        {
            /// <summary>
            /// Transforma um objeto em um JSON.<para />
            /// </summary>
            /// <param name="obj">objeto.</param>
            public string ConverteObjectParaJSon<T>(T obj)
            {
                try
                {
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                    MemoryStream ms = new MemoryStream();
                    ser.WriteObject(ms, obj);
                    string jsonString = Encoding.UTF8.GetString(ms.ToArray());
                    ms.Close();
                    return jsonString;
                }
                catch
                {
                    throw;
                }
            }

            /// <summary>
            /// Transforma um JSON em um objeto.<para />
            /// </summary>
            /// <param name="jsonString">JSON em formato string.</param>
            public T ConverteJSonParaObject<T>(string jsonString)
            {
                try
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                    MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
                    T obj = (T)serializer.ReadObject(ms);
                    return obj;
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
