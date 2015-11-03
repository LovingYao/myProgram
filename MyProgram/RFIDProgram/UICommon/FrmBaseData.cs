using System;
using TelerikWinformBase;


namespace RFIDProgram
{
    public partial class FrmBaseData : RFIDProgram.FrmBase
    {
        public FrmBaseData()
        {
            InitializeComponent();
        }

        private void FrmBaseData_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            ResetButtons(new[]
                             {
                                 CommandButton.Add,
                                 CommandButton.Edit,
                                 CommandButton.Save,
                                 CommandButton.Cancel,
                                 CommandButton.Delete,
                                 CommandButton.Query,
                                 CommandButton.Export,
                                 CommandButton.Close
                             });
        }
    }
}