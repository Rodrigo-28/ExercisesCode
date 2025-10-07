// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information


//Tu tarea:
//Tenés que escribir una función llamada printer_error que reciba una cadena como entrada y
//devuelva la tasa de error de la impresora, en forma de fracción (como un string), donde:

//El numerador es la cantidad de letras incorrectas (fuera del rango a-m).

//El denominador es la longitud total de la cadena.

//⚠️ No simplifiques la fracción.


//static string PrinterError(String s)
//{
//    //int cantidadFueraDeRango = 0;
//    //int cantidadTotal = s.Length;
//    //char[] chars = s.ToCharArray();

//    //for (int i = 0; i < chars.Length; i++)
//    //{
//    //    if (Regex.IsMatch(chars[i].ToString(), "[n-z]"))
//    //    {
//    //        cantidadFueraDeRango++;
//    //    }
//    //}
//    //return cantidadFueraDeRango.ToString() + "/" + cantidadTotal.ToString();
//    // con linq
//    //int cantidadTotal = s.Length;
//    //int errores = s.Count(c => c > 'm');

//    //return errores.ToString() + "/" + cantidadTotal.ToString();
//}

//Console.WriteLine(PrinterError("aaaxbbbbyyhwawiwjjjwwm"));


//  ****    Task    ****/
//Vas a recibir una cadena no vacía. Tu tarea es devolver el/los carácter(es) del medio de la cadena.

//Si la longitud de la cadena es impar, devuelve el carácter del medio.

//Si la longitud de la cadena es par, devuelve los 2 caracteres del medio.

//Ejemplos:

//"test" → "es"

//"testing" → "t"

//"middle" → "dd"

//"A" → "A"


//static string GetMiddle(string s)
{
    // Con Linq

    //int len = s.Length;
    //int mid = len / 2;

    //return new string(
    //    s.Skip(len % 2 == 0 ? mid - 1 : mid)
    //     .Take(len % 2 == 0 ? 2 : 1)
    //     .ToArray()
    //);

    //char[] chars = s.ToCharArray();
    //char[] respuesta = null;
    //int mid = chars.Length / 2;


    //if (chars.Length % 2 == 0)
    //{
    //    respuesta = new char[] { chars[mid - 1], chars[mid] };

    //}
    //else
    //{
    //    respuesta = new char[] { chars[mid] };
    //}

    //return new string(respuesta);

    // con subString
    //int len = s.Length;
    //int mid = len / 2;

    //if (len % 2 == 0)
    //{
    //    return s.Substring(mid - 1, 2); // toma 2 caracteres desde el medio-1
    //}
    //else
    //{
    //    return s.Substring(mid, 1); // toma 1 carácter desde el medio
    //}

}
//Console.WriteLine(GetMiddle("ASDAA"));


// ******* Task ******// 
// 🧩 Encuentra la letra que falta
//Escribe un método que reciba como entrada un arreglo de letras consecutivas (en orden creciente) y que devuelva la letra que falta en el arreglo.

//Siempre recibirás un arreglo válido, y siempre faltará exactamente una letra. La longitud del arreglo será de al menos 2 elementos.

//El arreglo siempre contendrá letras en un solo tipo de mayúsculas o minúsculas.

//Ejemplos:
//plaintext
//Copiar
//Editar
//['a','b','c','d','f'] → 'e'  
//['O','Q','R','S'] → 'P'🧩 Encuentra la letra que falta
//Escribe un método que reciba como entrada un arreglo de letras consecutivas (en orden creciente) y que devuelva la letra que falta en el arreglo.

//Siempre recibirás un arreglo válido, y siempre faltará exactamente una letra. La longitud del arreglo será de al menos 2 elementos.

//El arreglo siempre contendrá letras en un solo tipo de mayúsculas o minúsculas.

//Ejemplos:
//plaintext
//Copiar
//Editar
//['a','b','c','d','f'] → 'e'  
//['O','Q','R','S'] → 'P'



//static char FindMissingLetter(char[] array)
//{
//    // con linq
//    //char[] arrayMinuscula = array.Select(c => char.ToLower(c)).ToArray();
//    //char inicio = array[0];

//    //List<char> list = new List<char>();

//    //List<char> abecedario = Enumerable.Range(inicio, 26)
//    //                    .Select(x => (char)x)
//    //                    .ToList();
//    //for (int i = 0; i < array.Length; i++)
//    //{
//    //    if (array[i] != abecedario[i])
//    //    {
//    //        list.Add(abecedario[i]);
//    //        break;
//    //    }
//    //}


//    //return list[0];

//    // Se genera la secuencia esperada del primer al último elemento + 1 elemento (por la letra faltante).
//    var expected = Enumerable.Range(array[0], array.Length + 1)
//                             .Select(x => (char)x);
//    // Except devuelve la diferencia (la letra que falta).
//    return expected.Except(array).Single();
//}
//Console.WriteLine(FindMissingLetter(['a', 'b', 'c', 'd', 'f']).ToString());


