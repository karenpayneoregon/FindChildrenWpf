using System.Collections.Generic;

namespace WpfAppExample1.Classes
{
    public class NewUsers 
    {
        /// <summary>
        /// Mocked list of verification codes which would normally be in a database table
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, int> SystemCodes()
        {
            return new Dictionary<int, int>()
            {
                { 123, 1 },
                { 222, 2 },
                { 345, 3 }
            };
        }
    }
}