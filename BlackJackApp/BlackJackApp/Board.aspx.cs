using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace BlackJackApp
{
    public partial class Board : System.Web.UI.Page
    {

        //CardDealer theBadGuy;
        //CardPlayer[] cardPlayers;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //System.Collections.ArrayList deck;
                //string s = Server.MapPath("~/Images/75/");
                //string[] paths = System.IO.Directory.GetFiles(s);
                //string temp = null;
                //deck = new System.Collections.ArrayList();
                //foreach (string r in paths)
                //{
                //    temp = System.IO.Path.GetFileName(r);
                //    if (!temp.StartsWith("back"))
                //    {
                //        deck.Add(temp);
                //    }
                //}
                //int players = string.IsNullOrEmpty(Session["SelectedPlayers"].ToString()) ? -1 : int.Parse(Session["SelectedPlayers"].ToString());

                //for (int r = 0; r<players;r++)
                //{
                //    cardPlayers[r] = BuildPlayer("Player :"+(r+1)); //Player table setup
                //}
                //theBadGuy = BuildDealer(deck); // Give imported image adresses as a deck to dealer and setup tables
                //startGame();
            }

        }
        //public CardDealer BuildDealer(ArrayList deck)
        //{
        //    TableCell cellCards = new TableCell(), cellStats = new TableCell();
        //    Table table = new Table();
        //    TableRow row = new TableRow();         
        //    table.HorizontalAlign = HorizontalAlign.Center;
        //    row.Cells.AddAt(0, cellCards);
        //    row.Cells.AddAt(1, cellStats);
        //    table.Rows.Add(row);            
        //    dealersBoard.Controls.Add(table);
        //    return new CardDealer(cellCards, cellStats, deck);

        //}

        //    public CardPlayer BuildPlayer(string name)
        //    {
        //        TableCell cellCards = new TableCell(), cellStats = new TableCell();
        //        Table table = new Table();
        //        TableRow row = new TableRow();

        //        table.Rows.Add(row);
        //        row.Controls.Add(cellCards);
        //        row.Controls.Add(cellStats);
        //        playersBoard.Controls.Add(table);
        //        return new CardPlayer(cellCards,cellStats,name);

        //    }

        //    public class CardPlayer
        //    {
        //        private TableCell cellCards { set; get; }
        //        private TableCell cellStats{set;get;}
        //        private string name;

        //        public CardPlayer(TableCell cellCards, TableCell cellStats, string playerName)
        //        {
        //            this.cellCards = cellCards;
        //            this.cellStats = cellStats;
        //            name = playerName;
        //        }
        //        public void recieveCard(string imagepath)
        //        {
        //            Image img = new Image();
        //            img.ImageUrl = imagepath;
        //            cellCards.Controls.Add(img);
        //        }

        //    }

        //    public class CardDealer
        //    {
        //       private  TableCell cellCards, cellStats;
        //       private  ArrayList deck;
        //       private Random randomGen;
        //        public CardDealer(TableCell cellCards, TableCell cellStats, ArrayList deck)
        //        {
        //            this.cellCards = cellCards;
        //            this.cellStats = cellStats;
        //            this.deck = deck;
        //        }
        //        public string drawCard()
        //        {
        //            if (deck.Count > 0)
        //            {
        //                int pick = randomGen.Next(deck.Count - 1);
        //                string ret = deck[pick].ToString();
        //                deck.RemoveAt(pick);
        //                return ret;
        //            }
        //            else return "empty";
        //         }

        //    }

        //}
    }
}