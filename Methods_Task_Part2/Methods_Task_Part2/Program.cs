namespace Methods_Task_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1_Call
            //string[] city = { "Baku", "Milano", "Istanbul", "Madrid" };
            ////string[] newCity=ChangeArray(ref city);
            //ChangeArray(ref city);
            //foreach (var item in city) 
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region Task2_Call
            //string str = "Ulvino93";
            //Console.WriteLine(CheckString(str)); 
            #endregion


            #region Task3_Call
            //string[] fullName = { "Aysel Mammadova", "Maryam Aliyeva", "Durnisa Shahidli" };
            //string[] names = CreateArray(fullName);
            //foreach (string item in names)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
        }

        #region Task1_Method
        //static string[] ChangeArray(ref string[] array)
        //{
        //    string[] newArray = new string[0];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        string word = array[i].ToLower();
        //        for (int j = 0; j < word.Length; j++)
        //        {
        //            if (word[j]=='b')
        //            {
        //                Array.Resize(ref newArray, newArray.Length + 1);
        //                newArray[newArray.Length - 1] = array[i];
        //                break;
        //            }
        //        }
        //    }
        //    array = newArray;
        //    return array;
        //} 
        #endregion


        #region Task2_Method
        //static bool CheckString(string str)
        //{
        //   byte count = 0;
        //   if(str.Any(char.IsDigit))
        //    {
        //        count++;
        //    }
        //   if(str.Any(char.IsLower))
        //    {
        //        count++;
        //    }
        //   if (str.Any(char.IsUpper))
        //    {
        //        count++;
        //    }
        //   if(count==3)
        //    {
        //        return true;
        //    }
        //   else
        //    {
        //        return false;
        //    }
        //} 
        #endregion


        #region Task3_Method
        //static string[] CreateArray(string[] fullNames)
        //{
        //    string[] names = new string[0];
        //    for (int i = 0; i < fullNames.Length; i++)
        //    {
        //        string[] name = fullNames[i].Split(' ');
        //        Array.Resize(ref names, names.Length + 1);
        //        names[names.Length - 1] = name[0];
        //    }
        //    return names;
        //} 
        #endregion
    }
}