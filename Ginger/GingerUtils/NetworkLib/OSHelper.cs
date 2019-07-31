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

using GingerUtils.OSLib;
using System.Runtime.InteropServices;

namespace GingerUtils
{
    

    public static class OSHelper
    {
        static IOperationgSystem mOperationgSystem;
        public static IOperationgSystem Current
        {
            get
            {
                if (mOperationgSystem == null)
                {
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        mOperationgSystem = new WindowsOS();
                    }
                    else if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    {
                        mOperationgSystem = new LinuxOS();
                    }
                    else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                    {
                        mOperationgSystem = new LinuxOS(); // Mac is like Linux if we will need we can split Linux & Mac separate sub class
                    }
                }

                return mOperationgSystem;
            }
        }

      
    }

}
