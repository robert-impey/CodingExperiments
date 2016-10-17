using System;
namespace TextReverser.Model
{
    internal class TextConverter
    {
        private readonly Func<string, string> _action;

        internal TextConverter(Func<string, string> convertion)
        {
            _action = convertion;
        }

        internal string ConvertText(string input)
        {
            return _action(input);
        }
    }
}