//****************  Task ****************

//static string Rgb(int r, int g, int b)
//{
//    //int valorMax = 255;
//    //int valorMin = 0;

//    //string rojo = MaxMin(r, valorMax, valorMin).ToString("X2");
//    //string verde = MaxMin(g, valorMax, valorMin).ToString("X2");
//    //string azul = MaxMin(b, valorMax, valorMin).ToString("X2");

//    //return rojo + verde + azul;
//    // OPCION DOS

//    return ToHex(r) + ToHex(g) + ToHex(b);

//}

//static int MaxMin(int n, int valorMax, int valorMin)
//{
//    if (n > valorMax)
//    {
//        n = 255;
//    }
//    if (n < valorMin)
//    {
//        n = 0;
//    }
//    return n;
//}

//static string ToHex(int value)
//{
//    if (value < 0) value = 0;
//    if (value > 255) value = 255;
//    return value.ToString("X2");
//}

//*************** TASK      ****************/
//Crea una función que reciba como parámetro un número entero positivo entre 1 y 3999 (ambos inclusive)
//y que devuelva una cadena de texto con la representación en números romanos de ese número.

//Los números romanos modernos se escriben expresando cada dígito por separado, empezando
//por el dígito más a la izquierda, y omitendo cualquier dígito que tenga valor cero.
//Además, no puede haber más de 3 símbolos romanos idénticos seguidos.


//static string Solution(int n)
//{
//    //string resultado = "";
//    //int resta = n;
//    //int[] valores = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
//    //string[] simbolos = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };


//    //for (int i = 0; i < valores.Length; i++)
//    //{
//    //    while (resta >= valores[i])
//    //    {
//    //        resultado += simbolos[i];
//    //        resta -= valores[i];
//    //    }
//    //}
//    //return resultado;

//    // con diccionario
//    var mapa = new Dictionary<int, string>()
//    {
//        {1000, "M"},
//        {900, "CM"},
//        {500, "D"},
//        {400, "CD"},
//        {100, "C"},
//        {90, "XC"},
//        {50, "L"},
//        {40, "XL"},
//        {10, "X"},
//        {9, "IX"},
//        {5, "V"},
//        {4, "IV"},
//        {1, "I"}
//    };
//    string resultado = "";
//    foreach (var par in mapa)
//    {
//        while (n >= par.Key)
//        {
//            resultado += par.Value;
//            n -= par.Key;
//        }
//    }

//    return resultado;
//}

//Console.WriteLine(Solution(1987));


// *****        TASK        *******/

//ROT13 es un cifrado de sustitución de letras simple que reemplaza una letra con la letra que se encuentra 13 posiciones después en el alfabeto. ROT13 es un ejemplo del cifrado César.

//Crea una función que reciba una cadena de texto (string) y devuelva esa cadena cifrada con ROT13.
//Si hay números o caracteres especiales en la cadena, deben devolverse tal como están.
//Solo las letras del alfabeto latino/inglés deben desplazarse, como en la implementación original de ROT13.



