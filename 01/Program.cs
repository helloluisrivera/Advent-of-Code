String? line = null;
List<int> list1 = new List<int>();
List<int> list2 = new List<int>();
StreamReader sr = new StreamReader("./input");
line = sr.ReadLine();
while (line != null) {
	string[] lineArray = line.Split("   ");
	if (lineArray.Length > 0) {
		list1.Add(Int32.Parse(lineArray[0]));
		list2.Add(Int32.Parse(lineArray[1]));
	}
	line = sr.ReadLine();
}
if (list1.Count != list2.Count) {
	Console.WriteLine("The lists are not the same size!");
}
int similarityScore = 0;
for (int i = 0; i < list1.Count; i++) {
	int count = list2.Count(n => n == list1[i]) * list1[i];
	similarityScore = similarityScore += count;
}
Console.WriteLine("Similarity Score: " + similarityScore);
int totalDistance = 0;
while (list1.Count > 0) {
	int min1 = list1.Min();
	int min2 = list2.Min();
	list1.Remove(min1);
	list2.Remove(min2);
	totalDistance = totalDistance + Math.Abs(min1 - min2);
}
Console.WriteLine("Total Distance: " + totalDistance);
