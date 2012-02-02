using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlackJackApp
{
    public partial class Board2 : System.Web.UI.Page
    {
        int players;
        BoardDesign bd;

        protected void Page_Load(object sender, EventArgs e)
        {
          
                players = string.IsNullOrEmpty(Session["SelectedPlayers"].ToString()) ? -1 : int.Parse(Session["SelectedPlayers"].ToString());
                bd = new BoardDesign(Table1);

                TableCell dealer = bd.addDealer();

                for (int i = 0; i < players; i++)
                {
                    bd.addPlayer("Player : " + i.ToString());                   
                }               
                
        }
       
    }

    public class BoardDesign
    {
        private TableRow dealerRow;
        private TableRow playersRow;
        
        public BoardDesign(Table table)
        {
            dealerRow = new TableRow();
            playersRow = new TableRow();            
            table.BorderColor = System.Drawing.Color.Black;
            table.BorderWidth = 1;
            table.BorderStyle = BorderStyle.Solid;
            table.Rows.Add(dealerRow);
            table.Rows.Add(new TableRow());
            table.Rows.Add(playersRow);
    
        }

        public TableCell addDealer()
        {
            TextBox t = new TextBox();
            t.Text = "Dealer";
            TableCell dealerCell = new TableCell();
            dealerCell.ColumnSpan = 4;
            dealerCell.Controls.Add(t);
            dealerRow.Cells.Add(dealerCell);
            return dealerCell;
        }
        public TableCell addPlayer(string name)
        {
            Player playerCell = new Player(name);
            playersRow.Cells.Add(playerCell);
            return playerCell;
        }
    }
    public class Player : TableCell
    {
        string Name { set; get; }
        int Points { set; get; }
        TextBox t = new TextBox();
        Button buttonHit = new Button();
        Button buttonStand = new Button();
        
        
        public Player(string name)
        {
            buttonHit.Click += new EventHandler(buttonHit_Click);
            buttonStand.Click +=new EventHandler(buttonStand_Click);
            Name = name;
            t.Text = Name;
            buttonHit.Text = "Hit";
            buttonStand.Text = "Stand";
            Controls.Add(buttonHit);
            Controls.Add(buttonStand);
            Controls.Add(t);
        }
        public void buttonHit_Click(Object ob, EventArgs e)
        {
            buttonHit.Enabled = false;
        }
        public void buttonStand_Click(Object ob, EventArgs e)
        {
            buttonStand.Enabled = false;
        }
        public bool addPoints(int val)
        {
            Points += val;
            return (Points > 21) ? true:  false;
        }
    }
}   