//static string Rot13(string message)
{
    //message = message.ToUpper();

    //char[] buffer = new char[message.Length];

    //for (int i = 0; i < message.Length; i++)
    //{
    //    char c = message[i];

    //    if (c >= 'A' && c <= 'M' || c >= 'a' && c <= 'm')
    //    {
    //        buffer[i] = (char)(c + 13);
    //    }
    //    else if (c >= 'N' && c <= 'Z' || c >= 'n' && c <= 'z')
    //    {
    //        buffer[i] = (char)(c - 13);
    //    }
    //    else
    //    {
    //        buffer[i] = c;
    //    }

    //}
    //return new string(buffer);


    // segunda opcion
    //string result = "";
    //foreach (var s in message)
    //{
    //    if ((s >= 'a' && s <= 'm') || (s >= 'A' && s <= 'M'))
    //        result += Convert.ToChar((s + 13)).ToString();
    //    else if ((s >= 'n' && s <= 'z') || (s >= 'N' && s <= 'Z'))
    //        result += Convert.ToChar((s - 13)).ToString();
    //    else result += s;
    //}
    //return result;
    // opcion 3
    //return string.Concat(message.Select(c => char.IsLetter(c) ? (char)(c + (char.ToLower(c) > 'm' ? -13 : 13)) : c));

    //}
    //Console.WriteLine(Rot13("abcDd"));





    /// List<char> abecedario = Enumerable.Range(inicio, 26)
    ////    //                    .Select(x => (char)x)
    ////    //                    .ToList();
    ///

    // task //

    //Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.

    //Example
    //Kata.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 })
    //static string CreatePhoneNumber(int[] numbers)
    //{
    //    //string resultado = "";
    //    //int[] codigoArea = new int[3];
    //    //int[] primerosDigitos = new int[3];
    //    //int[] ultimosDigitos = new int[4];

    //    //if (numbers.Length > 10 || numbers.Length < 10)
    //    //{
    //    //    resultado = "el arreglo esta fuera de ranfgo";
    //    //}
    //    //for (int i = 0; i < numbers.Length; i++)
    //    //{
    //    //    if (i < 3)
    //    //    {
    //    //        codigoArea[i] = numbers[i];

    //    //    }
    //    //    else if (i < 6)
    //    //    {
    //    //        primerosDigitos[i - 3] = numbers[i];
    //    //    }
    //    //    else
    //    //    {
    //    //        ultimosDigitos[i - 6] = numbers[i];
    //    //    }


    //    //}
    //    //string area = "(" + string.Join("", codigoArea) + ")";
    //    //string primerosNumeros = " " + string.Join("", primerosDigitos) + "-";
    //    //string ultimoDigitos = string.Join("", ultimosDigitos);

    //    //return area + primerosNumeros + ultimoDigitos;


    //    // otra solucion sencilla
    //    //return $"({numbers[0]}{numbers[1]}{numbers[2]}) " +
    //    //  $"{numbers[3]}{numbers[4]}{numbers[5]}-" +
    //    //  $"{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";

    //    //otra solucion con linq
    //    //    var textos = numbers.Select(x => x.ToString());
    //    //    string area = string.Concat(textos.Take(3));
    //    //    string prefix = string.Concat(textos.Skip(3).Take(3));

    //    //    string line = string.Concat(textos.Skip(6).Take(4));

    //    //    return $"({area}) {prefix}- {line}";

    //    //return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", numbers.Select(x => x.ToString()).ToArray());

    //    //}



    //    //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
    //    //Console.WriteLine(CreatePhoneNumber(numbers));


    ////}

    //static bool IsPrime(int n)
    //{
    //    if (n <= 1) return false;

    //    for (int i = 2; i < n; i++)
    //    {
    //        if (n % i == 0) return false;
    //    }
    //    return true;

    //}

    //Console.WriteLine(IsPrime(10).ToString());


    //    La idea principal es contar todos los caracteres que aparecen en una cadena.
    //Si tienes una cadena como "aba", entonces el resultado debería ser:
    //    { 'a': 2, 'b': 1}.

    //¿Y si la cadena está vacía?
    //Entonces el resultado debería ser un objeto vacío: { }.

    //static Dictionary<char, int> Count(string str)
    //{
    //    char[] cadena = str.ToCharArray();
    //    Dictionary<char, int> letras = new Dictionary<char, int>();

    //    //foreach (char c in cadena)
    //    //{
    //    //    letras.Add(c, 0);
    //    //}


    //    foreach (char c in str)
    //    {

    //        if (letras.ContainsKey(c))
    //        {
    //            letras[c]++;
    //        }
    //        else
    //        {
    //            letras[c] = 1;
    //        }
    //    }



    //    return letras;

    //    /*** con LINQ ***/

    //    //return str.
    //    //    GroupBy(c => c)//Agrupa los caracteres iguales juntos ('a','a','b' → grupos de 'a' y 'b')
    //    //    .ToDictionary(g => g.Key, g => g.Count());//	Crea un diccionario con: clave = carácter (g.Key), valor = cantidad (g.Count())


    //}

    //var resultado = Count("aabbbzz");

    //foreach (KeyValuePair<char, int> par in resultado)
    //{
    //    Console.WriteLine($"'{par.Key}' aparece {par.Value} veces.");
    //}




    /*task*/
    //                📝 Tarea: Ordenar una cadena según números dentro de las palabras
    //Tu tarea es ordenar una cadena de texto dada.
    //Cada palabra en la cadena contendrá un solo número.
    //Ese número indica la posición que la palabra debe tener en el resultado final.

    //📌 Nota:
    //    Los números estarán en el rango del 1 al 9.
    //Por lo tanto, 1 será la primera palabra(no el índice 0).

    //Si la cadena de entrada está vacía, debes retornar una cadena vacía.

    //Las palabras en la cadena solo contendrán números válidos y consecutivos.

    //📚 Ejemplos:
    //    "is2 Thi1s T4est 3a" → "Thi1s is2 3a T4est"


    //static string Order(string words)
    //{
    //    string[] wordsWithComa = words.Split(' ');

    //    for (int i = 0; i < wordsWithComa.Length; i++)
    //    {

    //    }
    //    return string.Join(" ", wordsWithComa);

    //}
    //Console.WriteLine(Order("sfasf fasfas afas"));



    //public class PaginationHelper<T>
    //{
    //    private readonly IList<T> _collection;
    //    private readonly int _itemsPerPage;

    //    public PaginationHelper(IList<T> collection, int itemsPerPage)
    //    {
    //        this._collection = collection;
    //        this._itemsPerPage = itemsPerPage;
    //    }


    //    public int ItemCount
    //    {
    //        get
    //        {
    //            return _collection.Count();
    //        }
    //    }


    //    public int PageCount
    //    {
    //        get
    //        {
    //            var pageCount = Math.Ceiling((double)_collection.Count() / _itemsPerPage);
    //            return Convert.ToInt32(pageCount);
    //        }
    //    }


    //    public int PageItemCount(int pageIndex)
    //    {
    //        if (pageIndex < 0 || PageCount >= _itemsPerPage) return -1;
    //        // Si no es la última página
    //        if (pageIndex < PageCount - 1)
    //        {
    //            return _itemsPerPage;
    //        }
    //        int totalItems = _collection.Count;
    //        int totalFullPagesItems = (PageCount - 1) * _itemsPerPage;
    //        return totalItems - totalFullPagesItems;
    //    }


    //    public int PageIndex(int itemIndex)
    //    {
    //        if (itemIndex < 0 || itemIndex >= _collection.Count)
    //        {
    //            return -1;
    //        }

    //        return itemIndex / _itemsPerPage;
    //    }
}

