using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

//ApplicationConfiguration applicationConfiguration;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureAppConfiguration((ctx, builder) =>
    {
        var config = builder.Build();
        //builder.ConfigureAzureSecretsAndAppConfig(config[FuncConstants.AppConfigLabel]!);
    })
    //.UseLamar((context, registry) =>
    //{
    //    registry.IncludeRegistry<GlobalRegistry>();
    //})
    .ConfigureServices((builder, services) =>
    {
        //Log.Logger = Logger.CreateLoggerFromConfiguration(LoggingConfigurationOptions.Create(builder.Configuration));
        //services.AddLogging(lb =>
        //{
        //    lb.AddSerilog(Log.Logger, true);
        //});

        var serviceProvider = services.BuildServiceProvider();
        var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();
        //var logger = loggerFactory.CreateLogger<GlobalRegistry>();
        //services.AddSingleton(typeof(Evolent.Common.Utilities.Configuration.Model.UrlSettings), builder.Configuration.BindUrlSettingsFromConfig());
        //var applicationConfiguration = new ApplicationConfiguration();
        ////applicationConfiguration = builder.RegisterAppConfig();
        //builder.Configuration.Bind(applicationConfiguration);
        ////services.SetupCosmosDb(builder.Configuration);
        //services.AddTransient<IPatientNoteStatusFactory, PatientNoteStatusFactory>();

        //services.AddApplicationInsights(builder.Configuration, FuncConstants.ApplicationName, isWorkerService: true);
        //serviceProvider = services.BuildServiceProvider();
        //var telemetry = serviceProvider.GetRequiredService<ITelemetry>();
        //telemetry.TrackInfoEvent("NLPFunction Initialized.");
    }).Build();


host.Run();
