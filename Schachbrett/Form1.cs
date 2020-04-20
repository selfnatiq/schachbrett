using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schachbrett
{
    public partial class frmSchachbrett : Form
    {
        public frmSchachbrett()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // define variables
            int counterZeilen = Convert.ToInt32(nudAnzahlZeilen.Value);            
            int zeilenHeight = pnlSchachbrett.Height / counterZeilen;
            int spaltenWidth = pnlSchachbrett.Width / counterZeilen;

            //clear panel
            pnlSchachbrett.Controls.Clear();

            if (counterZeilen == 0 || counterZeilen % 2 != 0)
            {
                MessageBox.Show("Ungültiger Wert :)");
            }
            else
            {
                for (int zeile = 0; zeile++ < counterZeilen;)
                {
                    for (int spalte = 0; spalte++ < counterZeilen;)
                    {
                        bool schwarzBlock = (zeile * (counterZeilen - 1) + spalte) % 2 != 0;
                        int positionX = (spalte - 1) * spaltenWidth;
                        int positionY = (zeile - 1) * zeilenHeight;

                        var block = new Label();

                        block.BackColor = (schwarzBlock) ? Color.Black : Color.White;
                        block.Location = new Point(positionX, positionY);
                        block.Size = new Size(spaltenWidth, zeilenHeight);

                        //add blocks to panel
                        pnlSchachbrett.Controls.Add(block);
                    }
                }
            }
        }
    }
}
