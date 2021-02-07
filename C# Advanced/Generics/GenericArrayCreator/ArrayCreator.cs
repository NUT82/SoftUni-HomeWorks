namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T defaultItem)
        {
            T[] resultArray = new T[length];
            for (int i = 0; i < length; i++)
            {
                resultArray[i] = defaultItem;
            }
            return resultArray;
        }
    }
}
