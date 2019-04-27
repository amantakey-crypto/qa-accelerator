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

using Amdocs.Ginger.Common;
using Amdocs.Ginger.Common.InterfacesLib;
using Ginger;
using Ginger.BusinessFlowPages.ListViewItems;
using Ginger.UserControlsLib.UCListView;
using GingerCore;
using GingerCore.Actions;
using GingerWPF.DragDropLib;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace GingerWPF.BusinessFlowsLib
{
    /// <summary>
    /// Interaction logic for ActivityActionsPage.xaml
    /// </summary>
    public partial class ActionsListViewPage : Page
    {
        Activity mActivity;
        Context mContext;
        
        public ActionsListViewPage(Activity Activity, Context context)
        {
            InitializeComponent();

            mActivity = Activity;
            mContext = context;

            SetListView();
        }

        private void SetListView() 
        {
            xActionsListView.Title = "Actions";
            xActionsListView.ListImageType = Amdocs.Ginger.Common.Enums.eImageType.Action;

            xActionsListView.SetDefaultListDataTemplate(new ActionListItemInfo(mContext));

            xActionsListView.AddBtnVisiblity = Visibility.Collapsed;

            xActionsListView.DataSourceList = mActivity.Acts;

            xActionsListView.PreviewDragItem += grdActions_PreviewDragItem;
            xActionsListView.ItemDropped += grdActions_ItemDropped;
        }

        public void UpdateActivity(Activity activity)
        {
            if (mActivity != activity)
            {
                mActivity = activity;
                if (mActivity != null)
                {
                    xActionsListView.DataSourceList = mActivity.Acts;
                }
                else
                {
                    xActionsListView.DataSourceList = null;
                }
            }
        }

        // Drag Drop handlers
        private void grdActions_PreviewDragItem(object sender, EventArgs e)
        {
            if (DragDrop2.DragInfo.DataIsAssignableToType(typeof(Act)))
            {
                // OK to drop                         
                DragDrop2.DragInfo.DragIcon = GingerWPF.DragDropLib.DragInfo.eDragIcon.Copy;
            }
        }

        private void grdActions_ItemDropped(object sender, EventArgs e)
        {
            Act a = (Act)((DragInfo)sender).Data;
            Act instance = (Act)a.CreateInstance(true);
            mActivity.Acts.Add(instance);

            int selectedActIndex = -1;
            ObservableList<IAct> actsList = mContext.BusinessFlow.CurrentActivity.Acts;
            if (actsList.CurrentItem != null)
            {
                selectedActIndex = actsList.IndexOf((Act)actsList.CurrentItem);
            }
            if (selectedActIndex >= 0)
            {
                actsList.Move(actsList.Count - 1, selectedActIndex + 1);
            }
        }

    }
}
