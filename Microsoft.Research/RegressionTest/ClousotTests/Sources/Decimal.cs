// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Configuration;
using System.Diagnostics.Contracts;

using Microsoft.Research.ClousotRegression;

internal class Test
{
    [ClousotRegressionTest]
    [RegressionOutcome(Outcome = ProofOutcome.Top, Message = "requires unproven: first != 0", PrimaryILOffset = 13, MethodILOffset = 17)]
    [RegressionOutcome(Outcome = ProofOutcome.False, Message = "requires is false: second != 0", PrimaryILOffset = 31, MethodILOffset = 17)]
    public static void Main(string[] args)
    {
        decimal first = 5;
        decimal second = 0;

        Console.WriteLine(Add(first, second));
    }

    [ClousotRegressionTest]
    public static decimal Add(decimal first, decimal second)
    {
        Contract.Requires(first != 0);
        Contract.Requires(second != 0);
        Contract.Ensures(Contract.Result<decimal>() == first + second);

        return first + second;
    }
}