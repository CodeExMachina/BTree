# BTree implementation for C#

![Travis CI Build Status](https://travis-ci.org/CodeExMachina/BTree.svg?branch=master)

This package provides an in-memory B-Tree implementation for C#, useful as
an ordered, mutable data structure.

The code and API are inspired by Google's excellent [Go implementation](https://github.com/google/btree).

## Installation

Install with [NuGet](https://www.nuget.org/packages/CodeExMachina.BTree/):

    Install-Package CodeExMachina.BTree
    
Or via the .NET Core command line interface:

    dotnet add package CodeExMachina.BTree

See [API](API.md) for documentation.

## Example
```C#
class Integer  
{
    private readonly int _v;

    public int Value => _v;

    public Integer(int v)
    {
        _v = v;
    }

    public override string ToString() => _v.ToString();             
}

// The Comparer must provide a strict weak ordering.
//
// If !(x < y) and !(y < x), we treat this to mean x == y 
// (i.e. we can only hold one of either x or y in the tree).

class IntegerComparer : Comparer<Integer>
{
    public override int Compare(Integer x, Integer y)
    {
        return x.Value < y.Value ? -1 : x.Value > y.Value ? 1 : 0;
    }
}

const int BTreeDegree = 32;

var tr = new BTree<Integer>(32, new IntegerComparer());

for (int i = 0; i < 10; i++)
{
    _ = tr.ReplaceOrInsert(new Integer(i));
}

Console.WriteLine("len:       {0}", tr.Length);
Console.WriteLine("get3:      {0}", tr.Get(new Integer(3)));
Console.WriteLine("get100:    {0}", tr.Get(new Integer(100)));
Console.WriteLine("del4:      {0}", tr.Delete(new Integer(4)));
Console.WriteLine("del100:    {0}", tr.Delete(new Integer(100)));
Console.WriteLine("replace5:  {0}", tr.ReplaceOrInsert(new Integer(5)));
Console.WriteLine("replace100:{0}", tr.ReplaceOrInsert(new Integer(100)));
Console.WriteLine("min:       {0}", tr.Min());
Console.WriteLine("delmin:    {0}", tr.DeleteMin());
Console.WriteLine("max:       {0}", tr.Max());
Console.WriteLine("delmax:    {0}", tr.DeleteMax());
Console.WriteLine("len:       {0}", tr.Length);

// Output:
// len:        10
// get3:       3
// get100:     
// del4:       4
// del100:     
// replace5:   5
// replace100: 
// min:        0
// delmin:     0
// max:        100
// delmax:     100
// len:        8
```

