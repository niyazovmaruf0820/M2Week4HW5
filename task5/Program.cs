using task5;

Counter counter = new Counter(10);
counter.Decrement();
counter.Decrement();
counter.Plus();
counter.Reset();
counter.Plus();
counter.Plus();
counter.Plus();
counter.Plus();
counter.Plus();
System.Console.WriteLine(counter.ToString());