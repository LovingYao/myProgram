using System;
using TelerikWinformBase;

namespace RFIDProgram
{
    public partial class FrmSimpleBaseData : FrmBase
    {
        public FrmSimpleBaseData()
        {
            InitializeComponent();
        }

        private void FrmSimpleBaseData_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            ResetButtons(new[]
                             {
                                 CommandButton.Submit,
                                 CommandButton.Query,
                                 CommandButton.Close
                             });
        }
    }
}