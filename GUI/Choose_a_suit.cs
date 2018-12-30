using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {

    /// <summary>
    /// This is 
    /// </summary>
    public partial class Choose_a_suit : Form {
        public string Getchoosenstring { get; internal set; }
        public Choose_a_suit() {
            InitializeComponent();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_CheckedChanged(object sender, EventArgs e) {
             if (rdo_Clubs.Checked) {
                Getchoosenstring = " You have choosen Clubs";
                }
                else if (rdo_Diamond.Checked == true) {
                Getchoosenstring = " You have choosen Diamonds";
                }
                else if (rdo_Hearts.Checked == true) {
                Getchoosenstring = " You have choosen Hearts";
                }
                else {
                Getchoosenstring = " You have choosen Spades";
                }
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Play_card_Click(object sender, EventArgs e) {
            this.Close();
            }

    }//End of Choose_a_suit : Form class

} // End of GUI namespace
    
