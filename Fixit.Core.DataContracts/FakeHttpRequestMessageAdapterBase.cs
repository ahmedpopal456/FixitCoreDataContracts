using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace Fixit.Core.DataContracts
{
  // Move to DataContracts
  /// <summary>
  /// <para>Provides methods for converting btween any Object type T and any <see cref="HttpRequest"/> type.</para>
  /// <para>Should only be used for unit test purposes.</para>
  /// </summary>
  public abstract class FakeHttpRequestMessageAdapterBase
  {
    /// <summary>
    /// <para>Creates a fake <see cref="HttpRequestMessage"/> that wraps around the 'content'.</para>
    /// <para>Can specify the value for any members of the the <see cref="HttpRequestMessage"/>.</para>
    /// </summary>
    /// <param name="content"></param>
    /// <returns>The created <see cref="HttpRequestMessage"/>.</returns>
    protected abstract HttpRequestMessage CreateFakeHttpRequestMessage(ByteArrayContent content);


    /// <summary>
    /// Converts any Object to a <see cref="HttpRequestMessage"/>.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="dto"></param>
    /// <returns></returns>
    public HttpRequestMessage GetFakeHttpRequestMessage<T>(T dto)
    {
      var content = JsonConvert.SerializeObject(dto);
      var buffer = System.Text.Encoding.UTF8.GetBytes(content);
      var byteContent = new ByteArrayContent(buffer);
      return CreateFakeHttpRequestMessage(byteContent);
    }

    /// <summary>
    /// <para>Converts the 'responseObject' to the specified 'objectValue', if compatible.</para>
    /// <para>Otherwise, the 'objectValue' contains a default value.</para>
    /// </summary>
    /// <typeparam name="U"></typeparam>
    /// <typeparam name="T"></typeparam>
    /// <param name="responseObject"></param>
    /// <param name="objectValue"></param>
    /// <returns>True if conversion is compabitle, otherwise returns False.</returns>
    public bool IsResponseObjectTypeOf<U, T>(U responseObject, out T objectValue)
    {
      objectValue = default;
      var isObjectTypeT = typeof(T).IsInstanceOfType(responseObject);
      if (isObjectTypeT)
      {
        objectValue = (T)Convert.ChangeType(responseObject, typeof(T));
      }

      return isObjectTypeT;
    }
  }
}
