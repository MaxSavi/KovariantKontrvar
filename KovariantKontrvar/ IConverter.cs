using System;

public interface IConverter<in T, out U>
{
    U Convert(T value);
}

public class StringToIntConverter : IConverter<string, int>
{
    public int Convert(string value)
    {
        if (int.TryParse(value, out int result))
        {
            return result;
        }
        else
        {
            return 0;
        }

    }
}
public class ObjectToStringConverter : IConverter<object, string>
{
    public string Convert(object value)
    {
        return value.ToString();
    }
}

public class Program
{
    //Метод, который принимает на вход массив значений типа T и делегат типа IConverter<T, U>
    //и возвращает массив значений типа U, полученных путем применения делегата к каждому элементу массива.
    public static U[] Convertt<T, U>(T[] array, IConverter<T, U> converter)
    {
        U[] result = new U[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            result[i] = converter.Convert(array[i]);
        }
        return result;
    }

    public static void Main()
    {
        StringToIntConverter stringToInt = new StringToIntConverter();
        ObjectToStringConverter objectToString = new ObjectToStringConverter();
        string[] strArr = { "f1", "2", "3" };
        int[] intArr = Convertt(strArr, stringToInt);
        for (int i = 0; i < intArr.Length; i++)
            Console.WriteLine(intArr[i]);

        object[] obj = { 123, "456", 789 };
        string[] resultArr = Convertt(obj, objectToString);
        for (int i = 0; i < resultArr.Length; i++)
            Console.WriteLine(resultArr[i]);
    }
}
