using System.Collections;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace PenduRD
{
    public partial class frmPendu : Form
    {
        public frmPendu()
        {
            InitializeComponent();
        }
        public int erreur = 0;
        public string mot;
        public string motprecedent;
        public string motafficher = "";
        public string premierelettre = "";
        public string dernierelettre = "";
        public string GenerationMot()
        {
            string line = "";
            string path = "dico.txt";
            Random rdm = new Random();
            int nombrealea = rdm.Next(0, File.ReadLines(path).Count());
            StreamReader unSR = new StreamReader(path);
            for (int i = 0; i<nombrealea; i++)
            {
                line = unSR.ReadLine();
            }
            return line;
        }

        private void affiche_bouton()
        {
            flpalphabet.Controls.Clear();
            for (int i = 97; i < 123; i++)
            {
                string lettre = Convert.ToChar(i).ToString();
                Button unBouton = new Button();
                unBouton.Size = new Size(50, 50);
                unBouton.Text = lettre;
                unBouton.Click += (_sender, _e) => { leBouton_Click(_sender, _e); };
                if (lettre == premierelettre || lettre == dernierelettre)
                {
                    unBouton.Enabled = false;
                }
                flpalphabet.Controls.Add(unBouton);
            }
        }

        public void afficher_mot()
        {
            mot = GenerationMot();
            if (mot == motprecedent)
            {
                mot = GenerationMot();
            }
            for (int i = 0; i < mot.Length; i++)
            {
                if (mot[i] == mot[0] || mot[i] == mot[mot.Length - 1])
                {
                    motafficher += mot[i];
                }
                else
                {
                    motafficher += "_";
                }
            }
            premierelettre = mot[0].ToString();
            dernierelettre = mot[mot.Length - 1].ToString();
            affiche_bouton();
            affichage_mot(motafficher);
        }
        private void frmPendu_Load(object sender, EventArgs e)
        {
            afficher_mot();
        }

        private void affichage_mot(string lemot)
        {
            string lemotafficher = "";
            for (int i = 0; i < lemot.Length; i++)
            {
                if (i < lemot.Length - 1)
                {
                    lemotafficher += lemot[i] + " ";
                }
                else
                {
                    lemotafficher += lemot[i];
                }
            }
            lblMot.Text = lemotafficher;
        }

        private void leBouton_Click(object _sender, EventArgs _e)
        {
            Button leBouton = (Button)_sender;
            leBouton.Enabled = false;
            string btnLettre = leBouton.Text;
            char[] lemotafficherArray = motafficher.ToCharArray();
            if (mot.Contains(btnLettre))
            {
                for (int i = 0; i < mot.Length; i++)
                {
                    if (mot[i].ToString() == btnLettre)
                    {
                        lemotafficherArray[i] = Convert.ToChar(btnLettre);

                    }
                }
                motafficher = new string(lemotafficherArray);
                affichage_mot(motafficher);
                if (motafficher.Trim() == mot)
                {
                    MessageBox.Show("Bien joué :) !");
                    motprecedent = mot;
                    motafficher = "";
                    afficher_mot();
                    picPendu.Image = null;
                    erreur = 0;
                }
            }
            else
            {
                if (erreur < 7)
                {
                    erreur++;
                    lblnberreur.Visible = true;
                    picPendu.Image = new Bitmap(erreur.ToString() + ".png");
                }
                else
                {
                    picPendu.Image = new Bitmap("8.png");
                    MessageBox.Show($"Tu as perdu ! \nLe mot était : {mot}");
                    motprecedent = mot;
                    motafficher = "";
                    afficher_mot();
                    picPendu.Image = null;
                    erreur = 0;
                }

            }
        }
    }
}
