// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
/*ejercicio uno:
Las cuentas de la asociación "Fat to Fit Club (FFC)" son supervisadas por John, 
quien trabaja como contador voluntario.
La asociación se financia a través de donaciones de benefactores generosos.

John tiene una lista con las primeras n donaciones:
[14, 30, 5, 7, 9, 11, 15]

Quiere saber cuánto debería donar el próximo benefactor para que el promedio de las n + 1
donaciones alcance un promedio de 30.

Después de hacer los cálculos, encontró que la cantidad necesaria es 149, 
pero cree que pudo haberse equivocado.*/

Console.WriteLine("Hello, World!");

//double[] numeros = { 14, 30, 5, 7, 9, 11, 15 };
//double navg = 92;

//long NewAvg(double[] numeros, double navg)
//{
//    if (numeros == null || numeros.Length == 0)
//    {
//        Console.WriteLine("el arreglo de numero esta vacio");
//        return 0;
//    }

//    double promedio = 0.0;
//    int cantidadDonaciones = numeros.Length;
//    double cantidadFaltante = 0;

//    for (int i = 0; i < numeros.Length; i++)
//    {
//        promedio += numeros[i];
//    }
//    promedio = promedio / numeros.Length;


//    string mensaje = promedio == navg ?
//        "No se necesitan mas donaciones, se llego al monto deseado" :
//        $"el monto q se necesita para la proxima donacion es de{(navg * (cantidadDonaciones + 1)) - (promedio * cantidadDonaciones)}";
//    Console.WriteLine(mensaje);

//    return (long)Math.Ceiling((navg * (cantidadDonaciones + 1)) - promedio * cantidadDonaciones);
//    // your code
//}


//NewAvg(numeros, navg);



//long NewAvg(double[] arr, double navg)
//{
//    var don = (arr.Length + 1) * navg - arr.Sum();
//    return don > 0 ? (long)Math.Ceiling(don) : throw new ArgumentException();
//}

//Console.WriteLine(NewAvg(numeros, navg));


/*task number 2
Welcome. In this kata, you are asked to square every digit of a number and concatenate them.

For example, if we run 9119 through the function, 
811181 will come out, because 92 is 81 and 12 is 1. (81-1-1-81)

Example #2: An input of 765 will/should return 493625 because 72 is 49, 62 is 36, and 52 is 25. (49-36-25)

Note: The function accepts an integer and returns an integer.

Happy Coding!*/

//int SquareDigits(int n)
//{
//    string numeroStr = n.ToString();
//    int[] digitos = new int[numeroStr.Length];

//    for (int i = 0; i < digitos.Length; i++)
//    {
//        digitos[i] = int.Parse(numeroStr[i].ToString());

//    }
//    int[] digitosCuadrados = new int[numeroStr.Length];

//    for (int i = 0; i < digitos.Length; i++)
//    {
//        digitosCuadrados[i] = digitos[i];
//    }

//    for (int i = 0; i < digitosCuadrados.Length; i++)
//    {
//        digitosCuadrados[i] = digitosCuadrados[i] * digitosCuadrados[i];
//    }


//    string numerosConcatenados = string.Join("", digitosCuadrados);



//    return int.Parse(numerosConcatenados);
//}

//string respuesta = SquareDigits(9119).ToString();
//Console.WriteLine(respuesta);

// ejercicio acortado
//int SquareDigitsBasic(int n)
//{
//    string numeroStr = n.ToString();
//    StringBuilder resultado = new StringBuilder();

//    foreach (char c in numeroStr)
//    {
//        int digito = int.Parse(c.ToString()); // Convertir char a int directamente
//        int cuadrado = digito * digito;
//        resultado.Append(cuadrado);
//    }

//    return int.Parse(resultado.ToString());
//}
//Console.WriteLine(SquareDigitsBasic(9119).ToString());

// task number two with linq
//int SquareDigitsLinq(int n) =>
//    int.Parse(string.Concat(n.ToString().Select(c => ((int)(c - '0') * (c - '0')).ToString())));
//Console.WriteLine(SquareDigitsLinq(9119).ToString());



