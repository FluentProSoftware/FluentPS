using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FluentPro.FluentPS.Psi.Services;

namespace FluentPro.FluentPS.Services
{
    public class ProjectService
    {
        private readonly ProjectPsiService _projectPsiService;

        public ProjectService(Uri uri)
        {
            _projectPsiService = new ProjectPsiService(uri);
        }

        public Guid CreateProject(string name)
        {
            return _projectPsiService.Create(name);
        }
    }
}
