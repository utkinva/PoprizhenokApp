using PoprizhenokApp.Models;
using System.Drawing;
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
            titleTypeLbl.Text = $"{agent.AgentType.Title} | {agent.Title}";
            salesPerYearLbl.Text = $"{agent.SalesPerLastYear} продаж за год";
            phoneLbl.Text = agent.Phone;
            priorityValueLbl.Text = $"{agent.Priority}";
            logoPictureBox.ImageLocation = agent.Logo;
            percentLbl.Text = $"{agent.Discount}%";
            agentIdLbl.Text = agent.ID.ToString();

            percentLbl.BackColor = agent.Discount >= 25 ? Color.LightGreen : Color.Transparent;
        }
    }
}
