using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GameObjects;
using Games;

namespace GUI {

    public partial class Crazy_Eights_Form : Form {

        public string Getchoosenstring { get; private set; }
        public Crazy_Eights_Form() {
            InitializeComponent();
            CrazyEights.StartGame();

            }



        private void btn_Deal_Click(object sender, EventArgs e) {

            DisplayHand(CrazyEights.UserHand, tbh_user);
            DisplayHand(CrazyEights.ComputerHand, tbh_computer);
            picBox_Left.Image = Images.GetBackOfCardImage();
            picBox_right.Image = Images.GetCardImage(CrazyEights.TopDiscard);
            CrazyEights.UserDrawCard();
            CrazyEights.ActionResult text = CrazyEights.UserDrawCard();
            UpdateInstructions(text.ToString(),true);
            DisplayHand(CrazyEights.UserHand, tbh_user);
            //Choose_a_suit form = new Choose_a_suit ();
            //form.ShowDialog();
            //lbl_click_to_deal.Text = form.Getchoosenstring;
            }

        /// <summary>
        /// Displays the User's Hand of cards
        /// </summary>
        /// <param name="hand">cards in the User's hand</param>
        /// <param name="panel">User's side of the board</param>
        private void DisplayHand(Hand hand, TableLayoutPanel panel) {
            // remove any previous card images
            panel.Controls.Clear();

            // repeat for each card in the hand
            for (int i = 0; i < hand.GetCount(); i++) {
                // add a picture box to the panel with the appropriate image
                PictureBox picCard = new PictureBox();
                picCard.SizeMode = PictureBoxSizeMode.AutoSize;
                picCard.Image = Images.GetCardImage(hand.GetCard(i));
                panel.Controls.Add(picCard, i, 0);

                // add an event handler if it is being added to the User’s panel
                if (panel == tbh_user) {
                    picCard.Click += new System.EventHandler(this.picPlayCard_Click);
                    }
                }
            }



        /// <summary>
        /// Tells us which card, at which position was selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void picPlayCard_Click(object sender, EventArgs e) {
            // get the picturebox that was clicked

            PictureBox picCard = (PictureBox)sender;

            // determine the position of the picturebox that was clicked
            int columnNum = ((TableLayoutPanel)((Control)sender).Parent).GetPositionFromControl(picCard).Column;


            //lbl_click_to_deal.Text == CrazyEights.ActionResult();
            if (CrazyEights.IsPlaying == true) {
                if (CrazyEights.IsUserTurn == true) {
                    CrazyEights.UserPlayCard(columnNum);
                    
                    DisplayHand(CrazyEights.UserHand, tbh_user);
                    picBox_Left.Image = Images.GetBackOfCardImage();
                    picBox_right.Image = Images.GetCardImage(CrazyEights.TopDiscard);
                    CrazyEights.ActionResult text = CrazyEights.UserPlayCard(columnNum);
                    UpdateInstructions(text.ToString(),true);
                    if (CrazyEights.ActionResult.SuitRequired == CrazyEights.UserPlayCard(columnNum)) {
                        Choose_a_suit form = new Choose_a_suit ();
                        form.ShowDialog();

                        }
                    } else if (CrazyEights.IsPlaying == false) {
                    CrazyEights.ComputerAction();
                    
                    DisplayHand(CrazyEights.ComputerHand, tbh_computer);
                    picBox_Left.Image = Images.GetBackOfCardImage();
                    picBox_right.Image = Images.GetCardImage(CrazyEights.TopDiscard);
                     CrazyEights.ActionResult comptext = CrazyEights.ComputerAction();
                    UpdateInstructions(comptext.ToString(),true);
                    }

                }

            // ...you will need to continue this yourself in part C...
            // MessageBox.Show(string.Format("Clicked column {0}", columnNum)); //temporary
            }

        private void UpdateInstructions(string message, bool wait = false) {
            lbl_click_to_deal.Text = message;
            lbl_click_to_deal.Refresh();
            if (wait) {
                System.Threading.Thread.Sleep(1000);
                }
            }

        private void btn_Sort_hand_Click(object sender, EventArgs e) {
            CrazyEights.SortUserHand();
            DisplayHand(CrazyEights.UserHand, tbh_user);
            }
        }

    }
