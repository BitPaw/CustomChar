using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CustomChar
{
    public partial class Main : Form
    {
        private bool[] bitArray;
        private List<PictureBox> pbList;
        private BitArrayBuilder bitArrayBuilder;
        private Color _enabledColor = Color.White;
        private Color _disabledColor = Color.DarkBlue;

        public Main()
        {
            InitializeComponent();

            // Inizialising Objects
            {
                pbList = new List<PictureBox>();
                bitArrayBuilder = new BitArrayBuilder();
                bitArray = new bool[40];
            }                    

            // Adding values
            {
                pbList.Add(pbAA);
                pbList.Add(pbBA);
                pbList.Add(pbCA);
                pbList.Add(pbDA);
                pbList.Add(pbEA);

                pbList.Add(pbAB);
                pbList.Add(pbBB);
                pbList.Add(pbCB);
                pbList.Add(pbDB);
                pbList.Add(pbEB);

                pbList.Add(pbAC);
                pbList.Add(pbBC);
                pbList.Add(pbCC);
                pbList.Add(pbDC);
                pbList.Add(pbEC);

                pbList.Add(pbAD);
                pbList.Add(pbBD);
                pbList.Add(pbCD);
                pbList.Add(pbDD);
                pbList.Add(pbED);

                pbList.Add(pbAE);
                pbList.Add(pbBE);
                pbList.Add(pbCE);
                pbList.Add(pbDE);
                pbList.Add(pbEE);

                pbList.Add(pbAF);
                pbList.Add(pbBF);
                pbList.Add(pbCF);
                pbList.Add(pbDF);
                pbList.Add(pbEF);

                pbList.Add(pbAG);
                pbList.Add(pbBG);
                pbList.Add(pbCG);
                pbList.Add(pbDG);
                pbList.Add(pbEG);

                pbList.Add(pbAH);
                pbList.Add(pbBH);
                pbList.Add(pbCH);
                pbList.Add(pbDH);
                pbList.Add(pbEH);
            }

            foreach (PictureBox pictureBox in pbList)
            {
                pictureBox.BackColor = _disabledColor;
            }
        }

        private void BuildText()
        {
            int counter = 0;

            foreach (PictureBox pictureBox in pbList)
            {
                bitArray[counter] =  CheckField(pictureBox);
                counter++;
            }
      
            rtbText.Text = bitArrayBuilder.Build(txtName.Text, bitArray);
        }

        private bool CheckField(PictureBox pictureBox)
        {
            return pictureBox.BackColor == _enabledColor ? true : false;
        }

        private void ToggleColor(PictureBox pictureBox)
        {
            pictureBox.BackColor = CheckField(pictureBox) ? _disabledColor : _enabledColor;
            BuildText();
        }

        #region Events
        private void Main_Load(object sender, EventArgs e)
        {
            BuildText();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            BuildText();
        }

        private void PbAA_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void PbBA_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbCA_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbDA_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbEA_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbAB_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbBB_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbCB_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbDB_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbEB_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbAC_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbBC_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbCC_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbDC_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbEC_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbAD_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbBD_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbCD_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbDD_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbED_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbAE_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbBE_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbCE_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbDH_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbEE_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbAF_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbBF_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbCF_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbDI_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbEF_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbAG_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbBG_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbCG_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbDJ_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbEG_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbAH_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbBH_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbCH_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbDK_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }

        private void pbEH_Click(object sender, EventArgs e)
        {
            ToggleColor((PictureBox)sender);
        }     
        #endregion
    }
}
