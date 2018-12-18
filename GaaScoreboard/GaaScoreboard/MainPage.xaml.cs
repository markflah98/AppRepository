using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GaaScoreboard 
{
    public partial class MainPage : ContentPage
    {
        public MainPage()// constructor
        {
            
            InitializeComponent();
            addImagesToPages();
            
        }

        private void addImagesToPages()
        {
            var assembly = typeof(MainPage);
           
            string strFilename = "GaaScoreboard.Assets.Images.gaa-logo.jpg";

            imageCroke.Source = ImageSource.FromResource(strFilename, assembly);
        }

        private void btnChangeLabel_Clicked(object sender, EventArgs e)
        {

           
            btnChangeLabel.Text = "Click to change Team names";
            homeVsAway.Text = "Teams " +
                                  entryHomeTeam.Text + " & " + entryAwayTeam.Text +" Saved";

            

            team1.Text = entryHomeTeam.Text;

            team2.Text = entryAwayTeam.Text;

            entryHomeTeam.Text = "";
            entryAwayTeam.Text = "";
        }

        int scoreTeam1;
        int goalTeam1;
        int pointTeam1;
        int scoreTeam2;
        int goalTeam2;
        int pointTeam2;
        int scoredifference;
        private object theVenue;

        private void goalteam1_Clicked(object sender, EventArgs e)
        {
            scoreTeam1 = scoreTeam1 + 3;
            goalTeam1 = goalTeam1 + 1;
            team1score.Text = goalTeam1 + "-" + pointTeam1 + "(" + scoreTeam1 + ")";


        }

        private void pointteam1_Clicked(object sender, EventArgs e)
        {
            scoreTeam1 = scoreTeam1 + 1;
            pointTeam1 = pointTeam1 + 1;
            team1score.Text = goalTeam1 + "-" + pointTeam1 + "(" + scoreTeam1 + ")";
        }

        private void goalteam2_Clicked(object sender, EventArgs e)
        {
            scoreTeam2 = scoreTeam2 + 3;
            goalTeam2 = goalTeam2 + 1;
            team2score.Text = goalTeam2 + "-" + pointTeam2 + "("+ scoreTeam2 +")";
        }

        private void pointteam2_Clicked(object sender, EventArgs e)
        {
            scoreTeam2 = scoreTeam2 + 1;
            pointTeam2 = pointTeam2 + 1;
            team2score.Text = goalTeam2 + "-" + pointTeam2 + "(" + scoreTeam2 + ")";
        }

        private void endgame_Clicked(object sender, EventArgs e)
        {
            if (scoreTeam1 > scoreTeam2)
            {
                scoredifference = (scoreTeam1)-(scoreTeam2);
                endgame.Text = team1.Text + "wins by " + scoredifference + "points";
            }

            else if (scoreTeam1 < scoreTeam2)
            {
                scoredifference = (scoreTeam2) - (scoreTeam1);
                endgame.Text = team2.Text + " wins by " + scoredifference + "points";
            }

            else
            {
                endgame.Text = "Draw";
            }
        }

        private void YellowTeam1_Clicked(object sender, EventArgs e)
        {

        }




        // add methods here.


    }
}
