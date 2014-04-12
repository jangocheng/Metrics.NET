﻿using System;
using System.Threading;

namespace Metrics.Utils
{
    /// <summary>
    /// Indicates the ability to schedule the execution of an Action at a specified interval
    /// </summary>
    public interface Scheduler : IDisposable
    {
        /// <summary>
        /// Schedule the <paramref name="action"/> to be executed a <paramref name="interval"/>.
        /// </summary>
        /// <param name="interval">Interval at which to execute action</param>
        /// <param name="action">Action to execute</param>
        void Start(TimeSpan interval, Action action);

        /// <summary>
        /// Schedule the <paramref name="action"/> to be executed a <paramref name="interval"/>.
        /// </summary>
        /// <param name="interval">Interval at which to execute action</param>
        /// <param name="action">Action to execute</param>
        void Start(TimeSpan interval, Action<CancellationToken> action);

        /// <summary>
        /// Stop the scheduler.
        /// </summary>
        void Stop();
    }
}