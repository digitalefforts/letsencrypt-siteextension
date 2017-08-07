﻿using LetsEncrypt.Azure.Core.Models;

namespace LetsEncrypt.SiteExtension.Models
{
    public class GenerateAndInstallModel
    {
        public AzureWebAppEnvironment AzureEnvironment { get; set; }
        public AcmeConfig AcmeConfig { get; set; }

        public CertificateServiceSettings CertificateSettings { get; set; }

        public AuthorizationChallengeProviderConfig AuthorizationChallengeProviderConfig { get; set; }
    }
}