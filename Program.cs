/*
Create an empty List of type object
Add the following values to the list: 7, 28, -1, true, "chair"
Loop through the list and print all values
Add all values that are Int type together and output the sum
*/
List<object> BoxingPractice = new List<object>() { 7, 28, -1, true, "chair" };
int sum = 0;
for (int i = 0; i < BoxingPractice.Count; i++)
{

    if (BoxingPractice[i] is int)
    {
        sum += (int)BoxingPractice[i];
    }

}
Console.WriteLine(sum);