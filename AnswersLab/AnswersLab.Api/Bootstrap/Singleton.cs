using Microsoft.Extensions.DependencyInjection;
using AnswersLab.Infrastructure.Singleton;
using AnswersLab.BoundedContext.Singleton;
using RxWeb.Core.Data;

namespace AnswersLab.Api.Bootstrap
{
    public static class Singleton
    {
        public static void AddSingletonService(this IServiceCollection serviceCollection)
        {
            #region Singleton
            serviceCollection.AddSingleton<ITenantDbConnectionInfo, TenantDbConnectionInfo>();
            serviceCollection.AddSingleton(typeof(UserAccessConfigInfo));
            #endregion Singleton
        }

    }
}




