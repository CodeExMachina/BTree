<a name='assembly'></a>
# btree

## Contents

- [BTree](#T-CodeExMachina-BTree 'CodeExMachina.BTree')
  - [#ctor()](#M-CodeExMachina-BTree-#ctor-System-Int32- 'CodeExMachina.BTree.#ctor(System.Int32)')
  - [#ctor()](#M-CodeExMachina-BTree-#ctor-System-Int32,CodeExMachina-FreeList- 'CodeExMachina.BTree.#ctor(System.Int32,CodeExMachina.FreeList)')
  - [Length](#P-CodeExMachina-BTree-Length 'CodeExMachina.BTree.Length')
  - [Ascend()](#M-CodeExMachina-BTree-Ascend-CodeExMachina-ItemIterator- 'CodeExMachina.BTree.Ascend(CodeExMachina.ItemIterator)')
  - [AscendGreaterOrEqual()](#M-CodeExMachina-BTree-AscendGreaterOrEqual-CodeExMachina-Item,CodeExMachina-ItemIterator- 'CodeExMachina.BTree.AscendGreaterOrEqual(CodeExMachina.Item,CodeExMachina.ItemIterator)')
  - [AscendLessThan()](#M-CodeExMachina-BTree-AscendLessThan-CodeExMachina-Item,CodeExMachina-ItemIterator- 'CodeExMachina.BTree.AscendLessThan(CodeExMachina.Item,CodeExMachina.ItemIterator)')
  - [AscendRange()](#M-CodeExMachina-BTree-AscendRange-CodeExMachina-Item,CodeExMachina-Item,CodeExMachina-ItemIterator- 'CodeExMachina.BTree.AscendRange(CodeExMachina.Item,CodeExMachina.Item,CodeExMachina.ItemIterator)')
  - [Clear()](#M-CodeExMachina-BTree-Clear-System-Boolean- 'CodeExMachina.BTree.Clear(System.Boolean)')
  - [Clone()](#M-CodeExMachina-BTree-Clone 'CodeExMachina.BTree.Clone')
  - [Delete()](#M-CodeExMachina-BTree-Delete-CodeExMachina-Item- 'CodeExMachina.BTree.Delete(CodeExMachina.Item)')
  - [DeleteMax()](#M-CodeExMachina-BTree-DeleteMax 'CodeExMachina.BTree.DeleteMax')
  - [DeleteMin()](#M-CodeExMachina-BTree-DeleteMin 'CodeExMachina.BTree.DeleteMin')
  - [Descend()](#M-CodeExMachina-BTree-Descend-CodeExMachina-ItemIterator- 'CodeExMachina.BTree.Descend(CodeExMachina.ItemIterator)')
  - [DescendGreaterThan()](#M-CodeExMachina-BTree-DescendGreaterThan-CodeExMachina-Item,CodeExMachina-ItemIterator- 'CodeExMachina.BTree.DescendGreaterThan(CodeExMachina.Item,CodeExMachina.ItemIterator)')
  - [DescendLessOrEqual()](#M-CodeExMachina-BTree-DescendLessOrEqual-CodeExMachina-Item,CodeExMachina-ItemIterator- 'CodeExMachina.BTree.DescendLessOrEqual(CodeExMachina.Item,CodeExMachina.ItemIterator)')
  - [DescendRange()](#M-CodeExMachina-BTree-DescendRange-CodeExMachina-Item,CodeExMachina-Item,CodeExMachina-ItemIterator- 'CodeExMachina.BTree.DescendRange(CodeExMachina.Item,CodeExMachina.Item,CodeExMachina.ItemIterator)')
  - [Get()](#M-CodeExMachina-BTree-Get-CodeExMachina-Item- 'CodeExMachina.BTree.Get(CodeExMachina.Item)')
  - [Has()](#M-CodeExMachina-BTree-Has-CodeExMachina-Item- 'CodeExMachina.BTree.Has(CodeExMachina.Item)')
  - [Max()](#M-CodeExMachina-BTree-Max 'CodeExMachina.BTree.Max')
  - [MaxItems()](#M-CodeExMachina-BTree-MaxItems 'CodeExMachina.BTree.MaxItems')
  - [Min()](#M-CodeExMachina-BTree-Min 'CodeExMachina.BTree.Min')
  - [MinItems()](#M-CodeExMachina-BTree-MinItems 'CodeExMachina.BTree.MinItems')
  - [ReplaceOrInsert()](#M-CodeExMachina-BTree-ReplaceOrInsert-CodeExMachina-Item- 'CodeExMachina.BTree.ReplaceOrInsert(CodeExMachina.Item)')
- [FreeList](#T-CodeExMachina-FreeList 'CodeExMachina.FreeList')
  - [#ctor()](#M-CodeExMachina-FreeList-#ctor 'CodeExMachina.FreeList.#ctor')
  - [#ctor()](#M-CodeExMachina-FreeList-#ctor-System-Int32- 'CodeExMachina.FreeList.#ctor(System.Int32)')
- [Int](#T-CodeExMachina-Int 'CodeExMachina.Int')
  - [Less()](#M-CodeExMachina-Int-Less-CodeExMachina-Item- 'CodeExMachina.Int.Less(CodeExMachina.Item)')
- [Item](#T-CodeExMachina-Item 'CodeExMachina.Item')
  - [Less()](#M-CodeExMachina-Item-Less-CodeExMachina-Item- 'CodeExMachina.Item.Less(CodeExMachina.Item)')
- [ItemIterator](#T-CodeExMachina-ItemIterator 'CodeExMachina.ItemIterator')

<a name='T-CodeExMachina-BTree'></a>
## BTree `type`

##### Namespace

CodeExMachina

##### Summary

BTree is an implementation of a B-Tree.

BTree stores Item instances in an ordered structure, allowing easy insertion,
removal, and iteration.

Write operations are not safe for concurrent mutation by multiple
tasks, but Read operations are.

<a name='M-CodeExMachina-BTree-#ctor-System-Int32-'></a>
### #ctor() `constructor`

##### Summary

Creates a new B-Tree with the given degree.

BTree(2), for example, will create a 2-3-4 tree (each node contains 1-3 items
and 2-4 children).

##### Parameters

This constructor has no parameters.

<a name='M-CodeExMachina-BTree-#ctor-System-Int32,CodeExMachina-FreeList-'></a>
### #ctor() `constructor`

##### Summary

Creates a new B-Tree that uses the given node free list.

##### Parameters

This constructor has no parameters.

<a name='P-CodeExMachina-BTree-Length'></a>
### Length `property`

##### Summary

Returns the number of items currently in the tree.

<a name='M-CodeExMachina-BTree-Ascend-CodeExMachina-ItemIterator-'></a>
### Ascend() `method`

##### Summary

Calls the iterator for every value in the tree within the range
[first, last], until iterator returns false.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-AscendGreaterOrEqual-CodeExMachina-Item,CodeExMachina-ItemIterator-'></a>
### AscendGreaterOrEqual() `method`

##### Summary

Calls the iterator for every value in the tree within
the range [pivot, last], until iterator returns false.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-AscendLessThan-CodeExMachina-Item,CodeExMachina-ItemIterator-'></a>
### AscendLessThan() `method`

##### Summary

Calls the iterator for every value in the tree within the range
[first, pivot), until iterator returns false.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-AscendRange-CodeExMachina-Item,CodeExMachina-Item,CodeExMachina-ItemIterator-'></a>
### AscendRange() `method`

##### Summary

Calls the iterator for every value in the tree within the range
[greaterOrEqual, lessThan), until iterator returns false.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-Clear-System-Boolean-'></a>
### Clear() `method`

##### Summary

Removes all items from the btree.  If addNodesToFreelist is true,
t's nodes are added to its freelist as part of this call, until the freelist
is full.  Otherwise, the root node is simply dereferenced and the subtree
left to Go's normal GC processes.

This can be much faster
than calling Delete on all elements, because that requires finding/removing
each element in the tree and updating the tree accordingly.  It also is
somewhat faster than creating a new tree to replace the old one, because
nodes from the old tree are reclaimed into the freelist for use by the new
one, instead of being lost to the garbage collector.

This call takes:
    O(1): when addNodesToFreelist is false, this is a single operation.
    O(1): when the freelist is already full, it breaks out immediately
    O(freelist size):  when the freelist is empty and the nodes are all owned
        by this tree, nodes are added to the freelist until full.
    O(tree size):  when all nodes are owned by another tree, all nodes are
        iterated over looking for nodes to add to the freelist, and due to
        ownership, none are.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-Clone'></a>
### Clone() `method`

##### Summary

Clone clones the btree, lazily.  Clone should not be called concurrently,
but the original tree (t) and the new tree (t2) can be used concurrently
once the Clone call completes.

The internal tree structure of b is marked read-only and shared between t and
t2.  Writes to both t and t2 use copy-on-write logic, creating new nodes
whenever one of b's original nodes would have been modified.  Read operations
should have no performance degredation.  Write operations for both t and t2
will initially experience minor slow-downs caused by additional allocs and
copies due to the aforementioned copy-on-write logic, but should converge to
the original performance characteristics of the original tree.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-Delete-CodeExMachina-Item-'></a>
### Delete() `method`

##### Summary

Removes an item equal to the passed in item from the tree, returning
it.  If no such item exists, returns nil.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-DeleteMax'></a>
### DeleteMax() `method`

##### Summary

Removes the largest item in the tree and returns it.
If no such item exists, returns nil.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-DeleteMin'></a>
### DeleteMin() `method`

##### Summary

Removes the smallest item in the tree and returns it.
If no such item exists, returns nil.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-Descend-CodeExMachina-ItemIterator-'></a>
### Descend() `method`

##### Summary

Calls the iterator for every value in the tree within the range
[last, first], until iterator returns false.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-DescendGreaterThan-CodeExMachina-Item,CodeExMachina-ItemIterator-'></a>
### DescendGreaterThan() `method`

##### Summary

Calls the iterator for every value in the tree within
the range [last, pivot), until iterator returns false.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-DescendLessOrEqual-CodeExMachina-Item,CodeExMachina-ItemIterator-'></a>
### DescendLessOrEqual() `method`

##### Summary

Calls the iterator for every value in the tree within the range
[pivot, first], until iterator returns false.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-DescendRange-CodeExMachina-Item,CodeExMachina-Item,CodeExMachina-ItemIterator-'></a>
### DescendRange() `method`

##### Summary

Calls the iterator for every value in the tree within the range
[lessOrEqual, greaterThan), until iterator returns false.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-Get-CodeExMachina-Item-'></a>
### Get() `method`

##### Summary

Looks for the key item in the tree, returning it.  It returns nil if
unable to find that item.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-Has-CodeExMachina-Item-'></a>
### Has() `method`

##### Summary

Returns true if the given key is in the tree.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-Max'></a>
### Max() `method`

##### Summary

Returns the largest item in the tree, or nil if the tree is empty.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-MaxItems'></a>
### MaxItems() `method`

##### Summary

Returns the max number of items to allow per node.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-Min'></a>
### Min() `method`

##### Summary

Returns the smallest item in the tree, or nil if the tree is empty.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-MinItems'></a>
### MinItems() `method`

##### Summary

Returns the min number of items to allow per node (ignored for the
root node).

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree-ReplaceOrInsert-CodeExMachina-Item-'></a>
### ReplaceOrInsert() `method`

##### Summary

Adds the given item to the tree.  If an item in the tree
already equals the given one, it is removed from the tree and returned.
Otherwise, nil is returned.

nil cannot be added to the tree (will panic).

##### Parameters

This method has no parameters.

<a name='T-CodeExMachina-FreeList'></a>
## FreeList `type`

##### Namespace

CodeExMachina

##### Summary

FreeList represents a free list of btree nodes. By default each
BTree has its own FreeList, but multiple BTrees can share the same
FreeList.
Two Btrees using the same freelist are safe for concurrent write access.

<a name='M-CodeExMachina-FreeList-#ctor'></a>
### #ctor() `constructor`

##### Summary

Creates a new free list with default size.

##### Parameters

This constructor has no parameters.

<a name='M-CodeExMachina-FreeList-#ctor-System-Int32-'></a>
### #ctor() `constructor`

##### Summary

Creates a new free list.

##### Parameters

This constructor has no parameters.

<a name='T-CodeExMachina-Int'></a>
## Int `type`

##### Namespace

CodeExMachina

##### Summary

Int implements the Item interface for integers.

<a name='M-CodeExMachina-Int-Less-CodeExMachina-Item-'></a>
### Less() `method`

##### Summary

Less returns true if int(a) < int(b).

##### Parameters

This method has no parameters.

<a name='T-CodeExMachina-Item'></a>
## Item `type`

##### Namespace

CodeExMachina

##### Summary

Item represents a single object in the tree.

<a name='M-CodeExMachina-Item-Less-CodeExMachina-Item-'></a>
### Less() `method`

##### Summary

Less tests whether the current item is less than the given argument.

This must provide a strict weak ordering.
If !a.Less(b) && !b.Less(a), we treat this to mean a == b (i.e. we can only
hold one of either a or b in the tree).

##### Parameters

This method has no parameters.

<a name='T-CodeExMachina-ItemIterator'></a>
## ItemIterator `type`

##### Namespace

CodeExMachina

##### Summary

ItemIterator allows callers of Ascend* to iterate in-order over portions of
the tree.  When this function returns false, iteration will stop and the
associated Ascend* function will immediately return.
