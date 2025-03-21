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
int SquareDigitsLinq(int n) =>
    int.Parse(string.Concat(n.ToString().Select(c => ((int)(c - '0') * (c - '0')).ToString())));
Console.WriteLine(SquareDigitsLinq(9119).ToString());