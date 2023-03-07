using System;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Common.Utils
{
    public class Converter<TEnum> : ValueConverter<TEnum, string>
        where TEnum : struct
    {
        public Converter() : base(
            val => val.ToString(),
            val => Enum.Parse<TEnum>(val, true))
                { }
    }
}
