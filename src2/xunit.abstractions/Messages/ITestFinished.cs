﻿namespace Xunit.Abstractions
{
    public interface ITestFinished : ITestMessage
    {
        string DisplayName { get; }
        decimal ExecutionTime { get; }
        ITestCase TestCase { get; }
    }
}