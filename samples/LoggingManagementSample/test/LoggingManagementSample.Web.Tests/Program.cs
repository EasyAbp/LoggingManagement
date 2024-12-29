using LoggingManagementSample;
using Microsoft.AspNetCore.Builder;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();

builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("LoggingManagementSample.Web.csproj");
await builder.RunAbpModuleAsync<LoggingManagementSampleWebTestModule>(applicationName: "LoggingManagementSample.Web" );

public partial class Program
{
}