using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NewsApp.Api.Client.DelegationHandler;
using NewsApp.Api.Client.Refit.Interfaces;
using Refit;
using System;

namespace NewsApp.Api.Client.Refit.Dependency
{
    public class RefitApiServiceDependency
    {

        #region fields

        private static RefitApiServiceDependency shared;
        private static object obj = new object();

        #endregion


        internal static IServiceCollection Services { get; set; }
        internal static IServiceProvider ServiceProvider { get; private set; }
        internal static IConfiguration Configuration { get; set; }

        private static RefitApiServiceDependency Shared
        {
            get
            {
                if (shared == null)
                {
                    lock (obj)
                    {
                        if (shared == null)
                        {
                            shared = new RefitApiServiceDependency();
                        }
                    }
                }

                return shared;
            }
        }



        private ICategoryApi _CategoryApi { get => ServiceProvider.GetRequiredService<ICategoryApi>(); }

        private IChannelCategoryMapApi _ChannelCategoryMapApi { get => ServiceProvider.GetRequiredService<IChannelCategoryMapApi>(); }

        private IChannelApi _ChannelApi { get => ServiceProvider.GetRequiredService<IChannelApi>(); }

        private INewsApi _NewsApi { get => ServiceProvider.GetRequiredService<INewsApi>(); }

        private INewsImageApi _NewsImageApi { get => ServiceProvider.GetRequiredService<INewsImageApi>(); }

        private ITagApi _TagApi { get => ServiceProvider.GetRequiredService<ITagApi>(); }
        private IUserApi _UserApi { get => ServiceProvider.GetRequiredService<IUserApi>(); }
        private INewsNewsTagMapApi _NewsNewsTagMapApi { get => ServiceProvider.GetRequiredService<INewsNewsTagMapApi>(); }


        //Exposed public static props via RefitApiServiceDependency.Shared 
        public static ICategoryApi CategoryApi { get => Shared._CategoryApi; }
        public static IChannelCategoryMapApi ChannelCategoryMapApi { get => Shared._ChannelCategoryMapApi; }
        public static IChannelApi ChannelApi { get => Shared._ChannelApi; }
        public static INewsApi NewsApi { get => Shared._NewsApi; }
        public static INewsImageApi NewsImageApi { get => Shared._NewsImageApi; }

        public static ITagApi TagApi { get => Shared._TagApi; }
        public static IUserApi UserApi { get => Shared._UserApi; }
        public static INewsNewsTagMapApi NewsNewsTagMapApi { get => Shared._NewsNewsTagMapApi; }




        private RefitApiServiceDependency()
        {
            if (Services == null)
                Services = new ServiceCollection();

            Init();
        }

        private void Init()
        {
            ConfigureServices(Services);
            ServiceProvider = Services.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<AuthTokenHandler>();
            services.AddHttpContextAccessor();
            services.AddSingleton<AppSettings>();


            // APP SETTINGS
            var configBuilder = new ConfigurationBuilder().AddJsonFile("FactorySettings.json", optional: true);
            var config = configBuilder.Build();
            services.Configure<AppSettings>(config);

            var baseaddress = new Uri("http://localhost:18200/api/v1");

            services.AddRefitClient<ICategoryApi>()
            .ConfigureHttpClient(c =>
            {
                c.BaseAddress = baseaddress;
            });
            //.AddHttpMessageHandler<AuthTokenHandler>()
            //.AddTransientHttpErrorPolicy(p => p.RetryAsync());


            services.AddRefitClient<IChannelCategoryMapApi>()
            .ConfigureHttpClient(c =>
            {
                c.BaseAddress = baseaddress;
            });
            //.AddHttpMessageHandler<AuthTokenHandler>()
            //.AddTransientHttpErrorPolicy(p => p.RetryAsync());

            services.AddRefitClient<IChannelApi>()
            .ConfigureHttpClient(c =>
            {
                c.BaseAddress = baseaddress;
            });
            //.AddHttpMessageHandler<AuthTokenHandler>()
            //.AddTransientHttpErrorPolicy(p => p.RetryAsync());

            services.AddRefitClient<INewsApi>()
            .ConfigureHttpClient(c =>
            {
                c.BaseAddress = baseaddress;
            });
            //.AddHttpMessageHandler<AuthTokenHandler>()
            //.AddTransientHttpErrorPolicy(p => p.RetryAsync());

            services.AddRefitClient<INewsImageApi>()
            .ConfigureHttpClient(c =>
            {
                c.BaseAddress = baseaddress;
            });
            //.AddHttpMessageHandler<AuthTokenHandler>()
            //.AddTransientHttpErrorPolicy(p => p.RetryAsync());

            services.AddRefitClient<ITagApi>()
            .ConfigureHttpClient(c =>
            {
                c.BaseAddress = baseaddress;
            });
            //.AddHttpMessageHandler<AuthTokenHandler>()
            //.AddTransientHttpErrorPolicy(p => p.RetryAsync());
            services.AddRefitClient<INewsNewsTagMapApi>()
            .ConfigureHttpClient(c =>
            {
                c.BaseAddress = baseaddress;
            });
            //.AddHttpMessageHandler<AuthTokenHandler>()
            //.AddTransientHttpErrorPolicy(p => p.RetryAsync());
        }

    }
}
