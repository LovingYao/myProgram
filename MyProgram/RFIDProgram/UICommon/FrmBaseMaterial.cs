using System;
using TelerikWinformBase;

namespace RFIDProgram
{
    public partial class FrmBaseMaterial : FrmBase
    {
        public FrmBaseMaterial()
        {
            InitializeComponent();
        }

        private void FrmBaseMaterial_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            ResetButtons(new[]
                             {
                                 CommandButton.Submit,
                                 CommandButton.RefreshData,
                                 CommandButton.Close
                             });
        }
    }
}