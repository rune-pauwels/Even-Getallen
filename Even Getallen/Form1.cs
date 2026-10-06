using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Even_Getallen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*=======Analyse Stap 1======

*1. Invoer: Welke invoer mag ik verwachten voor de functie? Geef zowel een naam/beschrijving als een datatype.
        een geheel getal - int
*
*2a. Bewerking: Hoe bepaal je zelf of een getal even is?
*       of er een rest na deling door 2 is

*2b. Hoe kan je deze logica in programmacode omzetten? Omschrijf duidelijk welke functies/operatoren je hiervoor zo gebruiken.
        door het % teken te gebruiken
*

*3. Uitvoer: Welke uitvoer zal de functie geven? Geef zowel een naam/beschrijving als een datatype.
        niks - void
*
*==========Testdata=========

*4. Testdata: Verzin en noteer testgegevens voor alle mogelijke gevallen. Zo weet je of je oefening klopt.
        als het getal 2 is, is het even dus true
*       als het getal 3 is, is het oneven dus false

*=========================== */
        private void BerekenButton_Click(object sender, EventArgs e)
        {
            int Getal = Convert.ToInt32(InputTextBox.Text);
            bool IsEvenOfNiet = EvenOfNiet(Getal);
            if (IsEvenOfNiet == true)
            {
                MessageBox.Show("Dit getal is een even getal", "IsevenGetal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dit getal is geen even getal", "IsevenGetal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private bool EvenOfNiet(int Getal)
        {
            int RestNaDeling = Getal % 2;
            if (RestNaDeling == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
