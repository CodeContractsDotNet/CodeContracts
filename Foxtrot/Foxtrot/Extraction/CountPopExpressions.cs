// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Compiler;

namespace Microsoft.Contracts.Foxtrot
{
    public sealed class CountPopExpressions : Inspector
    {
        internal int PopOccurrences;

        public override void VisitExpression(Expression expression)
        {
            if (expression == null) return;

            if (expression.NodeType == NodeType.Pop)
                PopOccurrences++;

            base.VisitExpression(expression);
        }

        public static int Count(Node node)
        {
            var counter = new CountPopExpressions();

            counter.Visit(node);

            return counter.PopOccurrences;
        }
    }
}