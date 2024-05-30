﻿using Gtk;
using LogicPOS.Data.XPO.Settings;
using LogicPOS.Globalization;
using LogicPOS.Printing.Utility;
using System;

namespace logicpos.Classes.Gui.Gtk.Pos.Dialogs
{
    internal partial class PosSystemDialog
    {
        private void buttonSetup_Clicked(object sender, EventArgs e)
        {
            logicpos.Utils.ShowMessageUnderConstruction();
        }

        private void buttonCash_Clicked(object sender, EventArgs e)
        {
            if (TerminalSettings.LoggedTerminal.Printer != null)
            {
                var resultOpenDoor = PrintingUtils.OpenDoor();
                if (!resultOpenDoor)
                {
                    logicpos.Utils.ShowMessageTouch(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Close, CultureResources.GetResourceByLanguage(LogicPOS.Settings.CultureSettings.CurrentCultureName, "global_information"), string.Format(CultureResources.GetResourceByLanguage(LogicPOS.Settings.CultureSettings.CurrentCultureName, "open_cash_draw_permissions")));
                }
            }
        }

        private void buttonReports_Clicked(object sender, EventArgs e)
        {
            PosReportsDialog dialog = new PosReportsDialog(this, DialogFlags.DestroyWithParent);
            int response = dialog.Run();
            dialog.Destroy();
        }
    }
}
