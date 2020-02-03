//N5284
//Program 1
//February 12, 2019
//CIS 199-75
//A GUI program that calculates the cost for carpet 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1
{
    public partial class CarpetEstimatorForm : Form
    {
        public CarpetEstimatorForm()
        {
            InitializeComponent();
        }
        
        //When the "Calculate" button is pressed the outputs are defined by the following calculations
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Variable Dictionary
            const double SQUARE_YARDS_CONVERSION = 9.0; //Defines the constant conversion rate from square feet to square yards
            const double PADDING_CHARGE = 2.75;         //Defines the constant charge for padding
            const double WASTE_PERCENTAGE = 0.10;       //Defines the constant percentage of left over material
            const double LABOR_CHARGE = 4.5;            //Defined the constant labor charge
            const double FIRST_ROOM_FEE = 100.00;       //Defines the constant fee accociated with the first room

            double maxWidth;                            //User defined maximum width of the room
            double maxLength;                           //User defined maximum length of the room
            double pricePerSquareYd;                    //User defined price per square yard of carpet
            double squareYards;                         //Calculated area of the room
            double paddingCost;                         //Calculated cost of padding material
            double carpetCost;                          //Calculated cost of carpet material
            double laborCost;                           //Calculated cost of labor
            double totalCost;                           //Calculated total cost
            double wasteMaterial;                       //Calculated ammount of left-over material

            int paddingLayers;                          //User defined layers of padding material
            int firstRoom;                              //User defines if the room is the first or not

            //Assign data to variables
            maxWidth = double.Parse(maxWidthTxt.Text);
            maxLength = double.Parse(maxLengthTxt.Text);
            pricePerSquareYd = double.Parse(carpetPriceTxt.Text);

            paddingLayers = Int16.Parse(paddingLayersTxt.Text);
            firstRoom = Int16.Parse(firstRoomTxt.Text);

            //Calculation
            squareYards = (maxWidth * maxLength) / SQUARE_YARDS_CONVERSION;
            wasteMaterial = squareYards * WASTE_PERCENTAGE;
            carpetCost = (squareYards + wasteMaterial)* pricePerSquareYd;
            paddingCost = ((squareYards + wasteMaterial) * PADDING_CHARGE) * paddingLayers;
            laborCost = (squareYards * LABOR_CHARGE) + (firstRoom * FIRST_ROOM_FEE);
            totalCost = carpetCost + paddingCost + laborCost;

            //Output
            outSquareYardsLbl.Text = $"{squareYards:F1}  ";
            outCarpetCostLbl.Text = $"{carpetCost:C}";
            outPaddingCostLbl.Text = $"{paddingCost:C}";
            outLaborCostLbl.Text = $"{laborCost:C}";
            outTotalCostLbl.Text = $"{totalCost:C}";
        }

        //When the "Clear Form" button is pressed the following happens
        private void clearFormButton_Click(object sender, EventArgs e)
        {
            maxWidthTxt.Clear();
            maxLengthTxt.Clear();
            carpetPriceTxt.Clear();
            paddingLayersTxt.Clear();
            firstRoomTxt.Clear();
        }
    }
}
