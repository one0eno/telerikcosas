using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace WebApplication24
{
    public class Person
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
    }
    public partial class _Default : Page
    {

        private List<Person> persona = new List<Person>() {

               new Person() {Id=1, Name = "jOSE1", Age = "22" },
               new Person() { Id = 2, Name = "jOSE2", Age = "21" },
               new Person() { Id = 3, Name = "jOSE3", Age = "12" },
               new Person() { Id = 4, Name = "jOSE4", Age = "25" },
               new Person() { Id = 5, Name = "jOSE5", Age = "45" },
               new Person() { Id = 6, Name = "jOSE6", Age = "58" },
               new Person() { Id = 7, Name = "jOSE7", Age = "28" },
               new Person() { Id = 8, Name = "jOSE8", Age = "66" },
               new Person() { Id = 9, Name = "jOSE9", Age = "23" },
               new Person() { Id = 10, Name = "jOSE10", Age = "45" },
               new Person() { Id = 11, Name = "jOSE11", Age = "65" },
               new Person() { Id = 12, Name = "jOSE12", Age = "75" }
        };
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
            }
            else
            {
                LoadGrid();
            }
            
        }

        public void LoadGrid()
        {

            rgrd.DataSource = persona;
            rgrd.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            GrabarDatos(txtuno.Text);
            LoadGrid(); 
        }

        protected void GrabarDatos(string dato)
        {
            if (Page.IsValid)
            {
                string kk = dato;
            }
        }

        protected void rgrd_ItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
        {
            if (e.Item is GridPagerItem)
            {
                Page.Title = (e.Item as GridPagerItem).Paging.DataSourceCount.ToString();
            }
        }

        protected void rgrd_ItemCreated(object sender, GridItemEventArgs e)
        {
            //if (e.Item is GridPagerItem)
            //{
            //    GridPagerItem pagerItem = e.Item as GridPagerItem;
            //    LinkButton lnkButton = pagerItem.FindControl("LinkButton1") as LinkButton;

            //    lnkButton.CommandName = "Page";
            //    lnkButton.CommandArgument = "Prev";
            //    lnkButton.Text = "Previous page";

            //    lnkButton = pagerItem.FindControl("LinkButton2") as LinkButton;
            //    lnkButton.CommandName = "Page";
            //    lnkButton.CommandArgument = "Next";
            //    lnkButton.Text = "Next page";

            //}
        }

        protected void rgrd_Init(object sender, EventArgs e)
        {
            ////rgrd.MasterTableView.PagerTemplate = new MyPagerTemplate();

        }
    }

    public  class MyPagerTemplate : ITemplate
    {
        protected LinkButton prevButton;
        protected LinkButton nextButton;

        public MyPagerTemplate()
        {

        }
        public void InstantiateIn(Control container)
        {
            //prevButton = new LinkButton();
            //prevButton.ID = "prevButton";
            //prevButton.Text = "Lino page";
            //prevButton.CommandName = "Page";
            //prevButton.CommandArgument = "Page";
            //nextButton = new LinkButton();
            //nextButton.ID = "nextButton";
            //nextButton.Text = "Tadros page";
            //nextButton.CommandName = "Page";
            //nextButton.CommandArgument = "Next";
            //container.Controls.Add(prevButton);
            //container.Controls.Add(new LiteralControl("        "));
            //container.Controls.Add(nextButton);


        }
    }
}