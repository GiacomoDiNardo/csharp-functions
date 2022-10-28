// See https://aka.ms/new-console-template for more information

//preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.

void StampaArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

// restituisca il quadrato del numero passato come parametro.

int Quadrato(int numero)
{
    return (numero * numero);
}

//preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] newArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i] * array[i];
    }
    return newArray;
}

//preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array

int SommaElementiArray(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

int[] numbers = {2, 6, 7, 5, 3, 9};

StampaArray(numbers);

Console.WriteLine();

StampaArray(ElevaArrayAlQuadrato(numbers));

Console.WriteLine();

Console.WriteLine(SommaElementiArray(numbers));

Console.WriteLine();

Console.WriteLine(SommaElementiArray(ElevaArrayAlQuadrato(numbers)));

