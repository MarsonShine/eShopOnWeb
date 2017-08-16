using Microsoft.AspNetCore.Mvc.Razor.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;

namespace Web.Services
{
    public class CustomCompilationService : DefaultRoslynCompilationService,ICompilationService
    {
        public CustomCompilationService(CSharpCompiler compiler, IRazorViewEngineFileProviderAccessor fileProviderAccessor, IOptions<RazorViewEngineOptions> optionsAccessor, ILoggerFactory loggerFactory) : base(compiler, fileProviderAccessor, optionsAccessor, loggerFactory)
        {
        }

        CompilationResult ICompilationService.Compile(RelativeFileInfo fileInfo, string compilationContent)
        {
            return base.Compile(fileInfo, compilationContent);
        }
    }
}
