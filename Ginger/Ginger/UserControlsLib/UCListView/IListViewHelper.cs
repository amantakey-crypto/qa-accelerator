﻿using System.Collections.Generic;

namespace Ginger.UserControlsLib.UCListView
{
    public interface IListViewHelper
    {        
        UcListView ListView { get; set; }

        General.eRIPageViewMode PageViewMode { get; set; }

        void SetItem(object item);

        string GetItemNameField();

        string GetItemDescriptionField();

        string GetItemNameExtentionField();

        string GetItemTagsField();

        string GetItemIconField();

        string GetItemIconTooltipField();

        string GetItemExecutionStatusField();

        string GetItemActiveField();

        List<ListItemOperation> GetListOperations();

        List<ListItemOperation> GetListExtraOperations();

        List<ListItemNotification> GetItemGroupNotificationsList(string GroupName);

        List<ListItemGroupOperation> GetItemGroupOperationsList();

        ListItemUniqueIdentifier GetItemUniqueIdentifier(object item);

        List<ListItemNotification> GetItemNotificationsList(object item);

        List<ListItemOperation> GetItemOperationsList(object item);

        List<ListItemOperation> GetItemExtraOperationsList(object item);

        List<ListItemOperation> GetItemExecutionOperationsList(object item);        
    }
}