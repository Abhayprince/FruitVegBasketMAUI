using CommunityToolkit.Maui.Converters;
using System.Globalization;

namespace FruitVegBasket.Converter
{
    public class StringToColorConverter : BaseConverterOneWay<string, Color>
    {
        public override Color DefaultConvertReturnValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override Color ConvertFrom(string value, CultureInfo culture) =>
            Color.FromHex(value);
    }
}
