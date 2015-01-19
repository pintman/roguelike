using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace Roguelike
{
    public partial class Form1 : Form
    {
        int breite;
        int hoehe;
        char[,] aSpielfeld;

        int iSpielerX;
        int iSpielerY;

        // Damit die Bilder geladen werden können:
        // 1. Bild in Ordner Bilder
        // 2. Projektmappe hinzufügen über "Vorhandenes Element"
        // 3. Eigenschaften des Bilder: "Kopieren wenn neuer"
        Image imHeld;
        Image imBoden;
        Image imWand;

        public Form1()
        {
            InitializeComponent();

            breite = 15;
            hoehe = 15;
            iSpielerX = 5;
            iSpielerY = 5;

            rtbSpielfeld.Font = new Font("Courier New", 12);
            rtbSpielfeld.BackColor = Color.Black;
            rtbSpielfeld.ForeColor = Color.Green;

            imHeld = Image.FromFile("Bilder/Held.png");
            imBoden = Image.FromFile("Bilder/Boden.png");
            imWand = Image.FromFile("Bilder/Wand.png");

            SpielfeldInitialisieren();
            SpielfeldZeichnen();
        }

        private void SpielfeldInitialisieren()
        {
            aSpielfeld = new char[breite, hoehe];

            for (int i = 0; i < breite; i++)
			{
                for (int j = 0; j < hoehe; j++)
                {
                    aSpielfeld[i,j] = '.';
                }
			}

            aSpielfeld[iSpielerX, iSpielerY] = '@';

            aSpielfeld[iSpielerX + 2, iSpielerY] = '#';
        }
        private void SpielfeldZeichnen1()
        {
            // Variante 1: Nutzt AppendText. Das flackert jedoch. Daher wechsel zu

            rtbSpielfeld.Clear();
            for (int j = 0; j < hoehe; j++)
            {
                for (int i = 0; i < breite; i++)
                {
                    char c = aSpielfeld[i, j];
                    rtbSpielfeld.AppendText(c.ToString());
                }
                rtbSpielfeld.AppendText("\n");                
            }
        }
        private void SpielfeldZeichnen()
        {
            SpielfeldInTextboxZeichnen();
            SpielfeldInPictureboxZeichnen();
        }
        private void SpielfeldInTextboxZeichnen()
        {
            // Variante 2: Erst in einen String schreiben, 
            // diesen dann komplett setzen (Double Buffering)

            string sSpielfeld = "\n";
            rtbSpielfeld.Clear();
            for (int j = 0; j < hoehe; j++)
            {
                for (int i = 0; i < breite; i++)
                {
                    char c = aSpielfeld[i, j];
                    sSpielfeld += c.ToString();
                }
                sSpielfeld += "\n";
            }
            rtbSpielfeld.Text = sSpielfeld;
        }
        private void SpielfeldInPictureboxZeichnen()
        {
            // Das Feld soll neu gezeichnet werden - über das Paint-Event.
            pbSpielfeld.Invalidate();
        }

        private void pbSpielfeld_Paint(object sender, PaintEventArgs e)
        {
            for (int j = 0; j < hoehe; j++)
            {
                for (int i = 0; i < breite; i++)
                {
                    char c = aSpielfeld[i, j];
                    Image im = BildBestimmen(c);
                    e.Graphics.DrawImage(im, i*im.Width, j * im.Height);
                }
            }
        }

        private Image BildBestimmen(char cZeichen)
        {
            if (cZeichen == '@')
            {
                return imHeld;
            }
            if (cZeichen == '.')
            {
                return imBoden;
            }
            if (cZeichen == '#')
            {
                return imWand;
            }
            return null;
        }

        private void rtbSpielfeld_KeyPress1(object sender, KeyPressEventArgs e)
        {
            // Variante 1: Ohne Prüfung auf Kollision
            aSpielfeld[iSpielerX, iSpielerY] = '.';

            if(e.KeyChar == 'a')
            {
                iSpielerX--;
            }
            if(e.KeyChar == 'd')
            {
                iSpielerX++;
            }
            if (e.KeyChar == 'w')
            {
                iSpielerY--;
            }
            if (e.KeyChar == 's')
            {
                iSpielerY++;
            }

            aSpielfeld[iSpielerX, iSpielerY] = '@';

            SpielfeldZeichnen();
        }
        private void rtbSpielfeld_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Variante 2: Kollisionsprüfung. Nur laufen, wenn Zielfeld leer ist.

            aSpielfeld[iSpielerX, iSpielerY] = '.';

            if (e.KeyChar == 'a' && feldFrei(iSpielerX-1, iSpielerY))
            {
                iSpielerX--;
            }
            if (e.KeyChar == 'd' && feldFrei(iSpielerX + 1, iSpielerY))
            {
                iSpielerX++;
            }
            if (e.KeyChar == 'w' && feldFrei(iSpielerX,iSpielerY-1))
            {
                iSpielerY--;
            }
            if (e.KeyChar == 's' && feldFrei(iSpielerX,iSpielerY+1))
            {
                iSpielerY++;
            }

            aSpielfeld[iSpielerX, iSpielerY] = '@';

            SpielfeldZeichnen();
        }
        /// <summary>
        /// Prüft, ob das Feld frei ist und der Spieler darauf ziehen kann.
        /// </summary>
        private bool feldFrei(int x, int y)
        {
            if(aSpielfeld[x,y] == '.')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void spielfeldLadenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSpielfeldLaden = new OpenFileDialog();
            DialogResult result = ofdSpielfeldLaden.ShowDialog();

            int iZeile = 0;
            if(result == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(ofdSpielfeldLaden.FileName);
                while (!reader.EndOfStream)
                {
                    string sZeile = reader.ReadLine();
                    if (sZeile.Length != breite)
                    {
                        MessageBox.Show("Zeile hat falsche Länge " + sZeile);
                    }

                    for (int i = 0; i < sZeile.Length; i++)
                    {
                        char c = sZeile[i];
                        aSpielfeld[iZeile, i] = c;
                        if(c == '@')
                        {
                            iSpielerX = i;
                            iSpielerY = iZeile;
                        }
                    }

                    iZeile++;
                }
                SpielfeldZeichnen();
            }
        }
    }
}
