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



static string Rot13(string message)
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

}
Console.WriteLine(Rot13("abcDd"));





/// List<char> abecedario = Enumerable.Range(inicio, 26)
////    //                    .Select(x => (char)x)
////    //                    .ToList();