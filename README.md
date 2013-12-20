WeightedRandom
==============

The WeightedRandom and WeightedRandomItem classes allow you assign weights to a finite set of items, and then randomly select those items. The frequency with which they are returned varies according to the weights you assign them.

Usage
-----

```csharp
var items = new WeightedRandomItem<string>[]
{
    new WeightedRandomItem<string> ("A", 50),
    new WeightedRandomItem<string> ("B", 40),
    new WeightedRandomItem<string> ("C", 10)
};

var weightedRandom = new WeightedRandom<string>(items);

// Call Next() repeatedly to get items.
// Over time, A will be returned ~50% of the time; B 40%; and C 10%.
string itemId = weightedRandom.Next();
```

Notes
-----

There is a private WeightedRandom constructor that allows you to specify a distribution size. I had intended on making it public, but have since had second thoughts -- it's easier to use this class if you leave the distribution size at 100. I may refactor and remove that constructor in the future.