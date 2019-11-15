#region License
/*
Copyright © 2014-2019 European Support Limited

Licensed under the Apache License, Version 2.0 (the "License")
you may not use this file except in compliance with the License.
You may obtain a copy of the License at 

http://www.apache.org/licenses/LICENSE-2.0 

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS, 
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
See the License for the specific language governing permissions and 
limitations under the License. 
*/
#endregion

using amdocs.ginger.GingerCoreNET;
using System;
// using GingerCoreNET.SolutionRepositoryLib.RepositoryObjectsLib.BusinessFlowLib;
using GingerCoreNET.SolutionRepositoryLib.RepositoryObjectsLib;
using System.Collections.Generic;
using Ginger.SolutionGeneral;

namespace Amdocs.Ginger.GingerConsole
{
    // GingerWebWorkspace Workspace Event Handler
    public class GingerWebWorkspace : IWorkSpaceEventHandler
    {
        public void AddApplication()
        {
            throw new NotImplementedException();
        }

        //public void AutomateBusinessFlow(BusinessFlow BF)
        //{
        //    throw new NotImplementedException();
        //}

        public void OpenAddAPIModelWizard()
        {
            throw new NotImplementedException();
        }

        public void OpenContainingFolder(string folderPath)
        {
            throw new NotImplementedException();
        }

        public void SetSolutionSourceControl(Solution solution, ref string repositoryRootFolder)
        {
            throw new NotImplementedException();
        }

        public void ShowBusinessFlows()
        {
            throw new NotImplementedException();
        }

        public void ShowDebugConsole(bool visible = true)
        {
            throw new NotImplementedException();
        }

        public void ShowUpgradeGinger(string solutionFolder, List<string> higherVersionFiles)
        {
            throw new NotImplementedException();
        }

        public void ShowUpgradeSolutionItems(SolutionUpgradePageViewMode upgradeSolution, string solutionFolder, string solutionName, List<string> list)
        {
            throw new NotImplementedException();
        }

        public void SolutionClosed()
        {
            throw new NotImplementedException();
        }
    }
}
