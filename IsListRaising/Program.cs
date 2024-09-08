using System.Linq;
System.Console.Write("Enter numbers with white space between numbers:\t");
var arrint = ((Console.ReadLine()?.Split(' '))?.Select(x => int.Parse(x)))?.ToArray<int>();

string result = "YES";

for(int i = 0; i < arrint?.Length; i++){
  if(i + 1 < arrint.Length && arrint[i] >= arrint[i + 1])
  {
    result = "NO";
    break;
  }
}
System.Console.WriteLine(result);


