using System;

namespace RFIDProgram
{
    public partial class FrmBaseEquipment : FrmBase
    {
        public FrmBaseEquipment()
        {
            InitializeComponent();
        }

        private void FrmBaseEquipment_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

        }
    }
}