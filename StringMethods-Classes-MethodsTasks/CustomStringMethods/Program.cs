namespace CustomStringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "   Custom  Methods  ";
            string prevStr = "Custom";
            string nextStr = "String";


            #region CustomSubString method call
            //int startIndex = 3;
            //Console.WriteLine(CustomSubString(startIndex, inputStr));
            #endregion

            #region CustomTrim method call
            Console.WriteLine(CustomTrim(inputStr));
            #endregion

            #region CustomReplace method call
            //string changedString = CustomReplace(inputStr, prevStr, nextStr);
            //Console.WriteLine(changedString);
            #endregion

            #region CustomContains method call

            //bool contains = CustomContains(inputStr, searchStr);
            //if (contains)
            //{
            //    Console.WriteLine(CustomContains(inputStr, searchStr));
            //}
            //else
            //{
            //    Console.WriteLine($"{searchStr} not found in the string");
            //}
            #endregion

            #region CustomLastIndexOf method call
            //int lastIndexOf = CustomLastIndexOf(inputStr, searchStr);
            //if (lastIndexOf != -1)
            //{
            //    Console.WriteLine($"Last index of is: {lastIndexOf}");
            //}
            //else
            //{
            //    Console.WriteLine($"'{inputStr}' not found in the string.");
            //}
            #endregion
        }
        static int CustomLastIndexOf(string source, string searchVal)
        {
            for (int i = source.Length - searchVal.Length; i >= 0; i--)
            {
                if (source.Substring(i, searchVal.Length) == searchVal)
                {
                    return i;
                }
            }

            return -1;
        }
        static bool CustomContains(string source, string searchVal)
        {
            for (int i = 0; i < source.Length - searchVal.Length; i++)
            {
                if (source.Substring(i, searchVal.Length) == searchVal)
                {
                    return true;
                }
            }
            return false;
        }
        static string CustomReplace(string source, string search, string replace)
        {
            int startIndex = 0;
            Console.WriteLine(source.IndexOf(search, startIndex));
            while ((startIndex = source.IndexOf(search, startIndex)) != -1)
            {
                source = source.Substring(0, startIndex) + replace + source.Substring(startIndex + search.Length);
                startIndex += replace.Length;
            }

            return source;

        }
        static string CustomSubString(int index, string soruce)
        {
            string subStr = String.Empty;
            for (int i = index; i < soruce.Length; i++)
            {
                subStr += soruce[i];
            }
            return subStr;
        }
        static string CustomTrim(string source)
        {
            string trimStr = String.Empty;

            int start = 0;
            int end = source.Length - 1;
            while (start <= end && char.IsWhiteSpace(source[start]))
            {
                start++;
            }
            while (end >= start && char.IsWhiteSpace(source[end]))
            {
                end--;
            }
            Console.WriteLine(end + " " + start);

            int trimlength = end - start + 1;
            trimStr = source.Substring(start, trimlength);

            return trimStr;
        }
    }
}