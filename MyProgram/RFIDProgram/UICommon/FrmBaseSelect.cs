using System;
using TelerikWinformBase;


namespace RFIDProgram
{
    public partial class FrmBaseSelect : FrmBase
    {
        public FrmBaseSelect()
        {
            InitializeComponent();
        }

        private void FrmBaseWIP_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            ResetButtons(new[]
                             {
                                 CommandButton.Query,
                                 CommandButton.Submit,
                                 CommandButton.Close
                             });
        }
    }
}