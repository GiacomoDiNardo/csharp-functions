// See https://aka.ms/new-console-template for more information

//preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.

void StampaArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
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

//StampaArray(numbers);

//Console.WriteLine();

//StampaArray(ElevaArrayAlQuadrato(numbers));

//Console.WriteLine();

//Console.WriteLine(SommaElementiArray(numbers));

//Console.WriteLine();

//Console.WriteLine(SommaElementiArray(ElevaArrayAlQuadrato(numbers)));

//// BONUS

//Console.WriteLine("quanti numeri vuoi inserire?");
//int numEl = Convert.ToInt32(Console.ReadLine());
//int[] nums = new int[numEl];

//for (int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine("inserisci un numero");
//    nums[i] = Convert.ToInt32(Console.ReadLine());
//}

//StampaArray(nums);

//Console.WriteLine();

//StampaArray(ElevaArrayAlQuadrato(nums));

//Console.WriteLine();

//Console.WriteLine(SommaElementiArray(nums));

//Console.WriteLine();

//Console.WriteLine(SommaElementiArray(ElevaArrayAlQuadrato(nums)));


//ex zoom
//Si chiede di implementare due funzioni che eseguano le corrsipettive funzioni matematiche:
//1 - Fattoriale di un numero
//2 - La sequenza di fibonacci di un numero

int factorial(int number)
{
    if (number == 0)
    {
        return 1;
    } else
    {
        return number *= factorial(number - 1);
    }
}

Console.WriteLine(factorial(5));
Console.WriteLine();

void Fibonacci(int num1, int num2, int count)
{
    if (count == 0) return;

    int current = num1 + num2;

    Console.WriteLine(current);

    Fibonacci(num2, current, count - 1);
}

Fibonacci(0, 1, 20);