//public class RomanNumerals
//{

//    public static string ToRoman(int n)
//    {
//        var mapa = new Dictionary<int, string>()
//    {
//        {1000, "M"},
//        {900, "CM"},
//        {500, "D"},
//        {400, "CD"},
//        {100, "C"},
//        {90, "XC"},
//        {50, "L"},
//        {40, "XL"},
//        {10, "X"},
//        {9, "IX"},
//        {5, "V"},
//        {4, "IV"},
//        {1, "I"}
//    };
//        string resultado = "";
//        // Paso 2: recorrer el mapa
//        foreach (var par in mapa)
//        {
//            while (n >= par.Key)
//            {
//                Console.WriteLine(par.Key.ToString());
//                resultado += par.Value;
//                n -= par.Key;
//            }
//        }

//        return resultado;
//    }

//    public static int FromRoman(string romanNumeral)
//    {

//        var mapa = new Dictionary<int, string>()
//    {
//        {1000, "M"},
//        {900, "CM"},
//        {500, "D"},
//        {400, "CD"},
//        {100, "C"},
//        {90, "XC"},
//        {50, "L"},
//        {40, "XL"},
//        {10, "X"},
//        {9, "IX"},
//        {5, "V"},
//        {4, "IV"},
//        {1, "I"}
//    };

//        int resultado = 0;
//        while (romanNumeral.Length > 0)
//        {
//            foreach (var par in mapa)
//            {
//                if (romanNumeral.StartsWith(par.Value))
//                {
//                    resultado += par.Key;
//                    romanNumeral = romanNumeral.Substring(par.Value.Length);
//                    break;
//                }
//            }
//        }

//        return resultado;
//    }
//}

//static string[] GetFizzBuzzArray(int n)
//{
//    string[] resultado = new string[n];

//    for (int i = 1; i <= n; i++)
//    {
//        if (i % 3 == 0 && i % 5 == 0)
//        {
//            resultado[i - 1] = "FizzBuzz";
//        }
//        else if (i % 3 == 0)
//        {
//            resultado[i - 1] = "Fizz";
//        }
//        else if (i % 5 == 0)
//        {
//            resultado[i - 1] = "Buzz";
//        }
//        else
//        {
//            resultado[i - 1] = i.ToString();
//        }
//    }

//    return resultado;
//    // con linq
//    return n > 0
//       ? Enumerable.Range(1, n)
//           .Select(x => x % 15 == 0 ? "FizzBuzz" : x % 3 == 0 ? "Fizz" : x % 5 == 0 ? "Buzz" : $"{x}")
//           .ToArray()
//       : throw new ArgumentOutOfRangeException();
//}


//static int max(int[] list)
//{
//    var mayor = list[0];
//    for (var i = 0; i < list.Length; i++)
//    {
//        if (list[i] > mayor)
//        {
//            mayor = list[i];
//        }
//    }
//    return mayor;
//}

//static int min(int[] list)
//{
//    var menor = list[0];

//    for (int i = 0; i < list.Length; i++)
//    {
//        if (list[i] < menor)
//        {
//            menor = list[i];
//        };
//    }
//    return menor;
//}

//Console.WriteLine(min([1, -3, -4, -6, 8, -1, 0, 45]));

static class FileNameExtractor
{
    public static string ExtractFileName(string dirtFileName)
    {
        var partes = dirtFileName.Split('_');


        string resto = string.Join("_", partes.Skip(1));


        var secciones = resto.Split('.');


        var sinExtensionExtra = secciones.Take(secciones.Length - 1);


        return string.Join(".", sinExtensionExtra);
    }
}











