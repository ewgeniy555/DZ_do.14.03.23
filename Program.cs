//Задача 54: Задайте двумерный массив.
//Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
double rd () {
              Random rnd=new Random();
             double a = rnd.Next(1,9);
             return a;
             }
             int x=3,y=4;
double[,] arr = new double[x,y];
//double[] arri = new double[3];
//void Arr (double [,] arr){//заполняет массив и распечатавает
for (int Y=0;Y<arr.GetLength(1);Y++){
    Console.WriteLine();
    for(int X=0;X<arr.GetLength(0);X++){
        arr[X,Y]=rd();
         Console.Write( arr[X,Y]);
         Console.Write(" ");}
         }
/////////////////////////////////////////////////////////////////////////
  
    int X1=0; 
    double ArrMax;
   for (int Y=0;Y<arr.GetLength(1);Y++){
    ArrMax = arr[0,Y];
    bool  swit=true;
     int switc=arr.GetLength(0);
     while (swit){
    
    switc--;
    if(X1+1<arr.GetLength(0)&&arr[X1,Y]<arr[X1+1,Y]){
        ArrMax=arr[X1+1,Y];
        arr[X1+1,Y]=arr[X1,Y];
        arr[X1,Y]=ArrMax;
        switc=arr.GetLength(0);
    }
    
    X1++;
    if(X1==arr.GetLength(0)){X1=0 ;}
    if(switc<0){swit=false;}
   }
    } Console.WriteLine();
    /////////////////////////////////////////////////////////////
    for (int Y=0;Y<arr.GetLength(1);Y++){
    Console.WriteLine();
    for(int X=0;X<arr.GetLength(0);X++){
    
         Console.Write( arr[X,Y]);
         Console.Write(" ");}
         }
        //Задача 56:
        //Задайте прямоугольный двумерный массив.
        // Напишите программу, которая будет находить строку с наименьшей суммой элементов.
      double[] summY = new double[y];
    for (int Y=0;Y<arr.GetLength(1);Y++){
    for(int X=0;X<arr.GetLength(0);X++){
        
       summY[Y] =summY[Y] + arr[X,Y];
        
    }
    }
    int index=0;
    double  max=0;
    double  min=0;
    for (int Y=0;Y<summY.GetLength(0);Y++){
        
        if(summY[index]>summY[Y]){index=Y;}
        
    }
    Console.WriteLine("индекс с наименьшей суммы в строке");
         Console.WriteLine(index);
     Console.WriteLine();
////////////////////////////////////////////////////////////////
//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
double vari=10;
double[,,] arr3D = new double[2,2,2];
for (int Y=0;Y<arr3D.GetLength(1);Y++){
    Console.WriteLine();
    for(int X=0;X<arr3D.GetLength(0);X++){
        for(int z=0;z<arr3D.GetLength(2);z++){
          arr3D[X,Y,z]=vari;
          vari++;
           Console.Write(" "); 
         Console.Write( arr3D[X,Y,z]);}
         }
         }

   
    
