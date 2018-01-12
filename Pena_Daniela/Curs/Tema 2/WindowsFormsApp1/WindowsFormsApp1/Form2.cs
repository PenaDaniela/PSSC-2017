using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        //sql stuff

        SqlConnection conn = new SqlConnection("Data Source=pizza2017.database.windows.net;Initial Catalog=LuigiPizzaDB;Persist Security Info=True;User ID=admin123;Password=111111");

        SqlCommand command = new SqlCommand();

        SqlDataReader dataRead;

        //lists needed
        // IngredientsCounters contains labels where we write the counter for each ingredient
        List<Label> IngredientsNamesLabels = new List<Label>();
        List<Label> IngredientsCounters = new List<Label>();

        public Form2()
        {
            InitializeComponent();
        }


        public void getNumberOfPizzas()
        {
            //we connect
            //conn.Open();

            //command.Connection = conn;

            command.CommandText = "SELECT COUNT(*) AS NumOfRows FROM [Table] WHERE Date >= DATEADD(month, -1, DATEADD(month, DATEDIFF(month, 0, CURRENT_TIMESTAMP), 0)) AND Date < DATEADD(month, DATEDIFF(month, 0, CURRENT_TIMESTAMP), 0)";

            //dataRead = command.ExecuteReader();

            //we read
            //dataRead.Read();

            // we write the nr of pizzas(rows)
            //if ( dataRead.HasRows )
            //{
            //    label5.Text = dataRead["NumOfRows"].ToString();
            //}
            //we disconnect
            //conn.Close();
        }

        public void loadIngredientLabels()
        {
            Form1 f1 = new Form1();

            //foreach ingredient
            foreach(var l in f1.getAllIngredientsList())
            {
                // make a label for the ingredient name
                Label label = new Label();
                label.Text = l.getName();

                label.Margin = new Padding(5, 5, 5, 15);

                IngredientsNamesLabels.Add(label);

                flowLayoutPanel1.Controls.Add(label);

                //make a label for the counter
                Label label999 = new Label();
                label999.Text = "0";
                label999.Margin = new Padding(5, 5, 5, 15);
                flowLayoutPanel1.Controls.Add(label999);

                IngredientsCounters.Add(label999);

            }
        }

        public void loadCountersForIngredients()
        {
            //we connect
            //conn.Open();

            command.Connection = conn;

            command.CommandText = "SELECT Ingredients FROM dbo.[Table] WHERE Date >= DATEADD(month, -1, DATEADD(month, DATEDIFF(month, 0, CURRENT_TIMESTAMP), 0)) AND Date<DATEADD(month, DATEDIFF(month, 0, CURRENT_TIMESTAMP), 0)";

            // we read
            dataRead = command.ExecuteReader();

            string text = "";

            // if data has rows
            if (dataRead.HasRows)
            {
                //we read each row
                while (dataRead.Read())
                {
                    text = dataRead["Ingredients"].ToString();
                    //foreach ingredient we update the counter if the ingredient is present in the ingredients string from db
                    foreach (var ing in IngredientsNamesLabels)
                    {
                        if (text.Contains(ing.Text))
                            // long line of code... what it does is counter++ for the specific ingredient
                            IngredientsCounters.ElementAt(IngredientsNamesLabels.FindIndex(auxLabel => auxLabel.Text == ing.Text)).Text =
                            (Int32.Parse(IngredientsCounters.ElementAt(IngredientsNamesLabels.FindIndex(auxLabel => auxLabel.Text == ing.Text)).Text)+1).ToString();
                    }

                }
                //label1.Text = counter.ToString();
            }

            //we disconnect
            //conn.Close();

        }



        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.luigiPizzaDBDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'luigiPizzaDBDataSet.Table' table. You can move, or remove it, as needed.
            //we load as default the entries from last month
            //this.tableTableAdapter.LastMonth(this.luigiPizzaDBDataSet.Table);
            // we update the labels with the nr of pizzas sold last month
            getNumberOfPizzas();
            // we load the labels in the flowlayout
            loadIngredientLabels();
            // we read from db and load the values in the labels
            loadCountersForIngredients();

        }

        private void lastMonthToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.LastMonth(this.luigiPizzaDBDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lastMonthToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.LastMonth(this.luigiPizzaDBDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.Fill(this.luigiPizzaDBDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
