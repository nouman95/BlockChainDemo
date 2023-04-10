namespace BlockChainDemo
{
    public class DataHash
    {
        //public static HashAlgorithm CoreHash(object data, HashAlgorithm engine)
        //{
        //    if (data == null)
        //    {
        //        return engine;
        //    }

        //    if (data is Array arrayData)
        //    {
        //        // Consider the type and dimensions of the array to distinguish arrays with the
        //        // same data, but different shape: [0 x 0] and [0 x 1], [1,2] and [1;2],
        //        // DOUBLE(0) and SINGLE([0,0]):
        //        // <  v016: [class, size, data]. BUG! 0 and zeros(1,1,0) had the same hash!
        //        // >= v016: [class, ndims, size, data]
        //        engine.Update(new byte[] { (byte)arrayData.GetType().Name.GetHashCode() });
        //        engine.Update(BitConverter.GetBytes((ulong)arrayData.Rank));
        //        foreach (var dimension in arrayData.GetLength())
        //        {
        //            engine.Update(BitConverter.GetBytes((ulong)dimension));
        //        }

        //        foreach (var element in arrayData)
        //        {
        //            CoreHash(element, engine);
        //        }
        //    }
        //    else if (data is string strData)
        //    {
        //        engine.Update(BitConverter.GetBytes((ulong)strData.Length));
        //        engine.Update(Encoding.Unicode.GetBytes(strData));
        //    }
        //    else if (data is IEnumerable enumerableData)
        //    {
        //        foreach (var element in enumerableData)
        //        {
        //            CoreHash(element, engine);
        //        }
        //    }
        //    else if (data is bool boolData)
        //    {
        //        engine.Update(BitConverter.GetBytes(boolData));
        //    }
        //    else if (data is char charData)
        //    {
        //        engine.Update(BitConverter.GetBytes(charData));
        //    }
        //    else if (data is byte byteData)
        //    {
        //        engine.Update(BitConverter.GetBytes(byteData));
        //    }
        //    else if (data is short shortData)
        //    {
        //        engine.Update(BitConverter.GetBytes(shortData));
        //    }
        //    else if (data is int intData)
        //    {
        //        engine.Update(BitConverter.GetBytes(intData));
        //    }
        //    else if (data is long longData)
        //    {
        //        engine.Update(BitConverter.GetBytes(longData));
        //    }
        //    else if (data is float floatData)
        //    {
        //        engine.Update(BitConverter.GetBytes(floatData));
        //    }
        //    else if (data is double doubleData)
        //    {
        //        engine.Update(BitConverter.GetBytes(doubleData));
        //    }
        //    else if (data is decimal decimalData)
        //    {
        //        var bits = decimal.GetBits(decimalData);
        //        foreach (var bit in bits)
        //        {
        //            engine.Update(BitConverter.GetBytes(bit));
        //        }
        //    }
        //    else if (data is Enum enumData)
        //    {
        //        engine.Update(BitConverter.GetBytes((ulong)enumData.GetHashCode()));
        //    }
        //    else if (data is Delegate delegateData)
        //    {
        //        var serializedDelegate = SerializeDelegate(delegateData);
        //        CoreHash(serializedDelegate, engine);
        //    }
        //    else if (data is object objectData)
        //    {
        //        var properties = objectData.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty);
        //        Array.Sort(properties, (a, b) => string.Compare(a.Name, b.Name));
        //        foreach (var property in properties)
        //        {
        //            var value = property.GetValue(objectData);
        //            CoreHash(value, engine);
        //        }
        //    }
        //    else
        //    {
        //        throw new ArgumentException($"Data of type {data.GetType()} cannot be hashed.");
        //    }

        //    return engine;
        //}

        //public static bool MyIsString(object S)
        //{
        //    bool hasString = true;
        //    try
        //    {
        //        hasString = typeof(string).GetMethod("IsNullOrEmpty") != null;
        //    }
        //    catch (System.Exception)
        //    {
        //        // do nothing
        //    }

        //    return hasString && (S is string);
        //}

        //public struct VersionData
        //{
        //    public int HashVersion;
        //    public int[] Date;
        //    public string[] HashMethod;
        //}

        //public VersionData Version_L()
        //{
        //    VersionData R = new VersionData();
        //    R.HashVersion = 4;
        //    R.Date = new int[] { 2018, 5, 19 };
        //    R.HashMethod = new string[] { };

        //    try
        //    {
        //        var providers = Java.security.Security.getProviders();
        //        for (int iProvider = 0; iProvider < providers.Length; iProvider++)
        //        {
        //            string s = new string(providers[iProvider].getServices());
        //            int[] index = System.Text.RegularExpressions.Regex.Matches(s, "MessageDigest.").Select(x => x.Index).ToArray();
        //            for (int iDigest = 0; iDigest < index.Length; iDigest++)
        //            {
        //                string digest = s.Substring(index[iDigest]);
        //                digest = digest.Substring(0, digest.IndexOf(" "));
        //                digest = digest.Replace("MessageDigest.", "");
        //                R.HashMethod = R.HashMethod.Concat(new string[] { digest }).ToArray();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Error.WriteLine(ex.Message);
        //        R.HashMethod = new string[] { "error" };
        //    }

        //    return R;
        //}
    }
}
