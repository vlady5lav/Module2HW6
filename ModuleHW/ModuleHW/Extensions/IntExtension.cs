namespace ModuleHW
{
    public static class IntExtension
    {
        public static string ToTimeString(this int totalminutes)
        {
            int hours = totalminutes / 60;
            int minutes = totalminutes % 60;

            var time = $"{hours:00}:{minutes:00}";

            return time;
        }
    }
}
