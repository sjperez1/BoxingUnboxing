List<object> diffTypes = new List<object>();
int num1 = 7;
diffTypes.Add(num1);
int num2 = 28;
diffTypes.Add(num2);
int num3 = -1;
diffTypes.Add(num3);
bool addBool = true;
diffTypes.Add(addBool);
string addString = "chair";
diffTypes.Add(addString);

// need to put count on the outside of the for loop. If it is inside the for loop, it will reset the count to zero each time 
int count = 0;
for(int index = 0; index < diffTypes.Count; index++)
{
    Console.WriteLine(diffTypes[index]);
    if(diffTypes[index] is int) {
        // Have to put int in brackets because this is explicit casting
        count += (int) diffTypes[index];
    }
Console.WriteLine("here is the count" + count);
}