# LoggingManagement

[![ABP version](https://img.shields.io/badge/dynamic/xml?style=flat-square&color=yellow&label=abp&query=%2F%2FProject%2FPropertyGroup%2FAbpVersion&url=https%3A%2F%2Fraw.githubusercontent.com%2FEasyAbp%2FLoggingManagement%2Fmain%2FDirectory.Build.props)](https://abp.io)
[![NuGet](https://img.shields.io/nuget/v/EasyAbp.LoggingManagement.Application.Contracts.svg?style=flat-square)](https://www.nuget.org/packages/EasyAbp.LoggingManagement.Application.Contracts)
[![NuGet Download](https://img.shields.io/nuget/dt/EasyAbp.LoggingManagement.Application.Contracts.svg?style=flat-square)](https://www.nuget.org/packages/EasyAbp.LoggingManagement.Application.Contracts)
[![Discord online](https://badgen.net/discord/online-members/S6QaezrCRq?label=Discord)](https://discord.gg/S6QaezrCRq)
[![GitHub stars](https://img.shields.io/github/stars/EasyAbp/LoggingManagement?style=social)](https://www.github.com/EasyAbp/LoggingManagement)


An abp application module to help you query and manage your application logs.

## Online Demo

We have launched an online demo for this module: [https://logging.samples.easyabp.io](https://logging.samples.easyabp.io)

## Installation

1. Install the following NuGet packages. ([see how](https://github.com/EasyAbp/EasyAbpGuide/blob/master/docs/How-To.md#add-nuget-packages))

    * EasyAbp.LoggingManagement.Application
    * EasyAbp.LoggingManagement.Application.Contracts
    * EasyAbp.LoggingManagement.HttpApi
    * EasyAbp.LoggingManagement.HttpApi.Client
    * (Optional) EasyAbp.LoggingManagement.Provider.TencentCloudCls
    * (Optional) EasyAbp.LoggingManagement.Web

1. Add `DependsOn(typeof(LoggingManagementXxxModule))` attribute to configure the module dependencies. ([see how](https://github.com/EasyAbp/EasyAbpGuide/blob/master/docs/How-To.md#add-module-dependencies))

## Usage

1. Add permissions to the roles you want.

1. Configure the system log provider.
    * Tencent Cloud CLS:
        ```csharp
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            // You can also
            Configure<LoggingManagementTencentCloudClsOptions>(x =>
            {
                x.SecretId = "pgZWZ8d1utwmDvG8BNP0QDZqM6cQIi2DIdGV";
                x.SecretKey = "6yb5Ykyks2UyhUGDMnzWIylXjz8xrQau";
                
                x.Region = "ap-guangzhou";
                x.LogSetId = "2e99fe65-5c24-43ad-ba78-8bee7d30c277";
                x.TopicId = "27b8ebf6-921a-4b5c-96e9-3ff0ec2308be";
        
                x.IsIntranet = false;
            });
        }
        ```
   You can also use [ABP settings](https://github.com/EasyAbp/LoggingManagement/blob/main/src/providers/EasyAbp.LoggingManagement.Provider.TencentCloudCls/EasyAbp/LoggingManagement/Provider/TencentCloudCls/Settings/LoggingManagementTencentCloudClsSettingDefinitionProvider.cs) to control the values of the above options. We recommend to you a great tool module to manage settings: [Abp.SettingUI](https://easyabp.io/modules/Abp.SettingUi).

![Index](/docs/images/Index.jpeg)
![Detail](/docs/images/Detail.jpeg)

## Road map

- [ ] Multi system log container.
- [ ] Support audit log management.
- [ ] More system log provider.
