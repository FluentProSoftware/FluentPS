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
            //TODO: Optimize this http://msdn.microsoft.com/en-us/library/office/gg177226(v=office.15).aspx
            //Here should not be never ending cycle
            while (true)
            {
                //TODO: Move to better interface
                var response = _psiContext.QueueSystem.GetJobCompletionState(new GetJobCompletionStateRequest(jobUid));
                //TODO: Handle errors from response
                var jobState = response.GetJobCompletionStateResult;

                if (jobState == JobState.Success)
                {
                    return true;
                }

                if (jobState == JobState.Unknown
                    || jobState == JobState.Failed
                    || jobState == JobState.FailedNotBlocking
                    || jobState == JobState.CorrelationBlocked
                    || jobState == JobState.Canceled)
                {
                    return false;
                }

                var waitTime = _psiContext.QueueSystem.GetJobWaitTime(jobUid);
                Thread.Sleep(waitTime * 1000);
            }
        }
    }
}