// task number 4
/*Implement a function that computes the difference between two lists. The function should 
 * remove all occurrences of elements from the first list (a) that are present in the second list (b).
 * The order of elements in the first list should be preserved in the result.

Examples
If a = [1, 2] and b = [1], the result should be [2].

If a = [1, 2, 2, 2, 3] and b = [2], the result should be [1, 3].*/

//int[] a = new int[] { 1, 2, 2, 3, 4, 5 };
//int[] b = new int[] { 2, 3 };

//int[] ArrayDiff(int[] a, int[] b)
//{
//    List<int> list = new List<int>();
//    for (int i = 0; i < a.Length; i++)
//    {
//        bool found = false;
//        for (int j = 0; j < b.Length; j++)
//        {
//            if (a[i] == b[j])
//            {
//                found = true;
//                break;
//            }

//        }
//        if (!found)
//        {
//            list.Add(a[i]);
//        }
//    }
//    return list.ToArray();


//    //HashSet<int> setB = new HashSet<int>(b);

//    //List<int> list = new List<int>();

//    //foreach (int num in a)
//    //{
//    //    if (!setB.Contains(num))
//    //    {
//    //        list.Add(num);
//    //    };

//    //}
//    ////int[] resultArray = list.ToArray();
//    //return list.ToArray();


//}

//int[] resultArray = ArrayDiff(a, b);
//foreach (int num in resultArray)
//{
//    Console.WriteLine(num);
//}


/*La consigna en español sería:

Nuestra tarea es crear una función que pueda tomar cualquier número entero no negativo como argumento y 
devolverlo con sus dígitos en orden descendente. Es decir, 
reorganiza los dígitos para crear el número más grande posible.

Ejemplos: Entrada: 42145 Salida: 54421

Entrada: 145263 Salida: 654321

Entrada: 123456789 Salida: 987654321*/

//static int DescendingOrder(int num)
//{
//    if (num <= 0)
//    {
//        return -1;
//    }
//    string numberString = num.ToString();
//    char[] changeString = numberString.ToCharArray();

//    Array.Sort(changeString);

//    Array.Reverse(changeString);
//    string resultString = new string(changeString);



//    return int.Parse(resultString);
//}
//Console.WriteLine(DescendingOrder(123).ToString());
//Console.ReadKey();

//static int DescendingOrder(int num)
//{
//    if (num < 0)
//    {
//        return -1;
//    }

//    string numString = num.ToString();
//    char[] changeString = numString.ToCharArray();

//    for (int i = 0; i < changeString.Length - 1; i++)
//    {
//        for (int j = 0; j < changeString.Length - i - 1; j++)
//        {
//            if (changeString[j] < changeString[j + 1])
//            {

//                char temporal = changeString[j];
//                changeString[j] = changeString[j + 1];
//                changeString[j + 1] = temporal;
//            }

//        }
//    }
//    string resulString = new string(changeString);

//    return int.Parse(resulString);
//}
//Console.WriteLine(DescendingOrder(1021));


/*************** TASK ****************/
/*Tarea: Completa la solución de manera que se divida la cadena en pares de dos caracteres. Si la cadena contiene un número impar de caracteres, se debe reemplazar el segundo carácter faltante en el último par con un guion bajo ('_').

Ejemplos:

'abc' => ['ab', 'c_']

'abcdef' => ['ab', 'cd', 'ef'*/

//static string[] Solution(string str)
//{
//    char[] chars = str.ToCharArray();

//    int resultSize = (chars.Length + 1) / 2;
//    string[] result = new string[resultSize];
//    //Si i + 1 < chars.Length, significa que aún hay un carácter en esa posición, es decir, tenemos un par completo.
//    for (int i = 0; i < chars.Length; i += 2)
//    {
//        if (i + 1 < chars.Length)
//        {
//            result[i / 2] = new string(new char[] { chars[i], chars[i + 1] });
//        }
//        else
//        {
//            result[i / 2] = new string(new char[] { chars[i], '_' });
//        }

//    }
//    return result;
//}
// the best resolution
string[] Solution(string str)
{
    if (str.Length % 2 == 1)
        str += "_";

    List<string> list = new List<string>();
    for (int i = 0; i < str.Length; i += 2)
    {
        list.Add(str[i].ToString() + str[i + 1]);
    }

    return list.ToArray();
}




foreach (var item in Solution("abcd"))
{
    Console.WriteLine(item.ToString());
}



