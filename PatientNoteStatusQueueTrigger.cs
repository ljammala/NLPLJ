using Microsoft.Azure.Functions.Worker;

namespace Evolent.NLPService.NLPFunction
{
    public class PatientNoteStatusQueueTrigger
    {
        //private readonly ILogger _logger;
        //private readonly ITelemetry _telemetry;
        //private readonly IPatientIngestionWorkflowService _patientIngestionService;
        //private readonly IDocumentIngestionWorkflowService _documentIngestionWorkflowService;

        //public PatientNoteStatusQueueTrigger(
        //    ILoggerFactory loggerFactory, 
        //    IPatientIngestionWorkflowService patientIngestionService,
        //    IDocumentIngestionWorkflowService documentIngestionWorkflowService,
        //    ITelemetry telemetry)
        //{
        //    _logger = loggerFactory.CreateLogger<PatientNoteStatusQueueTrigger>();
        //    _patientIngestionService = patientIngestionService;
        //    _documentIngestionWorkflowService = documentIngestionWorkflowService;
        //    _telemetry = telemetry;
        //}

        [Function("PatientNoteStatusQueueTrigger")]
        public async Task RunAsync([ServiceBusTrigger("%PatientNotesQueue%", Connection = "ServiceBusConnectionString")] string myQueueItem)
        {
            try
            {
                //PatientNoteMessage patientNoteMessage = JsonConvert.DeserializeObject<PatientNoteMessage>(myQueueItem);

                //if (patientNoteMessage == null)
                //{
                //    return;
                //}

                //if (!patientNoteMessage.patientExists)
                //{

                //    await _patientIngestionService.IngestPatient(patientNoteMessage);
                //}

                //else if (patientNoteMessage.patientExists && !patientNoteMessage.noteIngested)
                //{
                //    await _documentIngestionWorkflowService.IngestDocument(patientNoteMessage);
                //}

                //_logger.LogInformation($"C# ServiceBus queue trigger function processed message: {patientNoteMessage}");
                //_telemetry.TrackInfoEvent($"Received service bus message: patient id: {patientNoteMessage}");
            }

            catch (Exception ex)
            {
                //_logger.LogError($"Exception captured while process patient note message: {ex.Message}");
            }

        }
    }
}
    