using FluentPro.FluentPS.Psi.Services;
using System;

namespace FluentPro.FluentPS.Psi.Types
{
    public class QueueJob
    {
        private readonly QueuePsiService _queuePsiService;

        public QueueJob(Uri pwaUri, Guid jobGuid)
        {
            _queuePsiService = new QueuePsiService(pwaUri);
            JobUid = jobGuid;
        }

        public QueueJob(Uri pwaUri) : this(pwaUri, Guid.NewGuid())
        {
        }

        public Guid JobUid { get; private set; }

        public bool WaitSync()
        {
            return _queuePsiService.Wait(JobUid);
        }
    }
}
