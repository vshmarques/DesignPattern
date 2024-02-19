using Adapter;

ILegacyAdapter adapter = new LegacyAdapter(new LegacyCode());

var result = adapter.Execute(2023, 12, 13);

Console.WriteLine(result);

Console.ReadLine();