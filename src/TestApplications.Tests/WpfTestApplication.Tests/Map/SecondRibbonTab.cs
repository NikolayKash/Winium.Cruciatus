﻿namespace WpfTestApplication.Tests.Map
{
    #region using

    using Cruciatus.Core;
    using Cruciatus.Elements;
    using Cruciatus.Extensions;

    #endregion

    public class SecondRibbonTab : TabItem
    {
        public SecondRibbonTab(CruciatusElement parent, By getStrategy)
            : base(parent, getStrategy)
        {
        }

        public CheckBox RibbonCheckBox
        {
            get
            {
                return GetByUid("RibbonCheckBox").ToCheckBox();
            }
        }

        public CheckBox RibbonToggleButton
        {
            get
            {
                return GetByUid("RibbonToggleButton").ToCheckBox();
            }
        }
    }
}
