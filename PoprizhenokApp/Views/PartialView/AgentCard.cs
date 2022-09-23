using PoprizhenokApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoprizhenokApp.Views.PartialView
{
    public partial class AgentCard : UserControl
    {
        public AgentCard()
        {
            InitializeComponent();
        }

        public void GenerateAgentData(Agent agent)
        {
            int salesQtyLastYear = 0;

            foreach (var sale in agent.ProductSale)
            {
                if (sale.SaleDate.Year == 2019)
                {
                    salesQtyLastYear += sale.ProductCount;
                }
            }

            titleTypeLbl.Text = $"{agent.AgentType.Title} | {agent.Title}";
            salesPerYearLbl.Text = $"{salesQtyLastYear} продаж за год";
            phoneLbl.Text = agent.Phone;
            priorityValueLbl.Text = $"{agent.Priority}";
            logoPictureBox.ImageLocation = agent.Logo;
            percentLbl.Text = $"{agent.Discount}%";

            agentIdLbl.Text = agent.ID.ToString();

            if (agent.Discount >= 25)
                percentLbl.BackColor = Color.LightGreen;

        }
    }
}
