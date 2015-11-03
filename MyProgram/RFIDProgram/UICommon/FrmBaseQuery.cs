using System;
using TelerikWinformBase;

namespace RFIDProgram
{
    public partial class FrmBaseQuery : FrmBase
    {
        public FrmBaseQuery()
        {
            InitializeComponent();
        }

        private void FrmBaseQuery_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            ResetButtons(new[]
                             {
                                 CommandButton.Query,
                                 CommandButton.Export,
                                 CommandButton.Close
                             });
        }
    }
}