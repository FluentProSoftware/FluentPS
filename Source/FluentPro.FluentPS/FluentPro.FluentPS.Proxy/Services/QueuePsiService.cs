using FluentPro.FluentPS.Psi.Model.Enums;
using FluentPro.FluentPS.Psi.Model.Messages;
using FluentPro.FluentPS.Psi.Network;
using System;
using System.Threading;

namespace FluentPro.FluentPS.Psi.Services
{
    public class QueuePsiService
    {
        private readonly PsiContext _psiContext;

        public QueuePsiService(Uri pwaUri)
        {
            _psiContext = PsiContext.Get(pwaUri);
        }

        public bool Wait(Guid jobUid)
        {
            while (true)
            {
                var response = _psiContext.QueueSystem.Invoke(q => q.GetJobCompletionState(new GetJobCompletionStateRequest(jobUid)));
                var jobState = response.GetJobCompletionStateResult;
                if (jobState == JobState.Success)
                {
                    return true;
                }

                if (IsJobEndedAsFailed(jobState))
                {
                    return false;
                }

                var aproxSecondsRemaining = _psiContext.QueueSystem.Invoke(q => q.GetJobWaitTime(jobUid));
                Thread.Sleep(aproxSecondsRemaining * 1000); ;
            }
        }

        private bool IsJobEndedAsFailed(JobState jobState)
        {
            return jobState == JobState.Unknown
                || jobState == JobState.Failed
                || jobState == JobState.FailedNotBlocking
                || jobState == JobState.CorrelationBlocked
                || jobState == JobState.Canceled;
        }
    }
}
