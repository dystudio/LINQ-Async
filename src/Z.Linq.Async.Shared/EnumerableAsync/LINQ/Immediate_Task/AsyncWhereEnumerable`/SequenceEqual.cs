﻿// Description: Async extension methods for LINQ (Language Integrated Query).
// Website & Documentation: https://github.com/zzzprojects/LINQ-Async
// Forum: https://github.com/zzzprojects/LINQ-Async/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Z.Linq.Async;

namespace Z.Linq
{
    public static partial class EnumerableAsync
    {
        public static Task<bool> SequenceEqual<TSource>(this Task<AsyncWhereEnumerable<TSource>> first, IEnumerable<TSource> second, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(first, second, Enumerable.SequenceEqual, cancellationToken);
        }

        public static Task<bool> SequenceEqual<TSource>(this Task<AsyncWhereEnumerable<TSource>> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(first, second, comparer, Enumerable.SequenceEqual, cancellationToken);
        }
    }
}