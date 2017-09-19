using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cherwell_Puzzle.BusinessLogic;
using System.Collections;

namespace Cherwell_Puzzle
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindDDL();
            }

        }
        protected void btGetVertices_Click(object sender, EventArgs e)
        {
            
            ArrayList vertices = Triangle.GetVertices(ddlRow.SelectedValue, ddlColumn.SelectedValue);
            lbV1.Text = vertices[0].ToString();
            lbV2.Text = vertices[1].ToString();
            lbV3.Text = vertices[2].ToString();
            lbColumn.Text = ddlColumn.SelectedItem.Text;
            lbRow.Text = ddlRow.SelectedItem.Text;
            pnAnswer.Visible = true;
        }
        protected void btGetRowColumn_Click(object sender, EventArgs e)
        {

            v1.Text = "(" + vertex1x.Text + ", " + vertex1y.Text + ")";
            v2.Text = "(" + vertex2x.Text + ", " + vertex2y.Text + ")";
            v3.Text = "(" + vertex3x.Text + ", " + vertex3y.Text + ")";
            Dictionary<string, int> vertices = new Dictionary<string, int>();
            vertices.Add("v1x", int.Parse(vertex1x.Text));
            vertices.Add("v1y", int.Parse(vertex1y.Text));
            vertices.Add("v2x", int.Parse(vertex2x.Text));
            vertices.Add("v2y", int.Parse(vertex2y.Text));
            vertices.Add("v3x", int.Parse(vertex3x.Text));
            vertices.Add("v3y", int.Parse(vertex3y.Text));
            
            
            //lbColumnAnswer.Text = CSGrid.GetColumn(vertex1y.Text, vertex2y.Text, vertex3y.Text);
            lbColumnAnswer.Text = CSGrid.GetColumn(vertices);
            //lbRowAnswer.Text = CSGrid.GetRow(vertex1x.Text, vertex2x.Text, vertex3x.Text);
            lbRowAnswer.Text = CSGrid.GetRow(vertices);
            //pnAnswer.Visible = true;
        }

        private void bindDDL()
        {
            //Bind the columns
            Dictionary<int, string> columns = Enumeration.GetAll<CSGrid.Columns>() as Dictionary<int, String>;
            //foreach(var entry in columns)
            //{
            //    string newValue = entry.Value.ToString().Replace("col", "Column ");
            //    columns.Remove(entry.Key);
            //    columns.Add(entry.Key, newValue);
            //}
            ddlColumn.DataSource = columns;
            ddlColumn.DataTextField = "Value";
            ddlColumn.DataValueField = "Key";
            ddlColumn.DataBind();


            //Bind the rows

            Dictionary<int, string> rows = Enumeration.GetAll<CSGrid.Rows>() as Dictionary<int, string>;
            ddlRow.DataSource = rows;
            ddlRow.DataTextField = "Value";
            ddlRow.DataValueField = "Key";
            ddlRow.DataBind();

        }

    }
}