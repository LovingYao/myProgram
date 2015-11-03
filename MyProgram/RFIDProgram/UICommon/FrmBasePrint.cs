using System;
using TelerikWinformBase;

namespace RFIDProgram
{
    public partial class FrmBasePrint : FrmBase
    {
        public FrmBasePrint()
        {
            InitializeComponent();
        }

        private void FrmBasePrint_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            ResetButtons(new[]
                             {
                                 CommandButton.Print,
                                 CommandButton.Close
                             });
        }
    }
}