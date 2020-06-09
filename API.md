<a name='assembly'></a>
# btree

## Contents

- [BTree\`1](#T-CodeExMachina-BTree`1 'CodeExMachina.BTree`1')
  - [#ctor(degree,comparer)](#M-CodeExMachina-BTree`1-#ctor-System-Int32,System-Collections-Generic-Comparer{`0}- 'CodeExMachina.BTree`1.#ctor(System.Int32,System.Collections.Generic.Comparer{`0})')
  - [#ctor(degree,f)](#M-CodeExMachina-BTree`1-#ctor-System-Int32,CodeExMachina-FreeList{`0}- 'CodeExMachina.BTree`1.#ctor(System.Int32,CodeExMachina.FreeList{`0})')
  - [Length](#P-CodeExMachina-BTree`1-Length 'CodeExMachina.BTree`1.Length')
  - [Ascend(iterator)](#M-CodeExMachina-BTree`1-Ascend-CodeExMachina-ItemIterator{`0}- 'CodeExMachina.BTree`1.Ascend(CodeExMachina.ItemIterator{`0})')
  - [AscendGreaterOrEqual(pivot,iterator)](#M-CodeExMachina-BTree`1-AscendGreaterOrEqual-`0,CodeExMachina-ItemIterator{`0}- 'CodeExMachina.BTree`1.AscendGreaterOrEqual(`0,CodeExMachina.ItemIterator{`0})')
  - [AscendLessThan(pivot,iterator)](#M-CodeExMachina-BTree`1-AscendLessThan-`0,CodeExMachina-ItemIterator{`0}- 'CodeExMachina.BTree`1.AscendLessThan(`0,CodeExMachina.ItemIterator{`0})')
  - [AscendRange(greaterOrEqual,lessThan,iterator)](#M-CodeExMachina-BTree`1-AscendRange-`0,`0,CodeExMachina-ItemIterator{`0}- 'CodeExMachina.BTree`1.AscendRange(`0,`0,CodeExMachina.ItemIterator{`0})')
  - [Clear(addNodesToFreeList)](#M-CodeExMachina-BTree`1-Clear-System-Boolean- 'CodeExMachina.BTree`1.Clear(System.Boolean)')
  - [Clone()](#M-CodeExMachina-BTree`1-Clone 'CodeExMachina.BTree`1.Clone')
  - [Delete(item)](#M-CodeExMachina-BTree`1-Delete-`0- 'CodeExMachina.BTree`1.Delete(`0)')
  - [DeleteMax()](#M-CodeExMachina-BTree`1-DeleteMax 'CodeExMachina.BTree`1.DeleteMax')
  - [DeleteMin()](#M-CodeExMachina-BTree`1-DeleteMin 'CodeExMachina.BTree`1.DeleteMin')
  - [Descend(iterator)](#M-CodeExMachina-BTree`1-Descend-CodeExMachina-ItemIterator{`0}- 'CodeExMachina.BTree`1.Descend(CodeExMachina.ItemIterator{`0})')
  - [DescendGreaterThan(pivot,iterator)](#M-CodeExMachina-BTree`1-DescendGreaterThan-`0,CodeExMachina-ItemIterator{`0}- 'CodeExMachina.BTree`1.DescendGreaterThan(`0,CodeExMachina.ItemIterator{`0})')
  - [DescendLessOrEqual(pivot,iterator)](#M-CodeExMachina-BTree`1-DescendLessOrEqual-`0,CodeExMachina-ItemIterator{`0}- 'CodeExMachina.BTree`1.DescendLessOrEqual(`0,CodeExMachina.ItemIterator{`0})')
  - [DescendRange(lessOrEqual,greaterThan,iterator)](#M-CodeExMachina-BTree`1-DescendRange-`0,`0,CodeExMachina-ItemIterator{`0}- 'CodeExMachina.BTree`1.DescendRange(`0,`0,CodeExMachina.ItemIterator{`0})')
  - [Get(key)](#M-CodeExMachina-BTree`1-Get-`0- 'CodeExMachina.BTree`1.Get(`0)')
  - [Has(key)](#M-CodeExMachina-BTree`1-Has-`0- 'CodeExMachina.BTree`1.Has(`0)')
  - [Max()](#M-CodeExMachina-BTree`1-Max 'CodeExMachina.BTree`1.Max')
  - [MaxItems()](#M-CodeExMachina-BTree`1-MaxItems 'CodeExMachina.BTree`1.MaxItems')
  - [Min()](#M-CodeExMachina-BTree`1-Min 'CodeExMachina.BTree`1.Min')
  - [MinItems()](#M-CodeExMachina-BTree`1-MinItems 'CodeExMachina.BTree`1.MinItems')
  - [ReplaceOrInsert(item)](#M-CodeExMachina-BTree`1-ReplaceOrInsert-`0- 'CodeExMachina.BTree`1.ReplaceOrInsert(`0)')
- [FreeList\`1](#T-CodeExMachina-FreeList`1 'CodeExMachina.FreeList`1')
  - [#ctor(comparer)](#M-CodeExMachina-FreeList`1-#ctor-System-Collections-Generic-Comparer{`0}- 'CodeExMachina.FreeList`1.#ctor(System.Collections.Generic.Comparer{`0})')
  - [#ctor(size,comparer)](#M-CodeExMachina-FreeList`1-#ctor-System-Int32,System-Collections-Generic-Comparer{`0}- 'CodeExMachina.FreeList`1.#ctor(System.Int32,System.Collections.Generic.Comparer{`0})')
- [Int](#T-CodeExMachina-Int 'CodeExMachina.Int')
- [IntComparer](#T-CodeExMachina-IntComparer 'CodeExMachina.IntComparer')
- [ItemIterator\`1](#T-CodeExMachina-ItemIterator`1 'CodeExMachina.ItemIterator`1')

<a name='T-CodeExMachina-BTree`1'></a>
## BTree\`1 `type`

##### Namespace

CodeExMachina

##### Summary

BTree is an implementation of a B-Tree.

BTree stores Item instances in an ordered structure, allowing easy insertion,
removal, and iteration.

Write operations are not safe for concurrent mutation by multiple
tasks, but Read operations are.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the tree. |

<a name='M-CodeExMachina-BTree`1-#ctor-System-Int32,System-Collections-Generic-Comparer{`0}-'></a>
### #ctor(degree,comparer) `constructor`

##### Summary

Creates a new B-Tree with the given degree.

BTree(2), for example, will create a 2-3-4 tree (each node contains 1-3 items
and 2-4 children).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| degree | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| comparer | [System.Collections.Generic.Comparer{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Comparer 'System.Collections.Generic.Comparer{`0}') |  |

<a name='M-CodeExMachina-BTree`1-#ctor-System-Int32,CodeExMachina-FreeList{`0}-'></a>
### #ctor(degree,f) `constructor`

##### Summary

Creates a new B-Tree that uses the given node free list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| degree | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| f | [CodeExMachina.FreeList{\`0}](#T-CodeExMachina-FreeList{`0} 'CodeExMachina.FreeList{`0}') |  |

<a name='P-CodeExMachina-BTree`1-Length'></a>
### Length `property`

##### Summary

Returns the number of items currently in the tree.

<a name='M-CodeExMachina-BTree`1-Ascend-CodeExMachina-ItemIterator{`0}-'></a>
### Ascend(iterator) `method`

##### Summary

Calls the iterator for every value in the tree within the range
[first, last], until iterator returns false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| iterator | [CodeExMachina.ItemIterator{\`0}](#T-CodeExMachina-ItemIterator{`0} 'CodeExMachina.ItemIterator{`0}') |  |

<a name='M-CodeExMachina-BTree`1-AscendGreaterOrEqual-`0,CodeExMachina-ItemIterator{`0}-'></a>
### AscendGreaterOrEqual(pivot,iterator) `method`

##### Summary

Calls the iterator for every value in the tree within
the range [pivot, last], until iterator returns false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pivot | [\`0](#T-`0 '`0') |  |
| iterator | [CodeExMachina.ItemIterator{\`0}](#T-CodeExMachina-ItemIterator{`0} 'CodeExMachina.ItemIterator{`0}') |  |

<a name='M-CodeExMachina-BTree`1-AscendLessThan-`0,CodeExMachina-ItemIterator{`0}-'></a>
### AscendLessThan(pivot,iterator) `method`

##### Summary

Calls the iterator for every value in the tree within the range
[first, pivot), until iterator returns false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pivot | [\`0](#T-`0 '`0') |  |
| iterator | [CodeExMachina.ItemIterator{\`0}](#T-CodeExMachina-ItemIterator{`0} 'CodeExMachina.ItemIterator{`0}') |  |

<a name='M-CodeExMachina-BTree`1-AscendRange-`0,`0,CodeExMachina-ItemIterator{`0}-'></a>
### AscendRange(greaterOrEqual,lessThan,iterator) `method`

##### Summary

Calls the iterator for every value in the tree within the range
[greaterOrEqual, lessThan), until iterator returns false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| greaterOrEqual | [\`0](#T-`0 '`0') |  |
| lessThan | [\`0](#T-`0 '`0') |  |
| iterator | [CodeExMachina.ItemIterator{\`0}](#T-CodeExMachina-ItemIterator{`0} 'CodeExMachina.ItemIterator{`0}') |  |

<a name='M-CodeExMachina-BTree`1-Clear-System-Boolean-'></a>
### Clear(addNodesToFreeList) `method`

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

| Name | Type | Description |
| ---- | ---- | ----------- |
| addNodesToFreeList | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-CodeExMachina-BTree`1-Clone'></a>
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

<a name='M-CodeExMachina-BTree`1-Delete-`0-'></a>
### Delete(item) `method`

##### Summary

Removes an item equal to the passed in item from the tree, returning
it.  If no such item exists, returns nil.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`0](#T-`0 '`0') |  |

<a name='M-CodeExMachina-BTree`1-DeleteMax'></a>
### DeleteMax() `method`

##### Summary

Removes the largest item in the tree and returns it.
If no such item exists, returns nil.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree`1-DeleteMin'></a>
### DeleteMin() `method`

##### Summary

Removes the smallest item in the tree and returns it.
If no such item exists, returns nil.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree`1-Descend-CodeExMachina-ItemIterator{`0}-'></a>
### Descend(iterator) `method`

##### Summary

Calls the iterator for every value in the tree within the range
[last, first], until iterator returns false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| iterator | [CodeExMachina.ItemIterator{\`0}](#T-CodeExMachina-ItemIterator{`0} 'CodeExMachina.ItemIterator{`0}') |  |

<a name='M-CodeExMachina-BTree`1-DescendGreaterThan-`0,CodeExMachina-ItemIterator{`0}-'></a>
### DescendGreaterThan(pivot,iterator) `method`

##### Summary

Calls the iterator for every value in the tree within
the range [last, pivot), until iterator returns false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pivot | [\`0](#T-`0 '`0') |  |
| iterator | [CodeExMachina.ItemIterator{\`0}](#T-CodeExMachina-ItemIterator{`0} 'CodeExMachina.ItemIterator{`0}') |  |

<a name='M-CodeExMachina-BTree`1-DescendLessOrEqual-`0,CodeExMachina-ItemIterator{`0}-'></a>
### DescendLessOrEqual(pivot,iterator) `method`

##### Summary

Calls the iterator for every value in the tree within the range
[pivot, first], until iterator returns false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pivot | [\`0](#T-`0 '`0') |  |
| iterator | [CodeExMachina.ItemIterator{\`0}](#T-CodeExMachina-ItemIterator{`0} 'CodeExMachina.ItemIterator{`0}') |  |

<a name='M-CodeExMachina-BTree`1-DescendRange-`0,`0,CodeExMachina-ItemIterator{`0}-'></a>
### DescendRange(lessOrEqual,greaterThan,iterator) `method`

##### Summary

Calls the iterator for every value in the tree within the range
[lessOrEqual, greaterThan), until iterator returns false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lessOrEqual | [\`0](#T-`0 '`0') |  |
| greaterThan | [\`0](#T-`0 '`0') |  |
| iterator | [CodeExMachina.ItemIterator{\`0}](#T-CodeExMachina-ItemIterator{`0} 'CodeExMachina.ItemIterator{`0}') |  |

<a name='M-CodeExMachina-BTree`1-Get-`0-'></a>
### Get(key) `method`

##### Summary

Looks for the key item in the tree, returning it.  It returns nil if
unable to find that item.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [\`0](#T-`0 '`0') |  |

<a name='M-CodeExMachina-BTree`1-Has-`0-'></a>
### Has(key) `method`

##### Summary

Returns true if the given key is in the tree.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [\`0](#T-`0 '`0') |  |

<a name='M-CodeExMachina-BTree`1-Max'></a>
### Max() `method`

##### Summary

Returns the largest item in the tree, or nil if the tree is empty.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree`1-MaxItems'></a>
### MaxItems() `method`

##### Summary

Returns the max number of items to allow per node.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree`1-Min'></a>
### Min() `method`

##### Summary

Returns the smallest item in the tree, or nil if the tree is empty.

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree`1-MinItems'></a>
### MinItems() `method`

##### Summary

Returns the min number of items to allow per node (ignored for the
root node).

##### Parameters

This method has no parameters.

<a name='M-CodeExMachina-BTree`1-ReplaceOrInsert-`0-'></a>
### ReplaceOrInsert(item) `method`

##### Summary

Adds the given item to the tree.  If an item in the tree
already equals the given one, it is removed from the tree and returned.
Otherwise, nil is returned.

nil cannot be added to the tree (will panic).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`0](#T-`0 '`0') |  |

<a name='T-CodeExMachina-FreeList`1'></a>
## FreeList\`1 `type`

##### Namespace

CodeExMachina

##### Summary

FreeList represents a free list of btree nodes. By default each
BTree has its own FreeList, but multiple BTrees can share the same
FreeList.
Two Btrees using the same freelist are safe for concurrent write access.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the list. |

<a name='M-CodeExMachina-FreeList`1-#ctor-System-Collections-Generic-Comparer{`0}-'></a>
### #ctor(comparer) `constructor`

##### Summary

Creates a new free list with default size.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| comparer | [System.Collections.Generic.Comparer{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Comparer 'System.Collections.Generic.Comparer{`0}') |  |

<a name='M-CodeExMachina-FreeList`1-#ctor-System-Int32,System-Collections-Generic-Comparer{`0}-'></a>
### #ctor(size,comparer) `constructor`

##### Summary

Creates a new free list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| size | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| comparer | [System.Collections.Generic.Comparer{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Comparer 'System.Collections.Generic.Comparer{`0}') |  |

<a name='T-CodeExMachina-Int'></a>
## Int `type`

##### Namespace

CodeExMachina

##### Summary

Int implements the Item interface for integers.

<a name='T-CodeExMachina-IntComparer'></a>
## IntComparer `type`

##### Namespace

CodeExMachina

##### Summary

Compare two Ints.

 This must provide a strict weak ordering.
 If !(a < b) && !(b < a), we treat this to mean a == b (i.e. we can only
 hold one of either a or b in the tree).

<a name='T-CodeExMachina-ItemIterator`1'></a>
## ItemIterator\`1 `type`

##### Namespace

CodeExMachina

##### Summary

ItemIterator allows callers of Ascend* to iterate in-order over portions of
the tree.  When this function returns false, iteration will stop and the
associated Ascend* function will immediately return.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| i | [T:CodeExMachina.ItemIterator\`1](#T-T-CodeExMachina-ItemIterator`1 'T:CodeExMachina.ItemIterator`1') |  |
