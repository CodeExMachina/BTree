using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using CodeExMachina;

namespace btree_benchmark
{
    internal static class Extensions
    {
        public static int[] Perm(this Random r, int n)
        {
            int[] m = new int[n];
            for (int i = 0; i < n; i++)
            {
                int j = r.Next(i + 1);
                m[i] = m[j];
                m[j] = i;
            }
            return m;
        }
    }

    public class BTreeBenchmarks
    {
        private const int BTreeDegree = 32;
        private const int BenchmarkTreeSize = 10000;

        private readonly Random _rand = new Random();

        private int _i = 0;
        private int _size = 0;
        private List<Item> _insertP;
        private BTree _tr;

        private List<Item> Perm(int n)
        {
            List<Item> list = new List<Item>();
            foreach (int v in _rand.Perm(n))
            {
                list.Add(new Int(v));
            }
            return list;
        }

        private void InitBenchmark(int size)
        {
            _insertP = Perm(size);
            _tr = new BTree(BTreeDegree);
            foreach (Item item in _insertP)
            {
                _tr.ReplaceOrInsert(item);
            }
            _i = 0;
        }

        [GlobalSetup(Target = nameof(BenchmarkInsert))]
        public void SetupBenchmarkInsert()
        {
            _insertP = Perm(BenchmarkTreeSize);
        }

        [Benchmark]
        public BTree BenchmarkInsert()
        {
            var tr = new BTree(BTreeDegree);
            foreach (var item in _insertP)
            {
                tr.ReplaceOrInsert(item);
            }
            return tr;
        }

        [GlobalSetup(Target = nameof(BenchmarkSeek))]
        public void SetupBenchmarkSeek()
        {
            _size = 100000;
            InitBenchmark(_size);
        }

        [Benchmark]
        public int BenchmarkSeek()
        {
            _tr.AscendGreaterOrEqual(new Int(_i % _size), (Item i) =>
            {
                return false;
            });
            return _i++;
        }

        [GlobalSetup(Target = nameof(BenchmarkDeleteInsert))]
        public void SetupBenchmarkDeleteInsert()
        {
            InitBenchmark(BenchmarkTreeSize);
        }

        [Benchmark]
        public int BenchmarkDeleteInsert()
        {
            _tr.Delete(_insertP[_i % BenchmarkTreeSize]);
            _tr.ReplaceOrInsert(_insertP[_i % BenchmarkTreeSize]);
            return _i++;
        }

        [GlobalSetup(Target = nameof(BenchmarkDeleteInsertCloneOnce))]
        public void SetupBenchmarkDeleteInsertCloneOnce()
        {
            InitBenchmark(BenchmarkTreeSize);
            _tr = _tr.Clone();
        }

        [Benchmark]
        public int BenchmarkDeleteInsertCloneOnce()
        {
            _tr.Delete(_insertP[_i % BenchmarkTreeSize]);
            _tr.ReplaceOrInsert(_insertP[_i % BenchmarkTreeSize]);
            return _i++;
        }

        [GlobalSetup(Target = nameof(BenchmarkDeleteInsertCloneEachTime))]
        public void SetupBenchmarkDeleteInsertCloneEachTime()
        {
            InitBenchmark(BenchmarkTreeSize);
        }

        [Benchmark]
        public int BenchmarkDeleteInsertCloneEachTime()
        {
            _tr = _tr.Clone();
            _tr.Delete(_insertP[_i % BenchmarkTreeSize]);
            _tr.ReplaceOrInsert(_insertP[_i % BenchmarkTreeSize]);
            return _i++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<BTreeBenchmarks>();
        }
    }
}
