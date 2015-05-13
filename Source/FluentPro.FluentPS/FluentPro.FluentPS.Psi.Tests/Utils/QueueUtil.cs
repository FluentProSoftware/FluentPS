﻿namespace FluentPro.FluentPS.Psi.Tests.Utils
{
    using FluentPro.FluentPS.Psi.Interfaces.Psi;
    using FluentPro.FluentPS.Psi.Model.Enums;
    using FluentPro.FluentPS.Psi.Model.Messages;
    using FluentPro.FluentPS.Psi.Network;
    using System;
    using System.Threading;

    public static class QueueUtil
    {
        public static bool Wait(Guid jobUid)
        {
            var queue = PsiContext.Get<IQueueSystem>(Settings.PwaUri);

            while (true)
            {
                var response = queue.Invoke(q => q.GetJobCompletionState(new GetJobCompletionStateRequest(jobUid)));
                var jobState = response.GetJobCompletionStateResult;
                if (jobState == JobState.Success)
                {
                    return true;
                }

                if (IsJobEndedAsFailed(jobState))
                {
                    return false;
                }

                var aproxSecondsRemaining = queue.Invoke(q => q.GetJobWaitTime(jobUid));
                Thread.Sleep(aproxSecondsRemaining * 1000);
            }
        }

        private static bool IsJobEndedAsFailed(JobState jobState)
        {
            return jobState == JobState.Unknown
                || jobState == JobState.Failed
                || jobState == JobState.FailedNotBlocking
                || jobState == JobState.CorrelationBlocked
                || jobState == JobState.Canceled;
        }
    }
}