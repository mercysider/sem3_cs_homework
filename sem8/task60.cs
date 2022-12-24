Console.WriteLine("Введите кол-во строк массива:");
int intSizeX = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите кол-во столбцов массива:");
int intSizeY = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите глубину массива:");
int intSizeZ = int.Parse(Console.ReadLine()!);

int arraySize = intSizeX * intSizeY * intSizeZ;
if (arraySize > 90) 
{
    Console.WriteLine($"Невозможно создать массив из неповотряющихся {arraySize} двухзачных чисел!");
}
else
{
    //int[] uniqArray2D = UniqRandomValues();
    int[,,] Matrix3D = Generator3DMatrix(intSizeX, intSizeY, intSizeZ, 10, 99); 
    PrintElemetsOfArray(Matrix3D);
}

int[] UniqTwoDigitRandomValues()
{
    int[] maskForArrayIndex = new int[90];
    int[] uniqRandomArray = new int[90];

    for (int i = 0; i < maskForArrayIndex.Length; i++)
    {
        maskForArrayIndex[i] = new Random().Next(-1000000, 1000000);
    }

    for (int i = 10; i < 100; i++)
    {
        uniqRandomArray[i-10] = i;
    }

    int temp1 = 0;
    int temp2 = 0;
    for (int i = 0; i < maskForArrayIndex.Length-1; i++)
    {
        for (int j = i + 1; j < uniqRandomArray.Length; j++)
        {
            if (maskForArrayIndex[i] > maskForArrayIndex[j])
            {
                temp1 = maskForArrayIndex[i];
                temp2 = uniqRandomArray[i];
                maskForArrayIndex[i] = maskForArrayIndex[j];
                uniqRandomArray[i] = uniqRandomArray[j];
                maskForArrayIndex[j] = temp1;
                uniqRandomArray[j] = temp2;
            }
        }
    }
    return uniqRandomArray;
}

int[,,] Generator3DMatrix(int x, int y, int z, int min, int max)
{
    int row = x;
    int col = y;
    int deep = z;
    int arrayIndex = 0;
    int[] maskForArrayFilling = UniqTwoDigitRandomValues();
    int[,,] array3D = new int[row,col,deep];
      
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i,j,k] = maskForArrayFilling[arrayIndex];
                arrayIndex++;
            }            
        }        
    }
    return array3D;
}

void PrintElemetsOfArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {    
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine("");
        } 
        Console.WriteLine("-------------");               
    }
}