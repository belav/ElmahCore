namespace ElmahCore.Mvc.Tests.Internal
{
   using System.Diagnostics;
   using Xunit;
   using Xunit.Abstractions;

   public class ErrorDetailHelperTests
   {
      private readonly ITestOutputHelper _output;

      public ErrorDetailHelperTests(ITestOutputHelper output)
      {
         this._output = output;
      }

      [Fact]
      public void ThisIsFast()
      {
         var stopwatch = Stopwatch.StartNew();
         ErrorDetailHelper.MarkupStackTrace(fastText, out _);
         this._output.WriteLine(stopwatch.ElapsedMilliseconds.ToString());
      }
      
       [Fact]
       public void ThisIsSlow()
       {
          var stopwatch = Stopwatch.StartNew();
          ErrorDetailHelper.MarkupStackTrace(slowText, out _);
          this._output.WriteLine(stopwatch.ElapsedMilliseconds.ToString());
       }

       private const string fastText = @"# caller: @C:\projects\third-party\ElmahCore\ElmahCore\Internal$\CallerInfo.cs:9
System.NullReferenceException: Object reference not set to an instance of an object.
   at Insite.Search.Elasticsearch.DocumentTypes.Product.Query.ProductSearchFacetProcessor.ProcessStringFacets(List`1 hits) in C:\projects\insite-commerce\Src\Backend\Plugins\Search\Insite.Search.Elasticsearch\DocumentTypes\Product\Query\ProductSearchFacetProcessor.cs:line 357
   at Insite.Search.Elasticsearch.DocumentTypes.Product.Query.Pipelines.Pipes.RunProductFacetSearch.ProcessBrandFirstCharacterHits.Execute(IUnitOfWork unitOfWork, RunProductFacetSearchParameter parameter, RunProductFacetSearchResult result) in C:\projects\insite-commerce\Src\Backend\Plugins\Search\Insite.Search.Elasticsearch\DocumentTypes\Product\Query\Pipelines\Pipes\RunProductFacetSearch\1100_ProcessBrandFirstCharacterHits.cs:line 28
   at Insite.Plugins.Pipelines.PipeAssemblyFactory.ExecutePipeline[TIn,TOut](TIn parameter, TOut result) in C:\projects\insite-commerce\Src\Backend\Plugins\Insite.Plugins\Pipelines\PipeAssemblyFactory.cs:line 35
   at Insite.Search.Elasticsearch.DocumentTypes.Product.Query.Pipelines.ProductSearchPipeline.RunProductFacetSearch(RunProductFacetSearchParameter parameter) in C:\projects\insite-commerce\Src\Backend\Plugins\Search\Insite.Search.Elasticsearch\DocumentTypes\Product\Query\Pipelines\ProductSearchPipeline.cs:line 55
   at Insite.Search.Elasticsearch.DocumentTypes.Product.Query.ProductSearchProviderElasticsearch.GetProductFacets(ProductFacetSearchParameter parameter) in C:\projects\insite-commerce\Src\Backend\Plugins\Search\Insite.Search.Elasticsearch\DocumentTypes\Product\Query\ProductSearchProviderElasticsearch.cs:line 473
   at Insite.Brands.Services.Handlers.GetBrandAlphabetHandler.GetBrandAlphabet.Execute(IUnitOfWork unitOfWork, GetBrandAlphabetParameter parameter, GetBrandAlphabetResult result) in C:\projects\insite-commerce\Src\Backend\Modules\Insite.Brands\Services\Handlers\GetBrandAlphabetHandler\500_GetBrandAlphabet.cs:line 29
   at Insite.Core.Services.Handlers.TransactionHandler`2.Execute(IUnitOfWork unitOfWork, TIn parameter, TOut result) in C:\projects\insite-commerce\Src\Backend\Core\Insite.Core\Services\Handlers\TransactionHandler.net8.0.cs:line 21
   at Insite.Core.Services.Handlers.OutOfProcessHandler`2.Execute(IUnitOfWork unitOfWork, TIn parameter, TOut result) in C:\projects\insite-commerce\Src\Backend\Core\Insite.Core\Services\Handlers\OutOfProcessHandler.net8.0.cs:line 13
   at Insite.Brands.Services.BrandService.GetBrandAlphabet(GetBrandAlphabetParameter parameter) in C:\projects\insite-commerce\Src\Backend\Modules\Insite.Brands\Services\BrandService.cs:line 105
   at Insite.Core.WebApi.BaseApiController.Execute[TMapper,TApiParameter,TServiceParameter,TServiceResult,TApiResult](TMapper mapper, Func`2 serviceMethod, TApiParameter apiParameter) in C:\projects\insite-commerce\Src\Backend\Public\Insite.Public.Core\WebApi\BaseApiController.cs:line 103
   at Insite.Core.WebApi.BaseApiController.ExecuteAsync[TMapper,TApiParameter,TServiceParameter,TServiceResult,TApiResult](TMapper mapper, Func`2 serviceMethod, TApiParameter apiParameter) in C:\projects\insite-commerce\Src\Backend\Public\Insite.Public.Core\WebApi\BaseApiController.cs:line 260
   at Insite.Brands.WebApi.V1.BrandAlphabetV1Controller.GetAsync(BrandAlphabetParameter parameter) in C:\projects\insite-commerce\Src\Backend\Modules\Insite.Brands\WebApi\V1\BrandAlphabetV1Controller.cs:line 42
   at lambda_method4092(Closure, Object, Object[])
   at Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor.TaskOfIActionResultExecutor.Execute(ActionContext actionContext, IActionResultTypeMapper mapper, ObjectMethodExecutor executor, Object controller, Object[] arguments)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeActionMethodAsync>g__Logged|12_1(ControllerActionInvoker invoker)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeNextActionFilterAsync>g__Awaited|10_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Rethrow(ActionExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.InvokeInnerFilterAsync()
--- End of stack trace from previous location ---
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeNextResourceFilter>g__Awaited|25_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Rethrow(ResourceExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.InvokeFilterPipelineAsync()
--- End of stack trace from previous location ---
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Awaited|17_0(ResourceInvoker invoker, Task task, IDisposable scope)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Awaited|17_0(ResourceInvoker invoker, Task task, IDisposable scope)
   at Microsoft.AspNetCore.Builder.RouterMiddleware.Invoke(HttpContext httpContext)
   at Microsoft.AspNetCore.ResponseCaching.ResponseCachingMiddleware.Invoke(HttpContext httpContext)
   at Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Authentication.AuthenticationMiddleware.Invoke(HttpContext context)
   at Insite.Shared.WebApplicationExtensions.<>c.<<UseQueryAccessToken>b__4_0>d.MoveNext() in C:\projects\insite-commerce\Src\Backend\Startup\Insite.Shared\WebApplicationExtensions.cs:line 133
--- End of stack trace from previous location ---
   at Insite.Shared.ExceptionHandling.StoreExceptionAsync(HttpContext context, Func`1 next) in C:\projects\insite-commerce\Src\Backend\Startup\Insite.Shared\ExceptionHandling.cs:line 125
   at ElmahCore.Mvc.ErrorLogMiddleware.InvokeAsync(HttpContext context) in C:\projects\third-party\ElmahCore\ElmahCore.Mvc\ErrorLogMiddleware.cs:line 170";
       
       private const string slowText = @"# caller: @C:\projects\third-party\ElmahCore\ElmahCore\Internal$\CallerInfo.cs:9
System.NullReferenceException: Object reference not set to an instance of an object.
   at Insite.Search.Elasticsearch.DocumentTypes.Product.Query.ProductSearchFacetProcessor.ProcessStringFacets(List`1 hits) in /work/Src/Backend/Plugins/Search/Insite.Search.Elasticsearch/DocumentTypes/Product/Query/ProductSearchFacetProcessor.cs:line 357
   at Insite.Search.Elasticsearch.DocumentTypes.Product.Query.Pipelines.Pipes.RunProductFacetSearch.ProcessBrandFirstCharacterHits.Execute(IUnitOfWork unitOfWork, RunProductFacetSearchParameter parameter, RunProductFacetSearchResult result) in /work/Src/Backend/Plugins/Search/Insite.Search.Elasticsearch/DocumentTypes/Product/Query/Pipelines/Pipes/RunProductFacetSearch/1100_ProcessBrandFirstCharacterHits.cs:line 28
   at Insite.Plugins.Pipelines.PipeAssemblyFactory.ExecutePipeline[TIn,TOut](TIn parameter, TOut result) in /work/Src/Backend/Plugins/Insite.Plugins/Pipelines/PipeAssemblyFactory.cs:line 35
   at Insite.Search.Elasticsearch.DocumentTypes.Product.Query.Pipelines.ProductSearchPipeline.RunProductFacetSearch(RunProductFacetSearchParameter parameter) in /work/Src/Backend/Plugins/Search/Insite.Search.Elasticsearch/DocumentTypes/Product/Query/Pipelines/ProductSearchPipeline.cs:line 55
   at Insite.Search.Elasticsearch.DocumentTypes.Product.Query.ProductSearchProviderElasticsearch.GetProductFacets(ProductFacetSearchParameter parameter) in /work/Src/Backend/Plugins/Search/Insite.Search.Elasticsearch/DocumentTypes/Product/Query/ProductSearchProviderElasticsearch.cs:line 473
   at Insite.Brands.Services.Handlers.GetBrandAlphabetHandler.GetBrandAlphabet.Execute(IUnitOfWork unitOfWork, GetBrandAlphabetParameter parameter, GetBrandAlphabetResult result) in /work/Src/Backend/Modules/Insite.Brands/Services/Handlers/GetBrandAlphabetHandler/500_GetBrandAlphabet.cs:line 29
   at Insite.Core.Services.Handlers.TransactionHandler`2.Execute(IUnitOfWork unitOfWork, TIn parameter, TOut result)
   at Insite.Core.Services.Handlers.OutOfProcessHandler`2.Execute(IUnitOfWork unitOfWork, TIn parameter, TOut result)
   at Insite.Brands.Services.BrandService.GetBrandAlphabet(GetBrandAlphabetParameter parameter) in /work/Src/Backend/Modules/Insite.Brands/Services/BrandService.cs:line 105
   at Insite.Core.WebApi.BaseApiController.Execute[TMapper,TApiParameter,TServiceParameter,TServiceResult,TApiResult](TMapper mapper, Func`2 serviceMethod, TApiParameter apiParameter) in /work/Src/Backend/Public/Insite.Public.Core/WebApi/BaseApiController.cs:line 103
   at Insite.Core.WebApi.BaseApiController.ExecuteAsync[TMapper,TApiParameter,TServiceParameter,TServiceResult,TApiResult](TMapper mapper, Func`2 serviceMethod, TApiParameter apiParameter) in /work/Src/Backend/Public/Insite.Public.Core/WebApi/BaseApiController.cs:line 260
   at Insite.Brands.WebApi.V1.BrandAlphabetV1Controller.GetAsync(BrandAlphabetParameter parameter) in /work/Src/Backend/Modules/Insite.Brands/WebApi/V1/BrandAlphabetV1Controller.cs:line 42
   at lambda_method4088(Closure, Object, Object[])
   at Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor.TaskOfIActionResultExecutor.Execute(ActionContext actionContext, IActionResultTypeMapper mapper, ObjectMethodExecutor executor, Object controller, Object[] arguments)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeActionMethodAsync>g__Awaited|12_0(ControllerActionInvoker invoker, ValueTask`1 actionResultValueTask)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeNextActionFilterAsync>g__Awaited|10_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Rethrow(ActionExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.InvokeInnerFilterAsync()
--- End of stack trace from previous location ---
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeNextResourceFilter>g__Awaited|25_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Rethrow(ResourceExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.InvokeFilterPipelineAsync()
--- End of stack trace from previous location ---
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Awaited|17_0(ResourceInvoker invoker, Task task, IDisposable scope)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Awaited|17_0(ResourceInvoker invoker, Task task, IDisposable scope)
   at Microsoft.AspNetCore.Builder.RouterMiddleware.Invoke(HttpContext httpContext)
   at Microsoft.AspNetCore.ResponseCaching.ResponseCachingMiddleware.Invoke(HttpContext httpContext)
   at Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Authentication.AuthenticationMiddleware.Invoke(HttpContext context)
   at Insite.Shared.WebApplicationExtensions.<>c.<<UseQueryAccessToken>b__4_0>d.MoveNext()
--- End of stack trace from previous location ---
   at Insite.Shared.ExceptionHandling.StoreExceptionAsync(HttpContext context, Func`1 next)
   at ElmahCore.Mvc.ErrorLogMiddleware.InvokeAsync(HttpContext context) in C:\projects\third-party\ElmahCore\ElmahCore.Mvc\ErrorLogMiddleware.cs:line 170";
   }
}