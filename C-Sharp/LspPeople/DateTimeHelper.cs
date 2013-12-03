using System;

namespace LspPeople
{
    internal static class DateTimeHelper
    {
        internal static int YearsSince(DateTime startDateTime)
        {
            var timeSpan = DateTime.Now - startDateTime;
            return (int)(timeSpan.Days / 365.25);
        }
    }
}
