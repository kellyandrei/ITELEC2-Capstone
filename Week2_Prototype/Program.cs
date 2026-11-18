var first = new HeartRateReading("Ana Reyes", 72, new DateTime(2026, 11, 18, 8, 0, 0));
var second = new HeartRateReading("Mark Cruz", 118, new DateTime(2026, 11, 18, 8, 5, 0));

Console.WriteLine(first.UpdateReading(75));   // valid action
Console.WriteLine(first.UpdateReading(300));  // rule violation, rejected
Console.WriteLine(first.BeatsPerMinute);      // still 75
Console.WriteLine(second.GetZone());          // second object