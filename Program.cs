
int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] GenerateArray2DDD(int rows, int columns,int min, int max)
{
    
    int [,] numbers = new int [rows, columns];
    Random rnd = new Random ();
    
    for (int i = 0; i <numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
           numbers[i,j] = rnd.Next (min,max +1) ;
           
           
        }
        
    }

    
    
    return numbers;
}


int [,] GenerateArray2D(int rows, int columns,int min, int max)
{
    
    int [,] Numbers = new int [rows, columns];
    Random rnd = new Random ();
    
    for (int i = 0; i <Numbers.GetLength(0); i++)
    {
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
           Numbers[i,j] = rnd.Next (min,max +1) ;
           
           
        }
        
    }

    
    
    return Numbers;
}



int [,] umnozh(int [,] Numbers,int [,] numbers)
{
     int [,] Um = new int [Numbers.GetLength(0), Numbers.GetLength(1)];
 for (int i = 0; i <Numbers.GetLength(0); i++)
    {
        for (int j = 0; j < Numbers.GetLength(1); j++)
        {
            if(i==0)
            {
           Um[i,j]=(Numbers[i,j]*numbers[i,0])+(Numbers[i+1,j]*numbers[i,1]);
            }
            else
            {
             Um[i,j]=(Numbers[i-1,j]*numbers[i,0])+(Numbers[i,j]*numbers[i,1]);   
            }
           
           
        }
        
    }

return Um;
}





   
void PrintArray2Dd(int [,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
          System.Console.Write($"{numbers[i,j]}\t"); 
         }
System.Console.WriteLine();
 }
    System.Console.WriteLine();
    }
 
   
   
    int[,] array = GenerateArray2DDD(2,3,1,5);
    int[,] array2= GenerateArray2D(2,2,1,5);
    int[,] array3=umnozh(array,array2);


PrintArray2Dd(array);
PrintArray2Dd(array2);
PrintArray2Dd(array3);




