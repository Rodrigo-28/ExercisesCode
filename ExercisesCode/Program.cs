// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information


//Tu tarea:
//Tenés que escribir una función llamada printer_error que reciba una cadena como entrada y
//devuelva la tasa de error de la impresora, en forma de fracción (como un string), donde:

//El numerador es la cantidad de letras incorrectas (fuera del rango a-m).

//El denominador es la longitud total de la cadena.

//⚠️ No simplifiques la fracción.


static string PrinterError(String s)
{
    //int cantidadFueraDeRango = 0;
    //int cantidadTotal = s.Length;
    //char[] chars = s.ToCharArray();

    //for (int i = 0; i < chars.Length; i++)
    //{
    //    if (Regex.IsMatch(chars[i].ToString(), "[n-z]"))
    //    {
    //        cantidadFueraDeRango++;
    //    }
    //}
    //return cantidadFueraDeRango.ToString() + "/" + cantidadTotal.ToString();
    // con linq
    //int cantidadTotal = s.Length;
    //int errores = s.Count(c => c > 'm');

    //return errores.ToString() + "/" + cantidadTotal.ToString();
}

Console.WriteLine(PrinterError("aaaxbbbbyyhwawiwjjjwwm"));