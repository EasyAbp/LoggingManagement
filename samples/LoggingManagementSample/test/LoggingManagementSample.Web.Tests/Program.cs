using LoggingManagementSample;
using Microsoft.AspNetCore.Builder;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<LoggingManagementSampleWebTestModule>();

public partial class Program
{
}