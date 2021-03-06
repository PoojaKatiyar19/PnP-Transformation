﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using Transformation.PowerShell.Base;
using Transformation.PowerShell.Common;

namespace Transformation.PowerShell.WebPart
{
    [Cmdlet(VerbsCommon.Add, "WebPart")]
    public class AddWebPart : TrasnformationPowerShellCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WebUrl;

        [Parameter(Mandatory = true, Position = 1)]
        public string ConfiguredWebPartFileName;

        [Parameter(Mandatory = true, Position = 2)]
        public string ConfiguredWebPartXmlFile;

        [Parameter(Mandatory = true, Position = 3)]
        public string WebPartZoneIndex;

        [Parameter(Mandatory = true, Position = 4)]
        public string WebPartZoneID;

        [Parameter(Mandatory = true, Position = 5)]
        public string ServerRelativePageUrl;

        [Parameter(Mandatory = true, Position = 6)]
        public string OutPutDirectory;

        [Parameter(Mandatory = true, Position = 7)]
        public string SharePointOnline_OR_OnPremise;

        [Parameter(Mandatory = true, Position = 8)]
        public string UserName;

        [Parameter(Mandatory = true, Position = 9)]
        public string Password;

        [Parameter(Mandatory = true, Position = 10)]
        public string Domain;
        
        protected override void ProcessRecord()
        {
            WebPartTransformationHelper webPartTransformationHelper = new WebPartTransformationHelper();
            webPartTransformationHelper.AddWebPart(WebUrl, ConfiguredWebPartFileName, ConfiguredWebPartXmlFile, WebPartZoneIndex, WebPartZoneID, ServerRelativePageUrl, OutPutDirectory, SharePointOnline_OR_OnPremise, UserName, Password, Domain,Constants.ActionType_Web);
        }    
    }
}
