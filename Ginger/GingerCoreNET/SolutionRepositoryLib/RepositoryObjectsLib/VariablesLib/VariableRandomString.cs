//#region License
///*
//Copyright © 2014-2018 European Support Limited

//Licensed under the Apache License, Version 2.0 (the "License")
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at 

//http://www.apache.org/licenses/LICENSE-2.0 

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS, 
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
//See the License for the specific language governing permissions and 
//limitations under the License. 
//*/
//#endregion

//using Amdocs.Ginger.Common.Repository;
//using Amdocs.Ginger.Repository;
//using GingerCoreNET.Dictionaries;
//using System;
//using System.Linq;
//using System.Text;

//namespace GingerCoreNET.SolutionRepositoryLib.RepositoryObjectsLib.VariablesLib
//{
//    public class VariableRandomString : VariableBase
//    {        
//        public new static  partial class Fields
//        {
//            public static string Min = "Min";
//            public static string Max = "Max";
//            public static string IsDigit = "IsDigit";
//            public static string IsLowerCase = "IsLowerCase";
//            public static string IsUpperCase = "IsUpperCase";
//        }

//        public VariableRandomString()
//        {
//        }

//        public override string VariableUIType
//        {
//            get { return GingerDicser.GetTermResValue(eTermResKey.Variable) + " Random String"; }
//        }

//        public override string VariableEditPage { get { return "VariableRandomStringPage"; } }
        
//        private int mMin;
//        [IsSerializedForLocalRepository]
//        public int Min { set { mMin = value; OnPropertyChanged("Formula"); } get { return mMin; } }

//        private int mMax;
//        [IsSerializedForLocalRepository]
//        public int Max { set { mMax = value; OnPropertyChanged("Formula"); } get { return mMax; } }

//        private bool mIsDigit;
//        [IsSerializedForLocalRepository]
//        public bool IsDigit { set { mIsDigit = value; OnPropertyChanged("Formula"); } get { return mIsDigit; } }

//        // TODO: convert to enum: Any, LowerCase only, Upper Case only, to avoid the switch of other attr

//        private bool mIsLowerCase;
//        [IsSerializedForLocalRepository]
//        public bool IsLowerCase { set { mIsLowerCase = value; if (value) mIsUpperCase = false; OnPropertyChanged("Formula"); } get { return mIsLowerCase; } }

//        private bool mIsUpperCase;
//        [IsSerializedForLocalRepository]
//        public bool IsUpperCase { set { mIsUpperCase = value; if (value) mIsLowerCase = false; OnPropertyChanged("Formula"); } get { return mIsUpperCase; } }

//        private static Random random = new Random((int)DateTime.Now.Ticks);
//        private string RandomString(int size)
//        {
//            StringBuilder builder = new StringBuilder();
//            char ch;
//            int v;
//            for (int i = 0; i < size; i++)
//            {
//                if(IsDigit)
//                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(10 * random.NextDouble() + 48)));
//                else if (IsUpperCase)
//                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
//                else if (IsLowerCase)
//                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 97)));
//                else
//                {
//                    v=(int)Math.Floor(74* random.NextDouble() + 48);

//                    while (!(Enumerable.Range(48, 10).Contains(v) || Enumerable.Range(97, 26).Contains(v) || Enumerable.Range(65, 26).Contains(v)))
//                        v = (int)Math.Floor(74 * random.NextDouble() + 48);
//                    ch = Convert.ToChar(v);

//                }
//                builder.Append(ch);
//            }
//            return builder.ToString();
//        }
       
//        public override string GetFormula()
//        {
//            if (Min > Max)
//            {                
//                return "Error: Min > Max";
//            }

//            return "Random string length between " + Min + "-" + Max + " Digits only: " + IsDigit + "; All Lowercase: " + IsLowerCase + "; All UpperCase: " + IsUpperCase;
//        }

//        public override void ResetValue()
//        {
//            ////TODO: fixme should be = or give user error - do not change
                      
//            ////TODO: get the range

//            GenerateAutoValue();
//        }

//        public override void GenerateAutoValue()
//        {
//            if (Min > Max)
//            {
//                Value = "Error: Min > Max";
//                return;
//            }
//            int c = 0;
//            System.Threading.Thread.Sleep(1);
//            c = (int)((random.NextDouble() * (double)(Max - Min + 1)) + Min);
//            Value = RandomString(c);
//        }
        
//        public override string VariableType() { return "RandomString"; }

//        public override bool SupportSetValue { get { return false; } }
//    }
//}